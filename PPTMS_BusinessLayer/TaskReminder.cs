using PPTMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
//using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_BusinessLayer
{
    public class clsTaskReminder
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int ReminderID { get; set; }
        public int TaskID { get; set; }
        public clsTask TaskInfo;
        public DateTime ReminderTime { get; set; }
        public bool IsTriggered { get; set; }

        public clsTaskReminder()
        {
            ReminderID = -1;
            TaskID = -1;
            ReminderTime = DateTime.Now;
            IsTriggered = false;

            Mode = enMode.AddNew;
        }

        private clsTaskReminder(int ReminderID, int TaskID, DateTime ReminderTime ,bool IsTriggered)
        {
            this.ReminderID = ReminderID;
            this.TaskID = TaskID;
            this.ReminderTime = ReminderTime;
            this.IsTriggered = IsTriggered;

            TaskInfo = clsTask.Find(TaskID);

            Mode = enMode.Update;
        }

        public static clsTaskReminder Find(int ReminderID)
        {
            int TaskID = -1;
            DateTime ReminderTime = DateTime.Now;
            bool IsTriggered = false;

            if (clsTaskRemindersData.GetReminderInfoByReminderID(ReminderID ,ref TaskID ,ref ReminderTime ,ref IsTriggered))
            {
                return new clsTaskReminder(ReminderID, TaskID, ReminderTime, IsTriggered);
            }
            else
                return null;

        }

        private bool _AddNewReminder()
        {
            this.ReminderID = clsTaskRemindersData.AddNewReminder(TaskID, ReminderTime , IsTriggered);
            return (ReminderID != -1);
        }

        private bool _UpdateReminder()
        {
            return clsTaskRemindersData.UpdateReminder(ReminderID, TaskID, ReminderTime );
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewReminder())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return (_UpdateReminder());

            }

            return false;
        }

        public bool Delete()
        {
            return clsTaskRemindersData.DeleteReminder(this.ReminderID);
        }

        public static DataTable GetAllReminders(int TaskID)
        {
            return clsTaskRemindersData.GetAllReminders(TaskID);
        }

        public bool MarkAsTriggered()
        { 
            return clsTaskRemindersData.MarkAsTriggered(this.ReminderID);
        }

        public static DataTable GetPendingReminders(int UserID)
        {
            return clsTaskRemindersData.GetPendingReminders(UserID);
        }

        

    }
}
