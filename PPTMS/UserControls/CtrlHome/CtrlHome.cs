using PPTMS.Global_Classes;
using PPTMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlHome
{
    public partial class CtrlHome : UserControl
    {
        private DataTable _dtTodayTasks;
        private DataTable _dtCheckInHabitsToday;

        private clsStatistic _Statistic;

        private int _UserID = -1;

        public CtrlHome()
        {
            InitializeComponent();
        }

        public void RefreshLists()
        {
            _dtTodayTasks = clsTask.GetTodayTasks(_UserID);
            _dtCheckInHabitsToday = clsHabit.GetCheckInHabits(_UserID);

            if (_dtTodayTasks.Rows.Count <= 0)
                lblMessNoTasks.Visible = true;

            if (_dtCheckInHabitsToday.Rows.Count <= 0)
                lblMessCheckInHabits.Visible = true;

            dgvTodayTasks.DataSource = _dtTodayTasks;
            dgvCheckInHabitsToday.DataSource = _dtCheckInHabitsToday;

            _FormatDGVCheckIn();
            _FormatDGVTodayTasks();
        }

        private void _FormatDGVCheckIn()
        {
            if (dgvCheckInHabitsToday.Rows.Count <= 0)
            {
                return;
            }

            dgvCheckInHabitsToday.Columns[0].Width = 248;
            dgvCheckInHabitsToday.Columns[1].Width = 123;
            dgvCheckInHabitsToday.Columns[2].Width = 107;
            dgvCheckInHabitsToday.Columns[3].Width = 142;

        }

        private void _FormatDGVTodayTasks()
        {
            if (dgvTodayTasks.Rows.Count <= 0)
            {
                return;
            }

            dgvTodayTasks.Columns[0].Width = 228;
            dgvTodayTasks.Columns[1].Width = 97;
            dgvTodayTasks.Columns[2].Width = 111;

            //228 96 112
        }

        private void lblTitle_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;

            // Quality improvement
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Gradient background drawing
            using (LinearGradientBrush brush = new LinearGradientBrush(
                lbl.ClientRectangle,
                Color.FromArgb(253, 173, 62),
                Color.FromArgb(255, 7, 73),
                90f))
            {
                e.Graphics.FillRectangle(brush, lbl.ClientRectangle);
            }

            //Text drawing
            TextRenderer.DrawText(
                e.Graphics,
                lbl.Text,
                lbl.Font,
                lbl.ClientRectangle,
                Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }

        private void CtrlHome_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;
            _UserID = clsGlobal.CurrentUser.UserID;

            LoadInfo();
            RefreshLists();
        }


        public void LoadInfo()
        {
            _Statistic = clsStatistic.Find(_UserID);

            if (_Statistic == null)
            {
                ResetStatisticInfo();
                MessageBox.Show($"No Statistic ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillStatisticInfo();

        }

        private void _FillStatisticInfo()
        {
            lblWelcome.Text = $"👋 Welcome {clsGlobal.CurrentUser.UserName}";
            lblToday.Text = $"Today is {DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("dd MMM yyyy")}";

            lblTotalTasks.Text   = _Statistic.TotalTasks.ToString("0");
            lblCompleted.Text    = _Statistic.CompletedTasks.ToString("0");
            lblActiveHabits.Text = _Statistic.ActiveHabits.ToString("0");
            lblDueToday.Text     = _Statistic.DueToday().ToString("0");

            lblGreetingMessage.Text = GetGreetingMessage();

            lblMessHaveTasks.Text = _Statistic.DueToday() > 0 ? $"You have {_Statistic.DueToday()} tasks due today": "You have no tasks due today";

            string CMTasksIn = _Statistic.CompleteMoreTasksIn;

            string emoji = CMTasksIn == "Morning" || CMTasksIn == "Afternoon" ? "☀️" : CMTasksIn == "Evening" ? "🌙" : "🌙";

            lblInsight.Text = CMTasksIn != "" ? $"You Complete More Tasks In The {CMTasksIn} {emoji}" : "N/A";


        }

        private void ResetStatisticInfo()
        {
            lblWelcome.Text = $"👋 Welcome {clsGlobal.CurrentUser.UserName}";
            lblToday.Text = $"Today is {DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("dd MMM yyyy")}";

            lblTotalTasks.Text = "--";
            lblCompleted.Text = "--";
            lblActiveHabits.Text = "--";
            lblDueToday.Text = "--";

            lblGreetingMessage.Text = GetGreetingMessage();
            lblMessHaveTasks.Text = "You have no tasks due today";

            lblInsight.Text = "N/A";

        }


        private string GetGreetingMessage()
        {
            int hour = DateTime.Now.Hour;

            if (hour >= 5 && hour < 12)
            {
                return "Good Morning ☀️";
            }
            else if (hour >= 12 && hour < 18)
            {
                return "Good Afternoon ☀️";
            }
            else if (hour >= 18 && hour < 23)
            {
                return "Good Evening 🌙";
            }
            else
            {
                return "Good Night 🌙";
            }
        }

       
    }
}
