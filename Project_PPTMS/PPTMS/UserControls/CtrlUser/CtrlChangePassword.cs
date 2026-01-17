using PPTMS.Properties;
using PPTMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PPTMS.Users.frmAddEditUserInfo;

namespace PPTMS.UserControls.CtrlUser
{
    public partial class CtrlChangePassword : UserControl
    {
        public Action<int> OnEditUserInfo_LinkClicked;

        private clsUser _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }

        public CtrlChangePassword()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int UserID)
        {
            _User = clsUser.Find(UserID);

            if (_User == null)
            {
                ResetUserInfo();
                MessageBox.Show($"No User With UserID ={UserID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();

            ctrlUserDetails1.OnEditUserInfo_LinkClicked += EditUserInfo_LinkClicked;
        }

        private void EditUserInfo_LinkClicked(int obj)
        {
            OnEditUserInfo_LinkClicked?.Invoke(obj);
        }


        private void ResetUserInfo()
        {
            _UserID = -1;

        }

        private void _FillUserInfo()
        {
            _UserID = _User.UserID;

            ctrlUserDetails1.LoadUserInfo(_UserID);

        }

        private void ResetDefaultValues()
        {
            txtCurrentPassword.Text = string.Empty;
            txtNewPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
           

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            gbChangePassword.Visible = !gbChangePassword.Visible;

            if(gbChangePassword.Visible)
              txtCurrentPassword.Focus();
        }

        private void AllTextBoxes_Validating(object sender, CancelEventArgs e)
        {
            TextBox CurrentTextBox = (TextBox)sender;

            switch (CurrentTextBox.Name.ToString())
            {
                case "txtCurrentPassword":
                    {

                        if (string.IsNullOrEmpty(CurrentTextBox.Text.Trim()))
                        {

                            // e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "CurrentPassword should have a Value!");

                        }
                        else if (txtCurrentPassword.Text.Trim() != _User.Password.Trim())
                        {

                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "your current password is wrong");

                        }
                        else
                        {

                            errorProvider1.SetError(CurrentTextBox, null);

                        }



                        break;
                    }
                case "txtNewPassword":
                    {
                        if (string.IsNullOrEmpty(CurrentTextBox.Text.Trim()))
                        {

                            //e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "Password should have a Value!");

                        }
                        else
                        {

                            errorProvider1.SetError(CurrentTextBox, null);

                        }



                        break;
                    }
                case "txtConfirmPassword":
                    {
                        if (string.IsNullOrEmpty(CurrentTextBox.Text.Trim()))
                        {


                            //e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "ConfirmPassword should have a Value!");

                        }
                        else if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
                        {

                            e.Cancel = true;
                            errorProvider1.SetError(CurrentTextBox, "password confirmation does not match password!");


                        }
                        else
                        {

                            errorProvider1.SetError(CurrentTextBox, null);

                        }



                        break;
                    }

            }

        }

        private void AllTextBoxes_TextChanged(object sender, EventArgs e)
        {
            bool OneOfIsEmpty = string.IsNullOrWhiteSpace(txtCurrentPassword.Text) ||
                                string.IsNullOrWhiteSpace(txtNewPassword.Text) ||
                                string.IsNullOrWhiteSpace(txtConfirmPassword.Text);

            if (OneOfIsEmpty)
            {
                btnSave.Enabled = false;
            }
            else if (txtCurrentPassword.Text != _User.Password)
            {
                btnSave.Enabled = false;
            }
            else if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valid!, put the mouse over the red icon", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_User.ChangePassword(txtNewPassword.Text))
            {
                ResetDefaultValues();
                gbChangePassword.Visible = !gbChangePassword.Visible;
                MessageBox.Show("Password Changed successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitil_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = (Label)sender;

            // Quality improvement
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Gradient background drawing
            using (LinearGradientBrush brush = new LinearGradientBrush(
                lbl.ClientRectangle,
                Color.FromArgb(241, 44, 18),
                Color.FromArgb(245, 179, 59),
                100f))
            {
                e.Graphics.FillRectangle(brush, lbl.ClientRectangle);
            }

            //Text drawing
            TextRenderer.DrawText(
                e.Graphics,
                lbl.Text,
                lbl.Font,
                lbl.ClientRectangle,
                Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );

        }
    }
}
