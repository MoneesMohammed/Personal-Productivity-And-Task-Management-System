using PPTMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static PPTMS_BusinessLayer.clsHabit;

namespace PPTMS_BusinessLayer
{
    public class clsHabitLog
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public int LogID { get; set; }
        public int HabitID { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime LogDate { get; set; }

        public clsHabitLog()
        {
            LogID = -1;
            HabitID = -1;
            IsCompleted = false;
            LogDate = DateTime.Now.Date;

            Mode = enMode.AddNew;
        }

        private clsHabitLog(int LogID , int HabitID , bool IsCompleted , DateTime LogDate)
        { 
            this.LogID = LogID;
            this.HabitID = HabitID;
            this.IsCompleted = IsCompleted;
            this.LogDate = LogDate;

            Mode = enMode.Update;
        }

        public static clsHabitLog Find(int LogID)
        {
            int HabitID = -1;
            bool IsCompleted = true;
            DateTime LogDate = DateTime.Now.Date;

            if (clsHabitLogsData.GetHabitLogInfoByLogID(LogID , ref HabitID , ref IsCompleted , ref LogDate))
            {
                return new clsHabitLog(LogID,HabitID,IsCompleted,LogDate);
            }
            else
                return null;

        }

        public bool CheckIn()
        {
            if (HabitID == -1)
            { 
                return false;
            }

            this.LogID = clsHabitLogsData.CheckIn(this.HabitID);
            return (LogID != -1);
        }

        public bool UndoCheckIn()
        {
            if (HabitID == -1)
            {
                return false;
            }

            return clsHabitLogsData.UndoCheckIn(this.HabitID);
        }


        public static DataTable GetAllHabitLogs()
        {
            return clsHabitLogsData.GetAllHabitLogs();
        }



    }
}
