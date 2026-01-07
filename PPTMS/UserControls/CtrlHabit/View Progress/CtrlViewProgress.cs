using PPTMS.Properties;
using PPTMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlHabit.View_Progress
{
    public partial class CtrlViewProgress : UserControl
    {
        public event EventHandler OnBack_Click;
        private static bool _toggle;

        private int _HabitID = -1;
        private clsHabit _Habit = new clsHabit();

        public CtrlViewProgress(int HabitID)
        {
            InitializeComponent();
            _HabitID = HabitID;
        }

        private void CtrlViewProgress_Load(object sender, EventArgs e)
        {
            _toggle = !_toggle;
            pBox1.Image = _toggle ? Resources.progress__1_ : Resources.advancement;

            LoadInfo(_HabitID);
        }

        public void LoadInfo(int HabitID)
        {
            _Habit = clsHabit.Find(HabitID);

            if (_Habit == null)
            {
                ResetHabitInfo();
                MessageBox.Show($"No Habit With HabitID ={HabitID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillHabitInfo();

        }

        private void _FillHabitInfo()
        {
            _HabitID = _Habit.HabitID;

            lblHabitName.Text = _Habit.Name;
            lblFrequency.Text = _Habit.FrequencyText;
            lblStatus.Text = _Habit.StatusText;

            lblStartDate.Text = _Habit.CreateDate.ToString("dd/MM/yyyy");

            lblCurrentStreak.Text = _Habit.CurrentStreak().ToString("0");
            lblBestStreak.Text = _Habit.BestStreak().ToString("0");
            lblCompletionRate.Text = _Habit.CompletionRate().ToString()+"%";
            lblTodayStatus.Text = _Habit.IsCheckIn() ? "Done today" : "Not done today";
            labelToday.Image = _Habit.IsCheckIn() ? Resources.calendar1 : Resources.calendars;

        }

        private void ResetHabitInfo()
        {
            _HabitID = -1;
            
            lblHabitName.Text = "[???]";
            lblFrequency.Text = "[???]";
            lblStatus.Text = "[???]";
            lblStartDate.Text = "[??/??/????]";

            lblCurrentStreak.Text  = "[???]";
            lblBestStreak.Text     = "[???]";
            lblCompletionRate.Text = "[???]";
            lblTodayStatus.Text    = "[???]";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender, e);
        }
    }
}
