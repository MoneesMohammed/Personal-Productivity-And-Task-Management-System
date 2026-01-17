using PPTMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PPTMS_BusinessLayer.clsTask;

namespace PPTMS_BusinessLayer
{
    public class clsTaskLog
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public enum enAction { Created = 0, StatusChanged = 1, Archived = 2, Completed = 3, Edited = 4, DueDateChanged = 5, PriorityChanged = 6 };

        public int LogID           { get; set; }
        public int TaskID          { get; set; }
        public clsTask TaskInfo;
        public enAction Action     { get; set; }
        public string OldValue     { get; set; }
        public string NewValue     { get; set; }
        public DateTime ActionDate { get; set; }
        
        public string ActionText
        {
            get
            {
                switch (Action)
                {
                    case enAction.Created:
                        return "Created";
                    case enAction.StatusChanged:
                        return "Status Changed";
                    case enAction.Completed:
                        return "Completed";
                    case enAction.Archived:
                        return "Archived";
                    case enAction.Edited:
                        return "Edited";
                    case enAction.DueDateChanged:
                        return "Due Date Changed";
                    case enAction.PriorityChanged:
                        return "Priority Changed";
                    default:
                        return "Unknown";

                }

            }

        }

        public clsTaskLog()
        {
            LogID = -1;
            TaskID = -1;
            Action = enAction.Created;
            OldValue = "";
            NewValue = "";
            ActionDate = DateTime.Now;
            

            Mode = enMode.AddNew;
        }

        private clsTaskLog(int LogID, int TaskID, enAction Action, string OldValue, string NewValue, DateTime ActionDate)
        {
            this.LogID = LogID;
            this.TaskID = TaskID;
            this.Action = Action;
            this.OldValue = OldValue;
            this.NewValue = NewValue;
            this.ActionDate = ActionDate;
            

            TaskInfo = clsTask.Find(TaskID);

            Mode = enMode.Update;
        }

        public static clsTaskLog Find(int LogID)
        {
            int TaskID = -1 ;
            byte Action = 0 ;
            string OldValue ="", NewValue ="";
            DateTime ActionDate = DateTime.Now;
            

            if (clsTaskLogsData.GetLogInfoByLogID(LogID, ref TaskID,ref Action,ref OldValue,ref NewValue, ref ActionDate))
            {
                return new clsTaskLog(LogID, TaskID, (enAction)Action, OldValue, NewValue, ActionDate);
            }
            else
                return null;

        }

        private bool _AddNewLog()
        {
            this.LogID = clsTaskLogsData.AddNewLog(TaskID, (byte)Action, OldValue, NewValue, ActionDate);
            return (LogID != -1);
        }

        private bool _UpdateLog()
        {
            return clsTaskLogsData.UpdateLog(LogID, TaskID, (byte)Action, OldValue, NewValue, ActionDate);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewLog())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return (_UpdateLog());

            }

            return false;
        }

        public bool Delete()
        {
            return clsTaskLogsData.DeleteLog(this.LogID);
        }

        public static DataTable GetAllLogs(int TaskID)
        {
            return clsTaskLogsData.GetAllLogs(TaskID);
        }
    }
}
