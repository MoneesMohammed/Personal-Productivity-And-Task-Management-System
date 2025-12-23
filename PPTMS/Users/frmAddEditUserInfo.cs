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

namespace PPTMS.Users
{
    public partial class frmAddEditUserInfo : Form
    {
        //Delegate
        public delegate void DataFoundEventHandler(object sender, int UserID);

        public event DataFoundEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 }
        public enum enGender { Male = 0, Female = 1 }

        private enMode _Mode;
        private int _UserID = -1;
        private clsUser _User;


        public frmAddEditUserInfo()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public frmAddEditUserInfo(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;
            _Mode = enMode.Update;
        }

        private void _ResatDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Create Account";
                this.Text = "Create Account";
                _User = new clsUser();
            }
            else
            {
                lblMode.Text = "Edit Account";
                this.Text = "Edit Account";
                btnSave.Enabled = true;
            }

            txtFullName.Text = "";
            rbMale.Checked = true;
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
           
            if (rbMale.Checked)
                pbUserImage.Image = Resources.working;
            else
                pbUserImage.Image = Resources.attendees;


            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

        }

        private void frmAddEditUserInfo_Load(object sender, EventArgs e)
        {
            _ResatDefualtValues();

            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show($"No User with ID= {_UserID} ", "User Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblUserID.Text = _User.UserID.ToString();

            txtUserName.Text = _User.UserName;
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
           

            txtFullName.Text = _User.FullName;
            txtEmail.Text = _User.Email;
            dtpDateOfBirth.Value = _User.DateOfBirth;

            if (_User.Gender == (byte)enGender.Male)
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _User.FullName = txtFullName.Text;
            _User.Email = txtEmail.Text;
            _User.DateOfBirth = dtpDateOfBirth.Value;
            _User.UserName = txtUserName.Text;
            _User.Password = txtPassword.Text;

            _User.Gender = (byte)(rbMale.Checked ? 0 : 1);

            if (_User.Save())
            {

                _Mode = enMode.Update;
                this.Text = "Update User";
                lblMode.Text = "Update User";
                lblUserID.Text = _User.UserID.ToString();

                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _User.UserID);
            }
            else
            {

                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbUserImage.Image = rbMale.Checked ? Resources.working : Resources.attendees;
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
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

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(txtEmail, "this field is required!");

            }    //Validate Email Format
            else if(!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void TextBoxes_Validating(object sender, CancelEventArgs e)
        {
            TextBox CurrentTextBox = (TextBox)sender;


            switch (CurrentTextBox.Name.ToString())
            {
                case "txtUserName":
                    {

                        if (string.IsNullOrEmpty(CurrentTextBox.Text))
                        {
                            //CurrentTextBox.Focus();
                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "UserName should have a Value!");

                        }
                        else if (clsUser.IsUserExists(CurrentTextBox.Text) && txtUserName.Text != _User.UserName.ToString())
                        {
                            //CurrentTextBox.Focus();
                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "Username is already in use, please use another username");

                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(CurrentTextBox, "");

                        }



                        break;
                    }
                case "txtPassword":
                    {
                        if (string.IsNullOrEmpty(CurrentTextBox.Text))
                        {
                            //CurrentTextBox.Focus();
                            e.Cancel = true;

                            errorProvider1.SetError(CurrentTextBox, "Password should have a Value!");

                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(CurrentTextBox, "");

                        }



                        break;
                    }
                case "txtConfirmPassword":
                    {
                        if (string.IsNullOrEmpty(CurrentTextBox.Text))
                        {

                            CurrentTextBox.Focus();
                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "ConfirmPassword should have a Value!");

                        }
                        else if (txtConfirmPassword.Text != txtPassword.Text)
                        {
                            CurrentTextBox.Focus();
                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "password confirmation does not match password!");


                        }
                        else
                        {
                            e.Cancel = false;
                            errorProvider1.SetError(CurrentTextBox, "");

                        }



                        break;
                    }

            }
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*' && txtConfirmPassword.PasswordChar == '*')
            {
                btnShowHidePassword.Image = Resources.show;
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
                btnShowHidePassword.Image = Resources.close_eye;

            }
        }
    }
}
