using PPTMS.Global_Classes;
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

namespace PPTMS.UserControls.CtrlTasks
{
    public partial class CtrlTasks : UserControl
    {
        public event EventHandler OnAddNewTask_Click;

        public event Action<int> OnShowDetails_Click;
        public event Action<int> OnEdit_Click;
        public event Action<int> OnReminders_Click;
        public event Action<int> OnAttachments_Click;
        

        private DataTable _dtTasks;

        public CtrlTasks()
        {
            InitializeComponent();
        }

        public void RefreshTasksList()
        {
            _dtTasks = clsTask.GetAllTasks(clsGlobal.CurrentUser.UserID);

            if (_dtTasks.Rows.Count > 0)
                _dtTasks.DefaultView.RowFilter = string.Format("[Status] NOT = 'Archived'");

            dgvTasks.DataSource = _dtTasks;

            lblRecodes.Text = dgvTasks.Rows.Count.ToString();
            _FormatDGV();

        }

        private void _FormatDGV()
        {
            if (dgvTasks.Rows.Count <= 0)
            {
                return;
            }

            dgvTasks.Columns[0].Width = 150;
            dgvTasks.Columns[1].Width = 170;
            dgvTasks.Columns[2].Width = 150;
            dgvTasks.Columns[3].Width = 141;
            dgvTasks.Columns[4].Width = 135;
            dgvTasks.Columns[5].Width = 177;
            dgvTasks.Columns[6].Width = 196;
            
        }

        private void CtrlTasks_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;

            RefreshTasksList();
            cbFilterBy.SelectedIndex = 0;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            int TaskID = (int)dgvTasks.CurrentRow.Cells[0].Value;
            clsTask Task = clsTask.Find(TaskID);

            DisableAllMenuItems();


            switch (Task.Status)
            {
                case clsTask.enStatus.New:
                case clsTask.enStatus.InProgress:
                case clsTask.enStatus.OnHold:

                    tsmEdit.Enabled = true;
                    tsmReminders.Enabled = true;
                    tsmAttachments.Enabled = true;
                    tsmMarkAsCompleted.Enabled = true;
                    tsmArchiveTask.Enabled = true;

                    tsmInProgressTask.Enabled = Task.Status != clsTask.enStatus.InProgress;
                    tsmOnHoldTask.Enabled = Task.Status != clsTask.enStatus.OnHold;
                    break;

                case clsTask.enStatus.Completed:
                    tsmArchiveTask.Enabled = true;
                    tsmAttachments.Enabled = true;
                    break;

                case clsTask.enStatus.Archived:
                    
                    break;
            }

        }

        private void DisableAllMenuItems()
        {
            tsmEdit.Enabled = false;
            tsmReminders.Enabled = false;
            tsmAttachments.Enabled = false;
            tsmMarkAsCompleted.Enabled = false;
            tsmArchiveTask.Enabled = false;
            tsmInProgressTask.Enabled = false;
            tsmOnHoldTask.Enabled = false;
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int TaskID = (int)dgvTasks.CurrentRow.Cells[0].Value;
            OnShowDetails_Click?.Invoke(TaskID);
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int TaskID = (int)dgvTasks.CurrentRow.Cells[0].Value;
            OnEdit_Click?.Invoke(TaskID);
        }
        private void tsmReminders_Click(object sender, EventArgs e)
        {
            int TaskID = (int)dgvTasks.CurrentRow.Cells[0].Value;
            OnReminders_Click?.Invoke(TaskID);
        }

        private void tsmAttachments_Click(object sender, EventArgs e)
        {
            int TaskID = (int)dgvTasks.CurrentRow.Cells[0].Value;
            OnAttachments_Click?.Invoke(TaskID);
        }

        private void tsmArchiveTask_Click(object sender, EventArgs e)
        {
            clsTask Task = clsTask.Find((int)dgvTasks.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Are you sure you want to Archive the Task \nby TaskID: {Task.TaskID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (Task.MarkAsArchived())
                {

                    MessageBox.Show("Task has been Archived Successfully.", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Task was not Archived because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            RefreshTasksList();
        }

        private void tsmMarkAsCompleted_Click(object sender, EventArgs e)
        {
            clsTask Task = clsTask.Find((int)dgvTasks.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Are you sure you want to Complete the Task \nby TaskID: {Task.TaskID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (Task.MarkAsCompleted())
                {
                    MessageBox.Show("Task has been Completed Successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Task was not Completed because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            RefreshTasksList();
        }

        private void AddNewTask_Click(object sender, EventArgs e)
        {
            OnAddNewTask_Click?.Invoke(sender, e);
        }

        private void _FillCategoryInComboBox()
        {
            cbFilter.Items.Clear();
            cbFilter.Items.Add("All");
            DataTable dtCategories = clsTaskCategory.GetAllCategories(clsGlobal.CurrentUser.UserID);

            foreach (DataRow row in dtCategories.Rows)
            {
                cbFilter.Items.Add(row["Category Name"]);
            }

        }
        
        private void _FillStatusInComboBox()
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("All");
            cbFilter.Items.Add("New");
            cbFilter.Items.Add("In Progress");
            cbFilter.Items.Add("Completed");
            cbFilter.Items.Add("Archived");
            cbFilter.Items.Add("On Hold");

        }

        private void _FillPriorityInComboBox()
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("All");
            cbFilter.Items.Add("Low");
            cbFilter.Items.Add("Medium");
            cbFilter.Items.Add("High");
            cbFilter.Items.Add("Critical");

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.Text != "")
                txtFilterBy.Text = string.Empty;

            if (cbFilterBy.Text == "None")
            {
                txtFilterBy.Visible = false;
                cbFilter.Visible = false;
                RefreshTasksList();
            }
            else if (cbFilterBy.Text == "Category")
            {
                _FillCategoryInComboBox();
                cbFilter.SelectedIndex = 0;

                txtFilterBy.Visible = false;
                cbFilter.Visible = true;
            }
            else if (cbFilterBy.Text == "Status")
            {
                _FillStatusInComboBox();
                cbFilter.SelectedIndex = 0;

                txtFilterBy.Visible = false;
                cbFilter.Visible = true;
            }
            else if (cbFilterBy.Text == "Priority")
            {
                _FillPriorityInComboBox();
                cbFilter.SelectedIndex = 0;

                txtFilterBy.Visible = false;
                cbFilter.Visible = true;
            }
            else
            {
                txtFilterBy.Visible = true;
                cbFilter.Visible = false;
                txtFilterBy.Focus();
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "All")
            {
                RefreshTasksList();
                return;
            }

            string FilterColumn = cbFilter.Text;

            string FilterByColumn = cbFilterBy.Text;

            _dtTasks.DefaultView.RowFilter = string.Format($"[{FilterByColumn}] = '{FilterColumn}'");

            lblRecodes.Text = dgvTasks.Rows.Count.ToString();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = cbFilterBy.Text;

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None" || FilterColumn == "Category")
            {
                _dtTasks.DefaultView.RowFilter = "";
                lblRecodes.Text = _dtTasks.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Task ID")
                _dtTasks.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilterBy.Text.Trim()); //[FilterColumn] = txtFilterBy.Text
            else
                _dtTasks.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, txtFilterBy.Text.Trim());
            //[FilterColumn] LIKE 'txtFilterBy.Text%'

            lblRecodes.Text = dgvTasks.Rows.Count.ToString();
        }

        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Task ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }

        private void tsmInProgressTask_Click(object sender, EventArgs e)
        {
            clsTask Task = clsTask.Find((int)dgvTasks.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Are you sure you want to In Progress the Task \nby TaskID: {Task.TaskID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (Task.MarkAsInProgress())
                {
                    MessageBox.Show("Task has been In Progress Successfully.", "In Progress", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Task was not In Progress because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            RefreshTasksList();
        }

        private void tsmOnHoldTask_Click(object sender, EventArgs e)
        {
            clsTask Task = clsTask.Find((int)dgvTasks.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Are you sure you want to On Hold the Task \nby TaskID: {Task.TaskID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (Task.MarkAsOnHold())
                {
                    MessageBox.Show("Task has been On Hold Successfully.", "On Hold", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Task was not On Hold because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            RefreshTasksList();
        }
    }


}
