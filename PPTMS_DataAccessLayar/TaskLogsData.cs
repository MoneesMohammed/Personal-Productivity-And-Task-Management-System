using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_DataAccessLayar
{
    public class clsTaskLogsData
    {
        public static bool GetLogInfoByLogID(int LogID, ref int TaskID, ref byte Action, ref string OldValue, ref string NewValue ,ref DateTime ActionDate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM TaskLogs WHERE LogID = @LogID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LogID", LogID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TaskID = (int)reader["TaskID"];
                    Action = (byte)reader["Action"];
                    OldValue = reader["OldValue"] == DBNull.Value ? "" : (string)reader["OldValue"];
                    NewValue = (string)reader["NewValue"];
                    ActionDate = (DateTime)reader["UploadedDate"];

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

        public static int AddNewLog(int TaskID, byte Action, string OldValue, string NewValue, DateTime ActionDate)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO TaskLogs VALUES (@TaskID , @Action , @OldValue ,@NewValue, @ActionDate );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaskID", TaskID);
            command.Parameters.AddWithValue("@Action", Action);
            
            command.Parameters.AddWithValue("@NewValue", NewValue);
            command.Parameters.AddWithValue("@ActionDate", ActionDate);

            if (OldValue != "")
                command.Parameters.AddWithValue("@OldValue", OldValue);
            else
                command.Parameters.AddWithValue("@OldValue", System.DBNull.Value);


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

        public static bool UpdateLog(int LogID, int TaskID, byte Action, string OldValue, string NewValue, DateTime ActionDate)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE TaskLogs SET Action=@Action , OldValue=@OldValue , NewValue=@NewValue , ActionDate=@ActionDate " +
                           "WHERE LogID=@LogID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LogID", LogID);
            command.Parameters.AddWithValue("@TaskID", TaskID);
            command.Parameters.AddWithValue("@Action", Action);
           
            command.Parameters.AddWithValue("@NewValue", NewValue);
            command.Parameters.AddWithValue("@ActionDate", ActionDate);

            if (OldValue != "")
                command.Parameters.AddWithValue("@OldValue", OldValue);
            else
                command.Parameters.AddWithValue("@OldValue", System.DBNull.Value);

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

        public static bool DeleteLog(int LogID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM TaskLogs WHERE LogID = @LogID ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LogID", LogID);

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

        public static DataTable GetAllLogs(int TaskID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT tl.LogID as [Log ID] , tl.Action , tl.OldValue as [Old Value] , tl.NewValue as [New Value] , tl.ActionDate as [Action Date] 
                             FROM TaskLogs tl
                             WHERE tl.TaskID = @TaskID;";

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


    }
}
