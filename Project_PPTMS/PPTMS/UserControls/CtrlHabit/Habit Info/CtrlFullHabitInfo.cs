using PPTMS.UserControls.CtrlHabit.Add_Edit_Habit;
using PPTMS.UserControls.CtrlTasks;
using System;
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
    public partial class CtrlFullHabitInfo : UserControl
    {
        public event EventHandler OnBack_Click;

        public CtrlFullHabitInfo(int HabitID)
        {
            InitializeComponent();
            ctrlHabitInfo1.LoadInfo(HabitID);
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void ctrlHabitInfo1_OnEditHabitInfo_LinkClicke(int obj)
        {
            CtrlAddEditHabit ctrlEditHabit = new CtrlAddEditHabit(obj);
            ctrlEditHabit.OnBack_Click += CtrlHabitInfo1_OnBack_Click;

            LoadControl(ctrlEditHabit);
        }

        private void CtrlHabitInfo1_OnBack_Click(object sender, EventArgs e)
        {
            int HabitID = ctrlHabitInfo1.HabitID;

            ctrlHabitInfo1.LoadInfo(HabitID);
            LoadControl(ctrlHabitInfo1);
        }

        private void ctrlHabitInfo1_OnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender, e);
        }
    }
}
