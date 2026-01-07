using PPTMS.UserControls.CtrlHabit.Add_Edit_Habit;
using PPTMS.UserControls.CtrlHabit.Habit_Info;
using PPTMS.UserControls.CtrlHabit.View_Progress;
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

namespace PPTMS.UserControls.CtrlHabit
{
    public partial class CtrlFullHabits : UserControl
    {
        public CtrlFullHabits()
        {
            InitializeComponent();
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void ctrlHabits1_OnAddNewHabit_Click(object sender, EventArgs e)
        {
            CtrlAddEditHabit ctrlAddHabit = new CtrlAddEditHabit();

            ctrlAddHabit.OnBack_Click += CtrlHabits1_OnBack_Click;
            LoadControl(ctrlAddHabit);
        }

        private void CtrlHabits1_OnBack_Click(object sender, EventArgs e)
        {
            ctrlHabits1.RefreshHabitsList();
            LoadControl(ctrlHabits1);
        }


        private void ctrlHabits1_OnEdit_Click(int obj)
        {
            CtrlAddEditHabit ctrlEditHabit = new CtrlAddEditHabit(obj);

            ctrlEditHabit.OnBack_Click += CtrlHabits1_OnBack_Click;
            LoadControl(ctrlEditHabit);
        }

        private void ctrlHabits1_OnShowDetails_Click(int obj)
        {
            CtrlFullHabitInfo HabitInfo = new CtrlFullHabitInfo(obj);
            
            HabitInfo.OnBack_Click += CtrlHabits1_OnBack_Click;
            LoadControl(HabitInfo);
        }

        private void ctrlHabits1_OnViewProgress_Click(int obj)
        {
            CtrlViewProgress viewProgress = new CtrlViewProgress(obj);

            viewProgress.OnBack_Click+= CtrlHabits1_OnBack_Click;

            LoadControl(viewProgress);
        }
    }
}
