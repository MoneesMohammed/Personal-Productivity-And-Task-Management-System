using PPTMS.Properties;
using PPTMS_BusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlHabit.Habit_Info
{
    public partial class CtrlHabitInfo : UserControl
    {
        public event EventHandler OnBack_Click;
        public event Action<int> OnEditHabitInfo_LinkClicke;

        private clsHabit _Habit = new clsHabit();
        private int _HabitID = -1;

        public int HabitID { get { return _HabitID; } }
        public clsHabit SelectedHabitInfo { get { return _Habit; } }

        public CtrlHabitInfo()
        {
            InitializeComponent();
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

            llblEditHabitInfo.Enabled = (_Habit.IsActive && !_Habit.IsArchived);

            lblHabitID.Text    = _Habit.HabitID.ToString();
            lblHabitName.Text  = _Habit.Name;
            lblFrequency.Text  = _Habit.FrequencyText;
            lblIsArchived.Text = _Habit.IsArchived ? "Yes" : "No";
            lblIsActive.Text   = _Habit.IsActive ? "Yes" : "No";
            labelIsActive.Image  = _Habit.IsActive ? Resources.switch_on__1_ : Resources.switch_off__1_;
            lblCreateDate.Text = _Habit.CreateDate.ToString("dd/MM/yyyy");

        }

        private void ResetHabitInfo()
        {
            _HabitID = -1;
            llblEditHabitInfo.Enabled = false;

            lblHabitID.Text    = "[???]";
            lblHabitName.Text  = "[???]";
            lblFrequency.Text  = "[???]";
            lblIsArchived.Text = "[???]";
            lblIsActive.Text   = "[???]";
            lblCreateDate.Text = "[??/??/????]";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender, e);
        }

        private void llblEditHabitInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnEditHabitInfo_LinkClicke?.Invoke(_HabitID);
        }
    }
}
