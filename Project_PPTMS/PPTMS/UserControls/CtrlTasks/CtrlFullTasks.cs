using PPTMS.UserControls.CtrlCategories;
using PPTMS.UserControls.CtrlTasks.Attachments;
using PPTMS.UserControls.CtrlTasks.Reminders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlTasks
{
    public partial class CtrlFullTasks : UserControl
    {
        public CtrlFullTasks()
        {
            InitializeComponent();
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void ctrlTasks1_OnShowDetails_Click(int obj)
        {
            CtrlFullTaskInfo ctrlTaskInfo = new CtrlFullTaskInfo(obj);
            
            ctrlTaskInfo.OnBack_Click += CtrlTasks1_OnBack_Click;
            LoadControl(ctrlTaskInfo);
        }

        private void CtrlTasks1_OnBack_Click(object sender, EventArgs e)
        {
            ctrlTasks1.RefreshTasksList();
            LoadControl(ctrlTasks1);
        }

        private void ctrlTasks1_OnAddNewTask_Click(object sender, EventArgs e)
        {
            CtrlAddEditTaskInfo ctrlAddTask = new CtrlAddEditTaskInfo();
            ctrlAddTask.OnBack_Click += CtrlTasks1_OnBack_Click;

            LoadControl(ctrlAddTask);
        }

        private void ctrlTasks1_OnEdit_Click(int obj)
        {
            CtrlAddEditTaskInfo ctrlEditTask = new CtrlAddEditTaskInfo(obj);
            ctrlEditTask.OnBack_Click += CtrlTasks1_OnBack_Click;

            LoadControl(ctrlEditTask);
        }

        private void ctrlTasks1_OnReminders_Click(int obj)
        {
            CtrlFullReminders ctrlReminders = new CtrlFullReminders(obj);
            ctrlReminders.OnBack_Click += CtrlTasks1_OnBack_Click;
            LoadControl(ctrlReminders);
        }

        private void ctrlTasks1_OnAttachments_Click(int obj)
        {
            CtrlFullAttachments ctrlAttachments = new CtrlFullAttachments(obj);
            ctrlAttachments.OnBack_Click += CtrlTasks1_OnBack_Click;

            LoadControl(ctrlAttachments);
        }
    }
}
