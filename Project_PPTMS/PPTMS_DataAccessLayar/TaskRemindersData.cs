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
    public class clsTaskRemindersData
    {
        public static bool GetReminderInfoByReminderID(int ReminderID, ref int TaskID, ref DateTime ReminderTime , ref bool IsTriggered)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM TaskReminders WHERE ReminderID = @ReminderID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ReminderID", ReminderID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TaskID       = (int)reader["TaskID"];
                    ReminderTime = (DateTime)reader["ReminderTime"];
                    IsTriggered  = (bool)reader["IsTriggered"];

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



        public static int AddNewReminder(int TaskID, DateTime ReminderTime, bool IsTriggered)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO TaskReminders VALUES (@TaskID , @ReminderTime , @IsTriggered );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaskID", TaskID);
            command.Parameters.AddWithValue("@ReminderTime", ReminderTime);
            command.Parameters.AddWithValue("@IsTriggered", IsTriggered);

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

        public static bool UpdateReminder(int ReminderID ,int TaskID, DateTime ReminderTime)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE TaskReminders SET TaskID=@TaskID , ReminderTime=@ReminderTime  " +
                           "WHERE ReminderID=@ReminderID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReminderID", ReminderID);
            command.Parameters.AddWithValue("@TaskID", TaskID);
            command.Parameters.AddWithValue("@ReminderTime", ReminderTime);

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

        public static bool DeleteReminder(int ReminderID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM TaskReminders WHERE ReminderID = @ReminderID ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReminderID", ReminderID);

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

        public static DataTable GetAllReminders(int TaskID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT tr.ReminderID as [Reminder ID] , tr.ReminderTime as [Reminder Time] , tr.IsTriggered as [Is Triggered]
                             FROM TaskReminders tr 
                             WHERE tr.TaskID = @TaskID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TaskID", TaskID);

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

        public static bool MarkAsTriggered(int ReminderID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE TaskReminders SET IsTriggered = 1  " +
                           "WHERE ReminderID=@ReminderID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ReminderID", ReminderID);
            

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

        public static DataTable GetPendingReminders(int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT tr.ReminderID , tr.TaskID , tr.ReminderTime , tr.IsTriggered 
                             FROM TaskReminders tr INNER JOIN Tasks t ON t.TaskID = tr.TaskID
                             WHERE t.UserID = @UserID AND tr.IsTriggered = 0 AND ReminderTime <= GETDATE();";

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


    }
}
