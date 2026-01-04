using PPTMS.Global_Classes;
using PPTMS.UserControls.CtrlCategories;
using PPTMS.UserControls.CtrlHabit;
using PPTMS.UserControls.CtrlTasks;
using PPTMS.UserControls.CtrlUser;
using PPTMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.Timer;

namespace PPTMS
{
    public partial class frmMain : Form
    {
        Timer reminderTimer = new Timer();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            reminderTimer.Interval = 10 * 1000; // كل دقيقة
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
             CheckReminders();
        }

        public void CheckReminders()
        {
            DataTable dtreminders = clsTaskReminder.GetPendingReminders(clsGlobal.CurrentUser.UserID);

            if (dtreminders.Rows.Count <= 0)
                return;

            foreach (DataRow row in dtreminders.Rows)
            {
                clsTaskReminder TaskReminder = clsTaskReminder.Find(Convert.ToInt32(row["ReminderID"]));

                ShowReminder(TaskReminder);

                TaskReminder.MarkAsTriggered();
            }

        }


        private void ShowReminder(clsTaskReminder taskReminder)
        {
            // MessageBox.Show($"Reminder for Task [ {taskReminder.TaskInfo.Title} ] Task ID: {taskReminder.TaskID}","Task Reminder",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
            notifyIcon1.BalloonTipIcon  = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Task Reminder";
            notifyIcon1.BalloonTipText  = $"⏰ {taskReminder.TaskInfo.Title}";


            notifyIcon1.ShowBalloonTip(3000);
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            this.Focus();
        }





        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panelSidebar.ClientRectangle,
                Color.FromArgb(60, 120, 200),
                Color.FromArgb(120, 60, 160),
                90f))
            {
                e.Graphics.FillRectangle(brush, panelSidebar.ClientRectangle);
            }
        }

        
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "Logout")
            {
                btn.BackColor = Color.FromArgb(40, Color.Red);
            }
            else
            btn.BackColor = Color.FromArgb(40, Color.RoyalBlue);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }


       
        private void btnProfile_Click(object sender, EventArgs e)
        {
            CtrlFullUser ctrlUserDetails = new CtrlFullUser(clsGlobal.CurrentUser.UserID);
            
            LoadCenteredControl(ctrlUserDetails);
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCenteredControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.None;
            panelContent.Controls.Add(control);

            control.Left = (panelContent.ClientSize.Width - control.Width)  / 2;
            //control.Top = (panelContent.ClientSize.Height - control.Height) / 3;
        }

        private void LoadFillControl(UserControl control)
        {
            panelContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContent.Controls.Add(control);
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CtrlFullCategories categories = new CtrlFullCategories();

            LoadCenteredControl(categories);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            CtrlFullTasks ctrlTasks = new CtrlFullTasks();
            LoadCenteredControl(ctrlTasks);
        }

        int CoutOpenHabits = 0;

        private void btnHabits_Click(object sender, EventArgs e)
        {
            CoutOpenHabits++;
            CtrlHabits ctrlHabits = new CtrlHabits();
            LoadCenteredControl(ctrlHabits);
        }
    }
}
