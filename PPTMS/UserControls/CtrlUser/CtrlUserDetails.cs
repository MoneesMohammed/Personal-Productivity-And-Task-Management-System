using PPTMS.Properties;
using PPTMS.Users;
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

namespace PPTMS.UserControls.CtrlUser
{
    public partial class CtrlUserDetails : UserControl
    {

        private clsUser _User;
        private int _UserID = -1;

        public int UserID
        {
            get { return _UserID; }
        }


        public CtrlUserDetails()
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

        }

        private void ResetUserInfo()
        {
            _UserID = -1;

            lblUserID.Text = "[???]";
            lblUserName.Text = "[???]";

            lblName.Text = "[???]";
            lblEmail.Text = "[???]";
            lblDateOfBirth.Text = "[??/??/????]";

            lblGendor.Text = "Male";
            lblGendor.Image = Resources.Male;

            pbUserImage.Image = Resources.working;
        }

        private void _FillUserInfo()
        {
            _UserID = _User.UserID;

            llblEditUserInfo.Enabled = true;

            lblUserID.Text = _User.UserID.ToString();
            lblUserName.Text = _User.UserName;

            lblName.Text = _User.FullName;
            lblEmail.Text = _User.Email;
            lblDateOfBirth.Text = _User.DateOfBirth.ToString("MM/dd/yyyy");

            if (_User.Gender == (byte)enGender.Male)
            {
                lblGendor.Text = "Male";
                lblGendor.Image = Resources.Male;
            }
            else
            {
                lblGendor.Text = "Female";
                lblGendor.Image = Resources.Female;
            }

        }

        private void llblEditUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditUserInfo frm = new frmAddEditUserInfo(_UserID);
            frm.ShowDialog();

            LoadUserInfo(_UserID);
        }
    }
}
