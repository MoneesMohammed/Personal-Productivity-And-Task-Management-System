using PPTMS.Properties;
using PPTMS_BusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PPTMS.Users.frmAddEditUserInfo;

namespace PPTMS.UserControls.CtrlTasks
{
    public partial class CtrlTaskInfo : UserControl
    {
        public event EventHandler OnBack_Click;
        public event Action<int> OnEditTaskInfo_LinkClicke;

        private clsTask _Task = new clsTask();
        private int _TaskID = -1;

        public int TaskID { get { return _TaskID; } }
        public clsTask SelectedTaskInfo { get { return _Task; } }


        public CtrlTaskInfo()
        {
            InitializeComponent();
        }


        public void LoadInfo(int TaskID)
        {
            _Task = clsTask.Find(TaskID);

            if (_Task == null)
            {
                ResetTaskInfo();
                MessageBox.Show($"No Task With TaskID ={TaskID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillTaskInfo();

        }

        private void _FillTaskInfo()
        {
            _TaskID = _Task.TaskID;

            if(_Task.Status == clsTask.enStatus.Archived || _Task.Status == clsTask.enStatus.Completed)
                llblEditTaskInfo.Enabled = false;
            else
                llblEditTaskInfo.Enabled = true;

            lblTaskID.Text = _Task.TaskID.ToString();
            lblTitle.Text = _Task.Title;
            lblDueDate.Text = _Task.DueDate.ToString("dd/MM/yyyy");
            lblEstimatedMinutes.Text = _Task.EstimatedMinutes.ToString("0");

            lblCompletedDate.Text = (_Task.IsCompleted()) ? _Task.CompletedDate.ToString("dd/MM/yyyy") : "N/A";

            lblDescription.Text = (_Task.Description != "") ? _Task.Description : "N/A";

            lblCategory.Text = clsTaskCategory.Find(_Task.CategoryID).Name;

            lblStatus.Text = _Task.StatusText;
            lblPriority.Text = _Task.PriorityText;
            lblCreateDate.Text = _Task.CreateDate.ToString("dd/MM/yyyy");


        }

        private void ResetTaskInfo()
        {
            _TaskID = -1;
            llblEditTaskInfo.Enabled = false;

            lblTaskID.Text = "[???]";
            lblTitle.Text = "[???]";
            lblDueDate.Text = "[???]";
            lblEstimatedMinutes.Text = "[???]";
            lblCompletedDate.Text = "[???]";
            lblDescription.Text = "[???]";
            lblCategory.Text = "[???]";
            lblStatus.Text = "[???]";
            lblPriority.Text = "[???]";
            lblCreateDate.Text = "[???]";

        }

        private void llblEditTaskInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnEditTaskInfo_LinkClicke?.Invoke(_TaskID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender, e);
        }
    }
}
