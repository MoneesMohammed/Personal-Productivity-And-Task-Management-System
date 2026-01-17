using PPTMS.Global_Classes;
using PPTMS.Properties;
using PPTMS_BusinessLayer;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PPTMS.Users;

namespace PPTMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {

            Button btn = (Button)sender;

            // Quality improvement
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Gradient background drawing
            using (LinearGradientBrush brush = new LinearGradientBrush(
                btn.ClientRectangle,
                Color.FromArgb(239, 146, 188),
                Color.FromArgb(45, 66, 118),
                100f))
            {
                e.Graphics.FillRectangle(brush, btn.ClientRectangle);
            }

            //Text drawing
            TextRenderer.DrawText(
                e.Graphics,
                btn.Text,
                btn.Font,
                btn.ClientRectangle,
                Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );


        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                btnShowHidePassword.Image = Resources.show;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                btnShowHidePassword.Image = Resources.close_eye;

            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();

            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                cbRememberMe.Checked = true;
            }
            else
            {
                cbRememberMe.Checked = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUser user = clsUser.FindByUserNameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());

            if (user != null)
            {
               if (cbRememberMe.Checked)
               {
                   clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassword.Text.Trim());
               }
               else
               {
                   clsGlobal.RememberUsernameAndPassword("", "");
               }

               clsGlobal.CurrentUser = user;
               this.DialogResult = DialogResult.OK;
               this.Close();

            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid The Username/Password .", "Warning Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void llblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblCreateAccount.LinkVisited = true;

            frmAddEditUserInfo frmCreateAccount = new frmAddEditUserInfo();
            frmCreateAccount.ShowDialog();

        }
    }
}
