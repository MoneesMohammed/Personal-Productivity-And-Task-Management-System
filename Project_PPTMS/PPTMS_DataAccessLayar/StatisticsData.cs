using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_DataAccessLayar
{
    public class clsStatisticsData
    {
        public static bool GetStatisticInfoByUserID(int UserID, ref int TotalTasks, ref int ArchivedTasks, ref int CompletedTasks ,
            ref int InProgress ,ref int OnHold , ref float CompletionRate , ref int Low ,ref int Medium , ref int High ,ref int Critical ,
            ref int Today , ref int ThisWeek ,ref int ThisMonth ,ref int TotalEstimatedTime, ref int TimeSpentOnCompletedTasks , ref float AverageTaskDuration ,
            ref int TotalHabits , ref int ActiveHabits, ref int ArchivedHabits)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query1 = @"DECLARE @Today DATE = CAST(GETDATE() AS DATE);

                             SELECT (COUNT(*)) AS TotalTasks ,
                             (SUM(CASE WHEN Status = 3 THEN 1 ELSE 0 END) ) AS ArchivedTasks ,
                             (SUM(CASE WHEN Status = 2 THEN 1 ELSE 0 END) ) AS CompletedTasks ,
                             (SUM(CASE WHEN Status = 1 THEN 1 ELSE 0 END) ) AS InProgress ,
                             (SUM(CASE WHEN Status = 4 THEN 1 ELSE 0 END) ) AS OnHold ,
                             
                             CAST(SUM(CASE WHEN Status = 2 THEN 1 ELSE 0 END) * 100.0
                                  / NULLIF(SUM(CASE WHEN Status <> 3 THEN 1 ELSE 0 END), 0) AS real) AS CompletionRate ,
                             
                             (SUM(CASE WHEN Priority = 0 THEN 1 ELSE 0 END) ) AS Low ,
                             (SUM(CASE WHEN Priority = 1 THEN 1 ELSE 0 END) ) AS Medium ,
                             (SUM(CASE WHEN Priority = 2 THEN 1 ELSE 0 END) ) AS High ,
                             (SUM(CASE WHEN Priority = 3 THEN 1 ELSE 0 END) ) AS Critical ,
                             
                             SUM(CASE 
                                     WHEN CompletedDate >= @Today 
                                      AND CompletedDate < DATEADD(DAY, 1, @Today)
                                     THEN 1 ELSE 0 END) AS Today,
                             
                                 SUM(CASE 
                                     WHEN CompletedDate >= DATEADD(DAY, -6, @Today)
                                      AND CompletedDate < DATEADD(DAY, 1, @Today)
                                     THEN 1 ELSE 0 END) AS ThisWeek,
                             
                                 SUM(CASE 
                                     WHEN CompletedDate >= DATEADD(DAY, -29, @Today)
                                      AND CompletedDate < DATEADD(DAY, 1, @Today)
                                     THEN 1 ELSE 0 END) AS ThisMonth ,
                             
                             SUM(EstimatedMinutes) as TotalEstimatedTime ,
                             SUM(CASE WHEN Status = 2 THEN EstimatedMinutes ELSE 0 END) as TimeSpentOnCompletedTasks ,
                             
                             CAST(
                                  SUM(CASE WHEN Status = 2 THEN EstimatedMinutes ELSE 0 END) * 1.0
                                     /
                                     NULLIF(SUM(CASE WHEN Status = 2 THEN 1 ELSE 0 END), 0)
                                 AS real ) AS AverageTaskDuration
                             
                             FROM Tasks 
                             WHERE UserID = @UserID ";


            string query2 = @"SELECT COUNT(*) AS TotalHabits ,
                              (SUM(CASE WHEN IsActive = 1 AND IsArchived = 0 THEN 1 ELSE 0 END) ) AS ActiveHabits ,
                              (SUM(CASE WHEN IsArchived = 1 THEN 1 ELSE 0 END) ) AS ArchivedHabits
                              FROM Habits
                              WHERE UserID = @UserID ";

            SqlCommand command1 = new SqlCommand(query1, connection);
            command1.Parameters.AddWithValue("@UserID", UserID);

            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader1 = command1.ExecuteReader();
                
                if (reader1.Read())
                {
                    isFound = true;

                    TotalTasks     = reader1["TotalTasks"] == DBNull.Value ? 0 : (int)reader1["TotalTasks"];
                    ArchivedTasks  = reader1["ArchivedTasks"] == DBNull.Value ? 0 : (int)reader1["ArchivedTasks"];
                    CompletedTasks = reader1["CompletedTasks"] == DBNull.Value ? 0 : (int)reader1["CompletedTasks"];
                    InProgress     = reader1["InProgress"] == DBNull.Value ? 0 : (int)reader1["InProgress"];
                    OnHold         = reader1["OnHold"] == DBNull.Value ? 0 : (int)reader1["OnHold"];

                    CompletionRate = reader1["CompletionRate"] == DBNull.Value ? 0 : Convert.ToSingle(reader1["CompletionRate"]);

                    Low            = reader1["Low"] == DBNull.Value ? 0 : (int)reader1["Low"];
                    Medium         = reader1["Medium"] == DBNull.Value ? 0 : (int)reader1["Medium"];
                    High           = reader1["High"] == DBNull.Value ? 0 : (int)reader1["High"];
                    Critical       = reader1["Critical"] == DBNull.Value ? 0 : (int)reader1["Critical"];

                    Today          = reader1["Today"] == DBNull.Value ? 0 : (int)reader1["Today"];
                    ThisWeek       = reader1["ThisWeek"] == DBNull.Value ? 0 : (int)reader1["ThisWeek"];
                    ThisMonth      = reader1["ThisMonth"] == DBNull.Value ? 0 : (int)reader1["ThisMonth"];

                    TotalEstimatedTime = reader1["TotalEstimatedTime"] == DBNull.Value ? 0 : (int)reader1["TotalEstimatedTime"];

                    TimeSpentOnCompletedTasks = reader1["TimeSpentOnCompletedTasks"] == DBNull.Value ? 0 : (int)reader1["TimeSpentOnCompletedTasks"];
                               
                    AverageTaskDuration = reader1["AverageTaskDuration"] == DBNull.Value ? 0 : Convert.ToSingle(reader1["AverageTaskDuration"]);
                       
                }
                
                reader1.Close();

                // ===== Query 2 : Habits Statistics =====
                using (SqlDataReader reader2 = command2.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        TotalHabits = reader2["TotalHabits"] == DBNull.Value ? 0 : (int)reader2["TotalHabits"];
                        ActiveHabits = reader2["ActiveHabits"] == DBNull.Value ? 0 : (int)reader2["ActiveHabits"];
                        ArchivedHabits = reader2["ArchivedHabits"] == DBNull.Value ? 0 : (int)reader2["ArchivedHabits"];
                    }
                }

            }
            catch//(Exception e)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetInsightInfoByUserID(int UserID ,ref string CompleteMoreTasksIn ,ref int HabitID, ref string BestHabit)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query1 = @"SELECT TOP 1 CompleteMoreTasksIn, COUNT(*) AS Total 
                             FROM
                             (
                                 SELECT
                                     CASE 
                                         WHEN CAST(CompletedDate AS time) >= '05:00:00'
                                          AND CAST(CompletedDate AS time) <  '12:00:00'
                                             THEN 'Morning'
                             
                                         WHEN CAST(CompletedDate AS time) >= '12:00:00'
                                          AND CAST(CompletedDate AS time) <  '18:00:00'
                                             THEN 'Afternoon'
                             
                                         WHEN CAST(CompletedDate AS time) >= '18:00:00'
                                          AND CAST(CompletedDate AS time) <= '23:59:59'
                                             THEN 'Evening'
                             
                                         ELSE 'Night'
                                     END AS CompleteMoreTasksIn
                             
                                 FROM Tasks
                                 WHERE UserID = @UserID
                                   AND CompletedDate IS NOT NULL
                             ) X
                             GROUP BY CompleteMoreTasksIn
                             ORDER BY Total DESC;";

            string query2 = @"SELECT HabitID , Name AS BestHabit
                              FROM Habits
                              WHERE UserID = @UserID AND 
                              Habits.HabitID = 
                              (
                                   SELECT TOP 1 HabitID
                                   FROM
                                   (
                                   SELECT HabitID, COUNT(*) AS Total
                                   FROM HabitLogs
                                   GROUP BY HabitID
                                   
                                   ) X
                                   ORDER BY Total DESC
                              )
                              ";

            SqlCommand command1 = new SqlCommand(query1, connection);
            command1.Parameters.AddWithValue("@UserID", UserID);

            SqlCommand command2 = new SqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader1 = command1.ExecuteReader();

                if (reader1.Read())
                {
                    isFound = true;

                    CompleteMoreTasksIn = reader1["CompleteMoreTasksIn"] == DBNull.Value ? "" : (string)reader1["CompleteMoreTasksIn"];
                }

                reader1.Close();

                using (SqlDataReader reader2 = command2.ExecuteReader())
                {
                    if (reader2.Read())
                    {
                        HabitID   = reader2["HabitID"] == DBNull.Value ? -1 : (int)reader2["HabitID"];
                        BestHabit = reader2["BestHabit"] == DBNull.Value ? "" : (string)reader2["BestHabit"];
                        
                    }
                }
            }
            catch//(Exception e)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int DueToday(int UserID)
        {
            int CurrentStreak = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"DECLARE @Today DATE = CAST(GETDATE() AS DATE)

                             SELECT COUNT(*) AS DueToday
                             FROM Tasks
                             WHERE DueDate >= @Today
                               AND DueDate < DATEADD(DAY, 1, @Today)
                               AND Status NOT IN (2, 3)
                               AND UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int currentStreak))
                {
                    CurrentStreak = currentStreak;
                }

            }
            catch
            { CurrentStreak = 0; }
            finally
            { connection.Close(); }

            return CurrentStreak;
        }

    }
}
