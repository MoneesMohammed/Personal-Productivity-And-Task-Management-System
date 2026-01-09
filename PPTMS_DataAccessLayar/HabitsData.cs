using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PPTMS_DataAccessLayar
{
    public class clsHabitsData
    {
        public static bool GetHabitInfoByHabitID(int HabitID, ref int UserID, ref string Name , ref byte Frequency , ref bool IsActive,ref bool IsArchived, ref DateTime CreateDate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM Habits WHERE HabitID = @HabitID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@HabitID", HabitID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID     = (int)reader["UserID"];
                    Name       =  (string)reader["Name"];
                    Frequency  = (byte)reader["Frequency"];
                    IsActive   = (bool)reader["IsActive"];
                    IsArchived = (bool)reader["IsArchived"];
                    CreateDate = (DateTime)reader["CreateDate"];

                }

                reader.Close();
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

        public static int AddNewHabit(int UserID, string Name, byte Frequency, DateTime CreateDate)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO Habits VALUES (@UserID , @Name , @Frequency , 1 , 0 , @CreateDate );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID"     , UserID     );
            command.Parameters.AddWithValue("@Name"       , Name       );
            command.Parameters.AddWithValue("@Frequency"  , Frequency  );
            command.Parameters.AddWithValue("@CreateDate" , CreateDate );

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    ID = insertedID;
                }

            }
            catch
            { ID = -1; }
            finally
            { connection.Close(); }

            return ID;
        }

        public static bool UpdateHabit(int HabitID, string Name, byte Frequency)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Habits SET Name=@Name , Frequency=@Frequency " +
                           "WHERE HabitID=@HabitID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HabitID", HabitID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Frequency", Frequency);
            

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

        public static bool DeleteHabit(int HabitID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM Habits WHERE HabitID = @HabitID ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HabitID", HabitID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);

        }

        public static DataTable GetAllHabits(int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT h.HabitID as [Habit ID], h.Name ,

                             CASE WHEN h.Frequency = 0 THEN 'Daily'
                                  WHEN h.Frequency = 1 THEN 'Weekly'
                                  WHEN h.Frequency = 2 THEN 'Monthly'
                             ELSE 'Unknown'
                             END AS [Frequency] ,
                             
                             CASE WHEN h.IsActive = 0 THEN 'No'
                                  WHEN h.IsActive = 1 THEN 'Yes'
                             ELSE 'Unknown'
                             END AS [Is Active] ,

                             CASE WHEN h.IsArchived = 0 THEN 'No'
                                  WHEN h.IsArchived = 1 THEN 'Yes'
                             ELSE 'Unknown'
                             END AS [Is Archived] ,
                             
                             h.CreateDate as [Create Date]
                             
                             FROM Habits h
                             WHERE h.UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                { dt.Load(reader); }

                reader.Close();
            }
            catch
            { }
            finally
            { connection.Close(); }

            return dt;
        }


        //Do not permanently delete Task Replace it
        public static bool MarkAsArchived(int HabitID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Habits SET IsArchived = 1 WHERE HabitID = @HabitID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HabitID", HabitID);

            try
            {
                connection.Open();

                RowAffected = command.ExecuteNonQuery();

            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

        public static bool MarkAsActivate(int HabitID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Habits SET IsActive = 1 " +
                           "WHERE HabitID = @HabitID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HabitID", HabitID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

        public static bool MarkAsDeactivate(int HabitID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Habits SET IsActive = 0 " +
                           "WHERE HabitID = @HabitID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HabitID", HabitID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

        public static bool IsCheckIn(int HabitID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"DECLARE @Today DATE = CAST(GETDATE() AS DATE);

                             SELECT 
                             
                                 CASE 
                                     WHEN hl.LastLogDate IS NULL THEN 0 -- It has not been implemented before
                                     WHEN h.Frequency = 0 AND @Today >= DATEADD(DAY, 1, hl.LastLogDate)  THEN 0
                                     WHEN h.Frequency = 1 AND @Today >= DATEADD(DAY, 7, hl.LastLogDate)  THEN 0
                                     WHEN h.Frequency = 2 AND @Today >= DATEADD(DAY, 30, hl.LastLogDate) THEN 0
                                     ELSE 1
                                 END AS IsDue
                             
                             FROM Habits h
                             OUTER APPLY
                             (
                                 SELECT MAX(CAST(LogDate AS DATE)) AS LastLogDate
                                 FROM HabitLogs
                                 WHERE HabitID = h.HabitID
                             ) hl
                             WHERE h.HabitID = @HabitID; ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@HabitID", HabitID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int result))
                {
                    isFound = Convert.ToBoolean(result);
                }

            }
            catch //(Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();

            }

            return isFound;


        }

        public static bool IsTodayCheckIn(int HabitID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT Found = 1 FROM HabitLogs
                             WHERE HabitID = @HabitID
                             AND LogDate = CAST(GETDATE() AS DATE);";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@HabitID", HabitID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();
            }
            catch //(Exception ex)
            {
                //Console.WriteLine("Error : " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();

            }

            return isFound;


        }

        public static int CurrentStreak(int HabitID)
        {
            int CurrentStreak = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT COUNT(*) AS CurrentStreak
                             FROM (
                                   SELECT LogDate,ROW_NUMBER() OVER (ORDER BY LogDate DESC) AS RowNumber
                                   FROM HabitLogs    
                                   WHERE HabitID = @HabitID  
                                 ) R1Logs
                             WHERE DATEADD(DAY, -(RowNumber - 1), CAST(GETDATE() AS DATE)) = LogDate;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HabitID", HabitID);

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

        public static int BestStreak(int HabitID)
        {
            int BestStreak = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT MAX(StreakCount) AS BestStreak
                             FROM
                             (SELECT COUNT(*) AS StreakCount
                             FROM (
                                   SELECT LogDate, DATEADD(DAY, -rn, LogDate) AS grp 
                                   FROM (
                                          SELECT LogDate,ROW_NUMBER() OVER (ORDER BY LogDate) AS rn   
                                          FROM HabitLogs
                                          WHERE HabitID = @HabitID 
                                        ) R1Logs
                                  ) GroupedLogs
                                 GROUP BY grp
                             ) AS Streaks;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HabitID", HabitID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int bestStreak))
                {
                    BestStreak = bestStreak;
                }

            }
            catch
            { BestStreak = 0; }
            finally
            { connection.Close(); }

            return BestStreak;
        }

        public static float CompletionRate(int HabitID)
        {
            float CompletionRate = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT CAST((COUNT(hl.LogID) * 100.0) / (DATEDIFF(DAY, MIN(h.CreateDate), CAST(GETDATE() AS DATE)) + 1)
                                 AS DECIMAL(5,2)) AS CompletionRate
                             FROM Habits h LEFT JOIN HabitLogs hl ON h.HabitID = hl.HabitID
                             WHERE h.HabitID = @HabitID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HabitID", HabitID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null)
                {
                    CompletionRate = Convert.ToSingle(Result.ToString());
                }

            }
            catch
            { CompletionRate = 0; }
            finally
            { connection.Close(); }

            return CompletionRate;
        }
    }
}
