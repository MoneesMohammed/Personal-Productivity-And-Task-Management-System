using PPTMS.UserControls.CtrlCategories;
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
    public partial class CtrlFullTaskInfo : UserControl
    {
        public event EventHandler OnBack_Click;

        public CtrlFullTaskInfo(int TaskID)
        {
            InitializeComponent();
            ctrlTaskInfo1.LoadInfo(TaskID);
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void ctrlTaskInfo1_OnEditTaskInfo_LinkClicke(int obj)
        {
            CtrlAddEditTaskInfo ctrlEditTask = new CtrlAddEditTaskInfo(obj);
            ctrlEditTask.OnBack_Click += CtrlTaskInfo1_OnBack_Click;

            LoadControl(ctrlEditTask);
        }

        private void CtrlTaskInfo1_OnBack_Click(object sender, EventArgs e)
        {
            int TaskID = ctrlTaskInfo1.TaskID;

            ctrlTaskInfo1.LoadInfo(TaskID);
            LoadControl(ctrlTaskInfo1);
        }

        private void ctrlTaskInfo1_OnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender,e);
        }
    }
}
