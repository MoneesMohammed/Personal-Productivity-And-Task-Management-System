using PPTMS_DataAccessLayar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_BusinessLayer
{
    public class clsStatistic
    {
        public int UserID { get; set; }

        // ===== Tasks Counts =====
        public int TotalTasks     { get; set; }
        public int ArchivedTasks  { get; set; }
        public int CompletedTasks  { get; set; }
        public int InProgress      { get; set; }
        public int OnHold          { get; set; }

        // ===== Tasks Rates =====
        public float CompletionRate { get; set; }

        // ===== Priority Statistics =====
        public int Low      { get; set; }
        public int Medium   { get; set; }
        public int High     { get; set; }
        public int Critical { get; set; }

        // ===== Time-based Task Statistics =====
        public int Today     { get; set; }
        public int ThisWeek  { get; set; }
        public int ThisMonth { get; set; }

        // ===== Time Estimation Statistics =====
        public int   TotalEstimatedTime         { get; set; }
        public int   TimeSpentOnCompletedTasks { get; set; }
        public float AverageTaskDuration       { get; set; }

        // ===== Habits Statistics =====
        public int TotalHabits    { get; set; }
        public int ActiveHabits   { get; set; }
        public int ArchivedHabits { get; set; }

        // ===== Insight =====
        public string CompleteMoreTasksIn { get; set; }
        public int    HabitID             { get; set; }
        public string BestHabit           { get; set; }
       


        public clsStatistic()
        {
            UserID     = -1;

            TotalTasks     =0;
            ArchivedTasks  =0;
            CompletedTasks =0;
            InProgress     =0;
            OnHold         =0;

            CompletionRate = 0;

            Low     =0;
            Medium  =0;
            High    =0;
            Critical=0;

            Today    =0;
            ThisWeek =0;
            ThisMonth=0;

            TotalEstimatedTime       =0;
            TimeSpentOnCompletedTasks=0;
            AverageTaskDuration      =0;

            TotalHabits   =0;
            ActiveHabits  =0;
            ArchivedHabits=0;

            CompleteMoreTasksIn = "";
            HabitID = -1;
            BestHabit = "";

        }


        public clsStatistic(int UserID,int TotalTasks,int ArchivedTasks,int CompletedTasks,int InProgress,int OnHold,float CompletionRate,
           int Low,int Medium,int High,int Critical,int Today,int ThisWeek,int ThisMonth,int TotalEstimatedTime, int TimeSpentOnCompletedTasks,
           float AverageTaskDuration,int TotalHabits,int ActiveHabits,int ArchivedHabits , string CompleteMoreTasksIn , int HabitID , string BestHabit)
           
        {
            this.UserID = UserID;
           
            this.TotalTasks = TotalTasks;
            this.ArchivedTasks   = ArchivedTasks;
            this.CompletedTasks  = CompletedTasks;
            this.InProgress      = InProgress    ;
            this.OnHold          = OnHold        ;

            this.CompletionRate = CompletionRate ;
            
            this.Low      = Low     ;
            this.Medium   = Medium  ;
            this.High     = High    ;
            this.Critical = Critical;
            
            this.Today     = Today    ;
            this.ThisWeek  = ThisWeek ;
            this.ThisMonth = ThisMonth;
           
            this.TotalEstimatedTime        = TotalEstimatedTime       ;
            this.TimeSpentOnCompletedTasks = TimeSpentOnCompletedTasks;
            this.AverageTaskDuration       = AverageTaskDuration;

            this.TotalHabits    = TotalHabits   ;
            this.ActiveHabits   = ActiveHabits  ;
            this.ArchivedHabits = ArchivedHabits;

            this.CompleteMoreTasksIn = CompleteMoreTasksIn ;
            this.HabitID = HabitID ;
            this.BestHabit = BestHabit ;

        }

        public static clsStatistic Find(int UserID)
        {
            int TotalTasks = 0 , ArchivedTasks = 0, CompletedTasks = 0 , InProgress = 0, OnHold = 0, Low = 0, Medium = 0,High = 0,
            Critical = 0,Today = 0,ThisWeek = 0,ThisMonth = 0,TotalEstimatedTime = 0,TimeSpentOnCompletedTasks = 0,
            TotalHabits = 0,ActiveHabits = 0,ArchivedHabits = 0 , HabitID = -1;

            float CompletionRate = 0 , AverageTaskDuration = 0;

            string CompleteMoreTasksIn = "", BestHabit = "";

            clsStatisticsData.GetInsightInfoByUserID(UserID ,ref CompleteMoreTasksIn ,ref HabitID ,ref BestHabit);

            if (clsStatisticsData.GetStatisticInfoByUserID(UserID,ref TotalTasks, ref ArchivedTasks, ref CompletedTasks,
            ref InProgress, ref OnHold, ref CompletionRate, ref Low, ref Medium, ref High, ref Critical,
            ref Today, ref ThisWeek, ref ThisMonth, ref TotalEstimatedTime, ref TimeSpentOnCompletedTasks, ref  AverageTaskDuration,
            ref TotalHabits, ref ActiveHabits, ref ArchivedHabits))
            {
                return new clsStatistic(UserID,TotalTasks,ArchivedTasks,CompletedTasks,
                                         InProgress,OnHold,CompletionRate,Low,Medium,High,Critical,
                                         Today,ThisWeek,ThisMonth,TotalEstimatedTime,TimeSpentOnCompletedTasks,AverageTaskDuration,
                                         TotalHabits,ActiveHabits,ArchivedHabits, CompleteMoreTasksIn , HabitID , BestHabit);
            }
            else
                return null;

        }



    }
}
