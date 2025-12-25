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
using static PPTMS.Users.frmAddEditUserInfo;

namespace PPTMS.UserControls.CtrlCategories
{
    public partial class CtrlAddEditCategoryInfo : UserControl
    {
        public event EventHandler OnBack_Click;

        //Delegate
        public delegate void DataFoundEventHandler(object sender, int CategoryID);

        public event DataFoundEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 }
       
        private enMode _Mode;
        private int _CategoryID = -1;
        private clsTaskCategory _TaskCategory;



        public CtrlAddEditCategoryInfo()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public CtrlAddEditCategoryInfo(int CategoryID)
        {
            InitializeComponent();
            _CategoryID = CategoryID;
            _Mode = enMode.Update;
        }


        private void _ResatDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Category";
                _TaskCategory = new clsTaskCategory();
                picIcon.Image = Resources.category__2_;
                lblMode.ForeColor = Color.FromArgb(201, 62, 186);
            }
            else
            {
                lblMode.Text = "Edit Category";
                picIcon.Image = Resources.dashboard__1_;
                lblMode.ForeColor = Color.FromArgb(172, 0, 255);
                btnSave.Enabled = true;
            }

            txtCategoryName.Text = "";
           
        }

        private void CtrlAddEditCategoryInfo_Load(object sender, EventArgs e)
        {
            _ResatDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }


        private void _LoadData()
        {
            _TaskCategory = clsTaskCategory.Find(_CategoryID);

            if (_TaskCategory == null)
            {
                MessageBox.Show($"No Task Category with ID= {_CategoryID} ", "Task Category Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
               // this.Close();
                return;
            }

            lblCategoryID.Text = _TaskCategory.CategoryID.ToString();
            txtCategoryName.Text = _TaskCategory.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TaskCategory.Name = txtCategoryName.Text;
            _TaskCategory.UserID = clsGlobal.CurrentUser.UserID;

            if (_TaskCategory.Save())
            {
                _Mode = enMode.Update;
                
                lblMode.Text = "Edit Category";
                lblCategoryID.Text = _TaskCategory.CategoryID.ToString();

                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _TaskCategory.CategoryID);
            }
            else
            {
                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender,e);
        }

        private void txtCategoryName_Validating(object sender, CancelEventArgs e)
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
    }
}
