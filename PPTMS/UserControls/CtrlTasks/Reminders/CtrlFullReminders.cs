using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlTasks.Reminders
{
    public partial class CtrlFullReminders : UserControl
    {
        public event EventHandler OnBack_Click;

        private int _TaskID = -1;

        public CtrlFullReminders(int TaskID)
        {
            InitializeComponent();
            _TaskID = TaskID;
            ctrlReminders1.SetTaskID(TaskID);
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void ctrlReminders1_OnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender, e);
        }

        private void ctrlReminders1_OnAddNewReminder_Click(object sender, EventArgs e)
        {

            CtrlAddEditReminders ctrlAddReminders = new CtrlAddEditReminders(_TaskID);
            ctrlAddReminders.OnBack_Click += CtrlReminders1_OnBack_Click;
            LoadControl(ctrlAddReminders);
        }

        private void CtrlReminders1_OnBack_Click(object sender, EventArgs e)
        {
            ctrlReminders1.RefreshRemindersList();
            LoadControl(ctrlReminders1);
        }


        private void ctrlReminders1_OnEdit_Click(int obj)
        {
            CtrlAddEditReminders ctrlEditReminders = new CtrlAddEditReminders(_TaskID, obj);
            ctrlEditReminders.OnBack_Click += CtrlReminders1_OnBack_Click;
            LoadControl(ctrlEditReminders);
        }
    }
}
