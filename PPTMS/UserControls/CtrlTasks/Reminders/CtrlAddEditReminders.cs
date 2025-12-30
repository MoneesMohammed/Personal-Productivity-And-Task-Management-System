using PPTMS.Global_Classes;
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
using static PPTMS_BusinessLayer.clsTask;

namespace PPTMS.UserControls.CtrlTasks
{
    public partial class CtrlAddEditReminders : UserControl
    {
        public event EventHandler OnBack_Click;

        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;
        private int _ReminderID = -1;
        private int _TaskID = -1;
        private clsTaskReminder _TaskReminder;


        public CtrlAddEditReminders(int TaskID)
        {
            InitializeComponent();
            _TaskID = TaskID;

            _Mode = enMode.AddNew;
        }

        public CtrlAddEditReminders(int taskID , int ReminderID)
        {
            InitializeComponent();
            _TaskID = taskID;
            _ReminderID = ReminderID;

            _Mode = enMode.Update;
        }

        private void _ResatDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add Reminder";
                _TaskReminder = new clsTaskReminder();
                picIcon.Image = Resources.sticky_notes__1_;

            }
            else
            {
                lblMode.Text = "Edit Reminder";
                picIcon.Image = Resources.sticky_notes__2_;

                btnSave.Enabled = true;
            }


            lblTaskID.Text = _TaskID.ToString();
            dtpReminderTime.MinDate = DateTime.Now;
            dtpReminderTime.Value = DateTime.Now;

        }

        private void CtrlAddEditReminders_Load(object sender, EventArgs e)
        {
            _ResatDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _TaskReminder = clsTaskReminder.Find(_ReminderID);

            if (_TaskReminder == null)
            {
                MessageBox.Show($"No Task Reminder with ID= {_ReminderID} ", "Task Reminder Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();
                return;
            }

            dtpReminderTime.MinDate = _TaskReminder.ReminderTime;

            lblReminderID.Text = _ReminderID.ToString();
            
            dtpReminderTime.Value = _TaskReminder.ReminderTime;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender,e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _TaskReminder.ReminderTime = dtpReminderTime.Value;
            _TaskReminder.TaskID = _TaskID;
            _TaskReminder.IsTriggered = false;


            if (_TaskReminder.Save())
            {
                _Mode = enMode.Update;

                lblMode.Text = "Edit Reminder";
                lblReminderID.Text = _TaskReminder.ReminderID.ToString();
               

                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                //DataBack?.Invoke(this, _Task.TaskID);
            }
            else
            {
                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
