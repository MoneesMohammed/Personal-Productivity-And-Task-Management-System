using PPTMS_DataAccessLayar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_BusinessLayer
{
    public class clsTask
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public enum enStatus { Pending = 0, InProgress = 1, Completed = 2, Archived = 3 };
        public enum enPriority { Low = 0, Medium = 1, High = 2, Critical = 3 };


        public int      TaskID           { get; set; }
        public int      UserID           { get; set; }
        public int      CategoryID       { get; set; }
        public string   Title            { get; set; }
        public string   Description      { get; set; }
        public enStatus Status           { get; set; }
        public enPriority Priority       { get; set; }
        public DateTime DueDate          { get; set; }
        public int      EstimatedMinutes { get; set; }
        public DateTime CompletedDate    { get; set; }
        public DateTime CreateDate       { get; set; }


        public string StatusText
        {
            get
            {
                switch (Status)
                {
                    case enStatus.Pending:
                        return "Pending";
                    case enStatus.InProgress:
                        return "In Progress";
                    case enStatus.Completed:
                        return "Completed";
                    case enStatus.Archived:
                        return "Archived";
                    default:
                        return "Unknown";

                }

            }

        }

        public string PriorityText
        {
            get
            {
                switch (Priority)
                {
                    case enPriority.Low:
                        return "Low";
                    case enPriority.Medium:
                        return "Medium";
                    case enPriority.High:
                        return "High";
                    case enPriority.Critical:
                        return "Critical";
                    default:
                        return "Unknown";

                }

            }

        }


        public clsTask()
        {
            TaskID = -1;
            UserID = -1;
            CategoryID = -1;
            Title = "";
            Description = "";
            Status = enStatus.InProgress;
            Priority = enPriority.Low;
            DueDate = DateTime.Now;
            EstimatedMinutes = 0;
            CompletedDate = DateTime.Now;
            CreateDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsTask(int TaskID, int UserID, int CategoryID, string Title, string Description,enStatus Status,enPriority Priority,
                        DateTime DueDate, int EstimatedMinutes, DateTime CompletedDate, DateTime CreateDate)
        {
            this.TaskID              = TaskID;
            this.UserID              = UserID            ;
            this.CategoryID          = CategoryID        ;
            this.Title               = Title             ;
            this.Description         = Description       ;
            this.Status              = Status            ;
            this.Priority            = Priority          ;
            this.DueDate             = DueDate           ;
            this.EstimatedMinutes    = EstimatedMinutes  ;
            this.CompletedDate       = CompletedDate     ;
            this.CreateDate          = CreateDate        ;

            Mode = enMode.Update;
        }

        public static clsTask Find(int TaskID)
        {
            int UserID = -1 , CategoryID =-1 , EstimatedMinutes = 0;
            string Title = "", Description = "";
            byte Status = 0 , Priority = 0; 
            DateTime CreateDate = DateTime.Now , DueDate = DateTime.Now , CompletedDate = DateTime.Now;

            if (clsTasksData.GetTaskInfoByTaskID(TaskID , ref UserID , ref CategoryID, ref Title, ref Description, ref Status, ref Priority, ref DueDate, ref EstimatedMinutes, ref CompletedDate, ref CreateDate))
            {
                return new clsTask(TaskID, UserID, CategoryID, Title, Description, (enStatus)Status, (enPriority)Priority, DueDate, EstimatedMinutes, CompletedDate, CreateDate);
            }
            else
                return null;

        }

       
        private bool _AddNewTask()
        {
            this.TaskID = clsTasksData.AddNewTask(UserID, CategoryID, Title, Description, (byte)Status, (byte)Priority, DueDate, EstimatedMinutes, CreateDate);
            return (TaskID != -1);
        }

        private bool _UpdateTask()
        {
            return clsTasksData.UpdateTask(this.TaskID, CategoryID, Title, Description, (byte)Status, (byte)Priority, DueDate, EstimatedMinutes);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewTask())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case enMode.Update:

                    return (_UpdateTask());

            }

            return false;
        }

        public bool MarkAsArchive()
        {
            return clsTasksData.MarkAsArchive(this.TaskID);
        }

        public static DataTable GetAllTasks(int UserID)
        {
            return clsTasksData.GetAllTasks(UserID);
        }

        public static bool SetStatus(int TaskID , byte Status)
        {
            return clsTasksData.SetStatus(TaskID, Status);
        }

        public bool SetStatus(byte Status)
        {
            return clsTasksData.SetStatus(this.TaskID, Status);
        }

        public static bool MarkAsCompleted(int TaskID)
        {
            return clsTasksData.MarkAsCompleted(TaskID);
        }

        public bool MarkAsCompleted()
        {
            return clsTasksData.MarkAsCompleted(this.TaskID);
        }


        public bool IsCompleted()
        {
            return this.Status == enStatus.Completed;
        }


    }
}
