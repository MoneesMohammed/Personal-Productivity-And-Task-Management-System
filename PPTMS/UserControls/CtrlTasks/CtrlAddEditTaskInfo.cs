using PPTMS.Global_Classes;
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
using static PPTMS_BusinessLayer.clsTask;

namespace PPTMS.UserControls.CtrlTasks
{
    public partial class CtrlAddEditTaskInfo : UserControl
    {
        public event EventHandler OnBack_Click;
        
        //Delegate
        public delegate void DataFoundEventHandler(object sender, int CategoryID);

        public event DataFoundEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;
        private int _TaskID = -1;
        private clsTask _Task;

        public CtrlAddEditTaskInfo()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public CtrlAddEditTaskInfo(int TaskID)
        {
            InitializeComponent();
            _TaskID = TaskID;
            _Mode = enMode.Update;
        }

        private void _FillCategoryInComboBox()
        {
            DataTable dtCategories = clsTaskCategory.GetAllCategories(clsGlobal.CurrentUser.UserID);

            foreach (DataRow row in dtCategories.Rows)
            {
                cbCategory.Items.Add(row["Category Name"]);
            }

        }

        private void _ResatDefualtValues()
        {
            _FillCategoryInComboBox();

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Task";
                _Task = new clsTask();
                picIcon.Image = Resources.add_task;
                
            }
            else
            {
                lblMode.Text = "Edit Task";
                picIcon.Image = Resources.edit_task;

                btnSave.Enabled = true;
            }

            
            dtpDueDate.Value = DateTime.Now;
            dtpDueDate.MinDate = DateTime.Now;

            cbCategory.SelectedIndex = 0;
            cbPriority.SelectedIndex = 0;
            txtTitle.Text = "";
            txtEstimatedMinutes.Text = "30";
            txtDescription.Text = "";
            lblCreateDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void CtrlAddEditTaskInfo_Load(object sender, EventArgs e)
        {
            _ResatDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }


        private void _LoadData()
        {
            _Task = clsTask.Find(_TaskID);

            if (_Task == null)
            {
                MessageBox.Show($"No Task with ID= {_TaskID} ", "Task Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();
                return;
            }

            dtpDueDate.MinDate = _Task.DueDate;
            dtpDueDate.Value = _Task.DueDate;

            lblTaskID.Text = _Task.TaskID.ToString();

            cbCategory.SelectedIndex = cbCategory.FindString(clsTaskCategory.Find(_Task.CategoryID).Name);
            cbPriority.SelectedIndex = cbPriority.FindString(_Task.PriorityText) ;
            txtTitle.Text = _Task.Title;
            txtEstimatedMinutes.Text = _Task.EstimatedMinutes.ToString("0");
            txtDescription.Text = _Task.Description;
            lblCreateDate.Text = _Task.CreateDate.ToString("dd/MM/yyyy");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int CategoryID = clsTaskCategory.Find(cbCategory.Text).CategoryID;

            _Task.UserID = clsGlobal.CurrentUser.UserID;
            _Task.CategoryID = CategoryID;
            _Task.Title = txtTitle.Text;
            _Task.Description = txtDescription.Text;
            _Task.Status = clsTask.enStatus.New;
            _Task.Priority = (clsTask.enPriority)cbPriority.SelectedIndex;
            _Task.DueDate = dtpDueDate.Value;
            _Task.EstimatedMinutes = int.Parse(txtEstimatedMinutes.Text);
            _Task.CreateDate = DateTime.Now;


            if (_Task.Save())
            {
                _Mode = enMode.Update;

                lblMode.Text = "Edit Task";
                lblTaskID.Text = _Task.TaskID.ToString();

                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Task.TaskID);
            }
            else
            {
                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender, e);
        }

        private void TextBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox Tepm = ((TextBox)sender);

            if (string.IsNullOrEmpty(Tepm.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(Tepm, "this field is required!");

            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Tepm, null);

            }
        }

        private void txtEstimatedMinutes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
