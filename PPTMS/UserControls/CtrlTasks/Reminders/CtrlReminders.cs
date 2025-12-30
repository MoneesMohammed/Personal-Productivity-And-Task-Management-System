using PPTMS.Global_Classes;
using PPTMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlTasks.Reminders
{
    public partial class CtrlReminders : UserControl
    {
        public event EventHandler OnBack_Click;
        public event EventHandler OnAddNewReminder_Click;
        public event Action<int> OnEdit_Click;

        private DataTable _dtReminders;
        private int _TaskID = -1;

        public CtrlReminders()
        {
            InitializeComponent();
        }

        public void SetTaskID(int TaskID)
        {
            _TaskID = TaskID;
        }

        public void RefreshRemindersList()
        {
            if (_TaskID == -1)
                return;

           _dtReminders = clsTaskReminder.GetAllReminders(_TaskID);

            dgvReminders.DataSource = _dtReminders;

            lblRecodes.Text = dgvReminders.Rows.Count.ToString();
            _FormatDGV();

        }

        private void _FormatDGV()
        {
            if (dgvReminders.Rows.Count <= 0)
            {
                return;
            }

            dgvReminders.Columns[0].Width = 150;
            dgvReminders.Columns[1].Width = 282;
            dgvReminders.Columns[2].Width = 136;

           
        }

        private void CtrlReminders_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;

            RefreshRemindersList();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender,e);
        }

        private void AddNewReminder_Click(object sender, EventArgs e)
        {
            OnAddNewReminder_Click?.Invoke(sender,e);
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int ReminderID = (int)dgvReminders.CurrentRow.Cells[0].Value;

            OnEdit_Click?.Invoke(ReminderID);
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            clsTaskReminder TaskReminder = clsTaskReminder.Find((int)dgvReminders.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Are you sure you want to Delete the Reminder \nby ReminderID: {TaskReminder.ReminderID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (TaskReminder.Delete())
                {

                    MessageBox.Show("Reminder has been Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reminder was not Deleted because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            RefreshRemindersList();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvReminders.Rows.Count <= 0)
            {
                tsmEdit.Enabled = false;
                tsmDelete.Enabled = false;
                return;
            }
            else
            {
                tsmEdit.Enabled = true;
                tsmDelete.Enabled = true;
            }

            int ReminderID = (int)dgvReminders.CurrentRow.Cells[0].Value;
            clsTaskReminder TaskReminder = clsTaskReminder.Find(ReminderID);


            if (TaskReminder.IsTriggered)
            {
                tsmEdit.Enabled = false;
            }
            else
            {
                tsmEdit.Enabled = true;
            }

        }
    }
}
