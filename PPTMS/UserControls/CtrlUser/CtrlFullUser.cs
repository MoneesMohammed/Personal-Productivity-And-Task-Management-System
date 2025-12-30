using PPTMS.UserControls.CtrlTasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlUser
{
    public partial class CtrlFullUser : UserControl
    {
        public CtrlFullUser(int UserID)
        {
            InitializeComponent();
            ctrlChangePassword1.LoadUserInfo(UserID);
            ctrlChangePassword1.OnEditUserInfo_LinkClicked += ctrlChangePassword1_EditUserInfo_LinkClicked;
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.None;
            panelMain.Controls.Add(control);

            control.Left = (panelMain.ClientSize.Width - control.Width) / 2;
        }

        private void ctrlChangePassword1_EditUserInfo_LinkClicked(int obj)
        {
            CtrlAddEditUserInfo EditUserInfo = new CtrlAddEditUserInfo(obj);
            EditUserInfo.OnBack_Click += EditUserInfo_OnBack_Click;
            LoadControl(EditUserInfo);
        }

        private void EditUserInfo_OnBack_Click(object sender, EventArgs e)
        {
            int UserID = ctrlChangePassword1.UserID;
            ctrlChangePassword1.LoadUserInfo(UserID);
            LoadControl(ctrlChangePassword1);
        }
    }
}
