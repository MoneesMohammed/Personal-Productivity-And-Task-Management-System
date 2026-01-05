using PPTMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_BusinessLayer
{
    public class clsHabit
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;

        public enum enFrequency { Daily = 0, Weekly = 1, Monthly = 2 };

        public int HabitID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public enFrequency Frequency { get; set; }
        public bool IsActive   { get; set; }
        public bool IsArchived { get; set; }
        public DateTime CreateDate { get; set; }

        public string FrequencyText
        {
            get
            {
                switch (Frequency)
                {
                    case enFrequency.Daily:
                        return "Daily";
                    case enFrequency.Weekly:
                        return "Weekly";
                    case enFrequency.Monthly:
                        return "Monthly";
                    default:
                        return "Unknown";

                }

            }

        }

        public clsHabit()
        {
            HabitID = -1;
            UserID = -1;
            Name = "";
            Frequency = 0;
            IsActive   = true;
            IsArchived = false;
            CreateDate = DateTime.Now;


            Mode = enMode.AddNew;
        }

        private clsHabit(int HabitID, int UserID, string Name, enFrequency Frequency, bool IsActive, bool IsArchived, DateTime CreateDate)
        {
            this.HabitID    = HabitID;
            this.UserID     = UserID;
            this.Name       = Name;
            this.Frequency  = Frequency;
            this.IsActive   = IsActive;
            this.IsArchived = IsArchived;
            this.CreateDate = CreateDate;

            Mode = enMode.Update;
        }

        public static clsHabit Find(int HabitID)
        {
            int UserID = -1;
            byte Frequency = 0;
            string Name = "";
            bool IsActive = true , IsArchived = false;
            DateTime CreateDate = DateTime.Now;


            if (clsHabitsData.GetHabitInfoByHabitID(HabitID, ref UserID, ref Name, ref Frequency , ref IsActive , ref IsArchived, ref CreateDate))
            {
                return new clsHabit(HabitID,UserID,Name,(enFrequency)Frequency,IsActive,IsArchived,CreateDate);
            }
            else
                return null;

        }

        private bool _AddNewHabit()
        {
            this.HabitID = clsHabitsData.AddNewHabit(UserID, Name , (byte)Frequency, CreateDate);
            return (HabitID != -1);
        }

        private bool _UpdateHabit()
        {
            return clsHabitsData.UpdateHabit(HabitID, Name, (byte)Frequency );
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:

                    if (_AddNewHabit())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return (_UpdateHabit());

            }

            return false;
        }

        public static DataTable GetAllHabits(int UserID)
        {
            return clsHabitsData.GetAllHabits(UserID);
        }

        public bool MarkAsArchived()
        { 
          return clsHabitsData.MarkAsArchived(this.HabitID);
        }

        public bool MarkAsActivate()
        {
            return clsHabitsData.MarkAsActivate(this.HabitID);
        }

        public bool MarkAsDeactivate()
        {
            return clsHabitsData.MarkAsDeactivate(this.HabitID);
        }

        public bool IsCheckIn()
        {
            return clsHabitsData.IsCheckIn(this.HabitID);
        }

    }
}
