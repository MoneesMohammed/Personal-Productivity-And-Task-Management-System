using PPTMS.Global_Classes;
using PPTMS.Properties;
using PPTMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlHabit
{
    public partial class CtrlHabits : UserControl
    {
        public event EventHandler OnAddNewHabit_Click;

        public event Action<int> OnShowDetails_Click;
        public event Action<int> OnEdit_Click;
        public event Action<int> OnViewProgress_Click;
        

        private DataTable _dtHabits;
        private int _SelectedHabitID = -1;

        private static bool _toggle;

        public CtrlHabits()
        {
            InitializeComponent();
            
        }

        public void RefreshHabitsList()
        {
            _dtHabits = clsHabit.GetAllHabits(clsGlobal.CurrentUser.UserID);

            if (_dtHabits.Rows.Count > 0)
                _dtHabits.DefaultView.RowFilter = string.Format("[Is Archived] = 'No'");

            dgvHabits.DataSource = _dtHabits;

            lblRecodes.Text = dgvHabits.Rows.Count.ToString();
            _FormatDGV();

            if (cbFilterBy.SelectedIndex != 0)
            {
                if (cbFilterBy.Text == "Habit ID" || cbFilterBy.Text == "Name")
                {
                    ApplyFilterOfTextBox();
                }
                else if (cbFilterBy.Text == "Archived")
                {
                    _dtHabits.DefaultView.RowFilter = string.Format("[Is Archived] = 'Yes'");
                }
                else
                {
                    ApplyFilterOfComboBox();
                }
            }

            RestoreSelection(_SelectedHabitID);

        }

        private void CtrlHabits_Load(object sender, EventArgs e)
        {
            _toggle = !_toggle;
            pBox1.Image = _toggle ? Resources.mental_health : Resources.daily_tasks;

            if (this.DesignMode)
                return;

            cbFilterBy.SelectedIndex = 0;
            RefreshHabitsList();

        }

        private void _FormatDGV()
        {
            if (dgvHabits.Rows.Count <= 0)
            {
                return;
            }

            dgvHabits.Columns[0].Width = 150;
            dgvHabits.Columns[1].Width = 235;
            dgvHabits.Columns[2].Width = 150;
            dgvHabits.Columns[3].Width = 99;
            dgvHabits.Columns[4].Width = 114;
            dgvHabits.Columns[5].Width = 172;
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvHabits.CurrentRow == null)
            {
                e.Cancel = true;
                return;
            }

            if (dgvHabits.CurrentRow != null)
            {
                _SelectedHabitID = (int)dgvHabits.CurrentRow.Cells[0].Value;
            }

            clsHabit Habit = clsHabit.Find(_SelectedHabitID);

            tsmActivateAndDeactivate.Text  = Habit.IsActive ? "Deactivate" : "Activate" ;
            tsmActivateAndDeactivate.Image = Habit.IsActive ? Resources.switch_off : Resources.switch_on;

            DisableAllMenuItems();

            if (Habit.IsActive && !Habit.IsArchived && !Habit.IsCheckIn())
            {
                tsmCheckIn.Enabled = true;
            }
            else if(Habit.IsTodayCheckIn() && Habit.IsActive)
            { 
                tsmUndoCheckIn.Enabled = true;
            }

            if (!Habit.IsArchived)
            {
                tsmEdit.Enabled = true;
                tsmViewProgress.Enabled = true;
                tsmArchiveHabit.Enabled = true;
                tsmActivateAndDeactivate.Enabled = true;
            }



        }

        private void DisableAllMenuItems()
        {
            tsmEdit.Enabled = false;
            tsmViewProgress.Enabled = false;
            tsmCheckIn.Enabled = false;
            tsmUndoCheckIn.Enabled = false;
            tsmActivateAndDeactivate.Enabled = false;
            tsmArchiveHabit.Enabled = false;
        }

        private void tsmShowDetails_Click(object sender, EventArgs e)
        {
            int HabitID = (int)dgvHabits.CurrentRow.Cells[0].Value;
            OnShowDetails_Click?.Invoke(HabitID);
        }

        private void AddNewHabit_Click(object sender, EventArgs e)
        {
            OnAddNewHabit_Click?.Invoke(sender, e);
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int HabitID = (int)dgvHabits.CurrentRow.Cells[0].Value;
            OnEdit_Click?.Invoke(HabitID);
        }

        private void tsmViewProgress_Click(object sender, EventArgs e)
        {
            int HabitID = (int)dgvHabits.CurrentRow.Cells[0].Value;
            OnViewProgress_Click?.Invoke(HabitID);
        }

        private void tsmCheckIn_Click(object sender, EventArgs e)
        {
            clsHabitLog HabitLog = new clsHabitLog();

            HabitLog.HabitID = _SelectedHabitID;

            var result = MessageBox.Show($"Are you sure you want to Check-In the Habit \nby HabitID: {HabitLog.HabitID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (HabitLog.CheckIn())
                {

                    MessageBox.Show("Habit has been Check-In Successfully.", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Habit was not Check-In because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            RefreshHabitsList();
        }

        private void tsmUndoCheckIn_Click(object sender, EventArgs e)
        {
            clsHabitLog HabitLog = new clsHabitLog();

            HabitLog.HabitID = _SelectedHabitID;

            var result = MessageBox.Show($"Are you sure you want to Undo Check-In the Habit \nby HabitID: {HabitLog.HabitID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (HabitLog.UndoCheckIn())
                {
                    MessageBox.Show("Habit has been Undo Check-In Successfully.", "Check-In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Habit was not Undo Check-In because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            RefreshHabitsList();
        }

        private void tsmActivateAndDeactivate_Click(object sender, EventArgs e)
        {
            clsHabit Habit = clsHabit.Find((int)dgvHabits.CurrentRow.Cells[0].Value);

            string MessTitle = Habit.IsActive ? "Deactivate" : "Activate";

            var result = MessageBox.Show($"Are you sure you want to {MessTitle} the Habit \nby HabitID: {Habit.HabitID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                bool did = Habit.IsActive ? Habit.MarkAsDeactivate() : Habit.MarkAsActivate();

                tsmActivateAndDeactivate.Text = Habit.IsActive ? "Activate" : "Deactivate";
                tsmActivateAndDeactivate.Image = Habit.IsActive ? Resources.switch_on : Resources.switch_off;

                if (did)
                {

                    MessageBox.Show($"Habit has been {MessTitle} Successfully.", $"{MessTitle}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Habit was not {MessTitle} because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            RefreshHabitsList();
        }

        private void tsmArchiveHabit_Click(object sender, EventArgs e)
        {
            clsHabit Habit = clsHabit.Find((int)dgvHabits.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Are you sure you want to Archive the Habit \nby HabitID: {Habit.HabitID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (Habit.MarkAsArchived())
                {

                    MessageBox.Show("Habit has been Archived Successfully.", "Archived", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Habit was not Archived because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            RefreshHabitsList();
        }

        private void _FillFrequencyInComboBox()
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("All");
            cbFilter.Items.Add("Daily");
            cbFilter.Items.Add("Weekly");
            cbFilter.Items.Add("Monthly");
           
        }

        private void _FillIsActiveInComboBox()
        {
            cbFilter.Items.Clear();

            cbFilter.Items.Add("All");
            cbFilter.Items.Add("Yes");
            cbFilter.Items.Add("No");
            
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtFilterBy.Text != "")
                txtFilterBy.Text = string.Empty;

            if (cbFilterBy.Text == "None")
            {
                txtFilterBy.Visible = false;
                cbFilter.Visible = false;
                RefreshHabitsList();
            }
            else if (cbFilterBy.Text == "Frequency")
            {
                _FillFrequencyInComboBox();
                cbFilter.SelectedIndex = 0;

                txtFilterBy.Visible = false;
                cbFilter.Visible = true;
            }
            else if (cbFilterBy.Text == "Is Active")
            {
                _FillIsActiveInComboBox();
                cbFilter.SelectedIndex = 0;

                txtFilterBy.Visible = false;
                cbFilter.Visible = true;
            }
            else if (cbFilterBy.Text == "Archived")
            {
                txtFilterBy.Visible = false;
                cbFilter.Visible = false;
                _dtHabits.DefaultView.RowFilter = string.Format("[Is Archived] = 'Yes'");
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
            ApplyFilterOfComboBox();
        }

        private void txtFilterBy_TextChanged(object sender, EventArgs e)
        {
            ApplyFilterOfTextBox();

        }

        private void ApplyFilterOfComboBox()
        {
            string FilterColumn = cbFilter.Text;
            string FilterByColumn = cbFilterBy.Text;

            if (FilterColumn == "All")
            {
                _dtHabits.DefaultView.RowFilter = "[Is Archived] = 'No'";
                lblRecodes.Text = _dtHabits.Rows.Count.ToString();
                return;
            }

            _dtHabits.DefaultView.RowFilter = string.Format($"[{FilterByColumn}] = '{FilterColumn}' AND [Is Archived] = 'No'");

            lblRecodes.Text = dgvHabits.Rows.Count.ToString();

        }

        private void ApplyFilterOfTextBox()
        {
            string FilterColumn = cbFilterBy.Text;

            if (txtFilterBy.Text.Trim() == "" || FilterColumn == "None" || FilterColumn == "Frequency")
            {
                _dtHabits.DefaultView.RowFilter = "[Is Archived] = 'No'";
                lblRecodes.Text = _dtHabits.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "Habit ID")
                _dtHabits.DefaultView.RowFilter = string.Format("[{0}] = {1} AND [Is Archived] = 'No'", FilterColumn, txtFilterBy.Text.Trim()); //[FilterColumn] = txtFilterBy.Text
            else
                _dtHabits.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%' AND [Is Archived] = 'No'", FilterColumn, txtFilterBy.Text.Trim());
            //[FilterColumn] LIKE 'txtFilterBy.Text%'

            lblRecodes.Text = dgvHabits.Rows.Count.ToString();

        }


        private void txtFilterBy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Habit ID")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

            }
        }

        private void RestoreSelection(int HabitID)
        {
            if (HabitID == -1) return;

            foreach (DataGridViewRow row in dgvHabits.Rows)
            {
                if ((int)row.Cells["Habit ID"].Value == HabitID)
                {
                    row.Selected = true;
                    dgvHabits.CurrentCell = row.Cells[0];
                    dgvHabits.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }


    }
}
