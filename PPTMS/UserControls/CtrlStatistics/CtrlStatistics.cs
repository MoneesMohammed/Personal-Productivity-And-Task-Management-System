using PPTMS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PPTMS.UserControls.CtrlStatistics
{
    public partial class CtrlStatistics : UserControl
    {
        private static bool _toggle;

        public CtrlStatistics()
        {
            InitializeComponent();
        }

        private void CtrlStatistics_Load(object sender, EventArgs e)
        {
            _toggle = !_toggle;
            pBox1.Image = _toggle ? Resources.description : Resources.hr;

            TasksbyStatus_PieChart();
            TasksbyStatus_BarChart();
            TasksCompletedChart();
        }

        private void TasksbyStatus_PieChart()
        {
            // Clear default series if any exist
            chart1.Series.Clear();

            // Create a new series and set its chart type to Pie
            Series series1 = new Series("MyPieSeries");
            series1.ChartType = SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Arial", 14f, FontStyle.Regular);

            // Add data points (Argument, Value)
            // The arguments are the labels, and the values are the slice sizes
            series1.Points.AddXY("Completed", 3);
            series1.Points.AddXY("In Progress", 4);
            series1.Points.AddXY("On Hold", 2);

            // Optional: Format labels to show percentage and value
            //series1.LabelFormat = "{P0}"; // Shows percentage with 2 decimal places
            // Or you can use a custom function for more control, e.g., "{A} ({P0})" for Argument (Percentage)

            
            // Optional: Enable data labels and legend
            series1.IsValueShownAsLabel = true;
            chart1.Legends[0].Enabled = true;

            // Add the series to the chart control
            chart1.Series.Add(series1);

            // Customize the legend position (optional)
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Font = new Font("Verdana", 13f);
        }

        private void TasksbyStatus_BarChart()
        {
            // Optional: Clear default series and chart areas if they exist
            chart2.ChartAreas.Clear();
            chart2.Series.Clear();

            // 1. Create a Chart Area
            ChartArea chartArea = new ChartArea("GraphArea");
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;

            chartArea.AxisX.LabelStyle.Font = new Font("Arial", 14f, FontStyle.Bold);
            chartArea.AxisY.LabelStyle.Font = new Font("Arial", 14f, FontStyle.Bold);

            chartArea.AxisX.TitleFont = new Font("Arial", 13f, FontStyle.Regular);
            chartArea.AxisY.TitleFont = new Font("Arial", 13f, FontStyle.Regular);

            chartArea.AxisX.Title = "Priority";
            chartArea.AxisY.Title = "Task Count";
            
           // chartArea.Font = new System.Drawing.Font("Arial", 14f, FontStyle.Regular);
            chart2.ChartAreas.Add(chartArea);

            // 2. Create a Series and set the chart type to Bar (horizontal bars) or Column (vertical bars)
            Series seriesSales = new Series("Tasks")
            {
                ChartType = SeriesChartType.Bar, // Use SeriesChartType.Column for vertical bars
                IsValueShownAsLabel = true, // Display the Y-value on top of the bars
                Font = new System.Drawing.Font("Arial", 14f, FontStyle.Bold)
            };

            // 3. Add Data Points (example data)
            seriesSales.Points.AddXY("Low", 3);
            seriesSales.Points.AddXY("Medium", 4);
            seriesSales.Points.AddXY("High", 5);
            seriesSales.Points.AddXY("Critical", 7);

            // 4. Add the Series to the Chart control
            chart2.Series.Add(seriesSales);

            // Optional: Customize fonts/appearance
            seriesSales.Font = new Font("Verdana", 14);
            chart2.Legends[0].Font = new Font("Verdana", 14f);

        }

        private void TasksCompletedChart()
        {
            // Clear any default series that might exist
            chart3.Series.Clear();
            chart3.ChartAreas.Clear();

            // Add a Chart Area
            ChartArea chartArea1 = new ChartArea();
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;

            chartArea1.AxisX.LabelStyle.Font = new Font("Arial", 14f, FontStyle.Bold);
            chartArea1.AxisY.LabelStyle.Font = new Font("Arial", 14f, FontStyle.Bold);

            chart3.ChartAreas.Add(chartArea1);

            // Add a Series for the data
            Series series1 = new Series();
            series1.Name = "Tasks Completed";

            // Set the chart type to Column (vertical bars)
            series1.ChartType = SeriesChartType.Column;

            // Add sample data points
            series1.Points.AddXY("Today", 2);
            series1.Points.AddXY("This Week", 7);
            series1.Points.AddXY("This Month", 15);
            

            // Add the series to the chart control
            chart3.Series.Add(series1);

            series1.Font = new Font("Verdana", 14);
            chart3.Legends[0].Font = new Font("Verdana", 14f);
            // Optional: Customize chart appearance
            //chart3.ChartAreas[0].AxisX.Title = "Month";
            //chart3.ChartAreas[0].AxisY.Title = "Sales Value";
            series1.IsValueShownAsLabel = true; // Display values on top of bars
        }

    }
}
