using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_DataAccessLayar
{
    public class clsTasksData
    {
        public static bool GetTaskInfoByTaskID(int TaskID, ref int UserID, ref int CategoryID, ref string Title, ref string Description ,
         ref byte Status ,ref byte Priority ,ref DateTime DueDate ,ref int EstimatedMinutes ,ref DateTime CompletedDate ,ref DateTime CreateDate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM Tasks WHERE TaskID = @TaskID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TaskID", TaskID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    UserID           = (int)reader["UserID"];
                    CategoryID       = (int)reader["CategoryID"];
                    Title            = (string)reader["Title"];
                    Description      = reader["Description"] == DBNull.Value ? "" : (string)reader["Description"];
                    Status           = (byte)reader["Status"];
                    Priority         = (byte)reader["Priority"];
                    DueDate          = (DateTime)reader["DueDate"];
                    EstimatedMinutes = (int)reader["EstimatedMinutes"];
                    CompletedDate    = reader["CompletedDate"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["CompletedDate"];
                    CreateDate       = (DateTime)reader["CreateDate"];

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

        public static int AddNewTask(int UserID, int CategoryID, string Title, string Description,byte Status,
                                     byte Priority, DateTime DueDate, int EstimatedMinutes, DateTime CreateDate)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"INSERT INTO Tasks VALUES (@UserID , @CategoryID , @Title , @Description , @Status , @Priority , @DueDate , @EstimatedMinutes , @CompletedDate , @CreateDate);" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID"          ,UserID);
            command.Parameters.AddWithValue("@CategoryID"      ,CategoryID);
            command.Parameters.AddWithValue("@Title"           ,Title);
            command.Parameters.AddWithValue("@Status"          ,Status);
            command.Parameters.AddWithValue("@Priority"        ,Priority);
            command.Parameters.AddWithValue("@DueDate"         ,DueDate);
            command.Parameters.AddWithValue("@EstimatedMinutes",EstimatedMinutes);
            command.Parameters.AddWithValue("@CreateDate"      ,CreateDate);

            if (Description != "")
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", System.DBNull.Value);

            command.Parameters.AddWithValue("@CompletedDate", System.DBNull.Value);

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
            {
                ID = -1;
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }

        public static bool UpdateTask(int TaskID, int CategoryID, string Title, string Description,byte Status,
                                       byte Priority, DateTime DueDate, int EstimatedMinutes)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Tasks SET  CategoryID=@CategoryID , Title=@Title , Description=@Description , Status=@Status , Priority=@Priority , DueDate=@DueDate , EstimatedMinutes=@EstimatedMinutes   " +
                           "WHERE TaskID = @TaskID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaskID", TaskID);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Status", Status);
            command.Parameters.AddWithValue("@Priority", Priority);
            command.Parameters.AddWithValue("@DueDate", DueDate);
            command.Parameters.AddWithValue("@EstimatedMinutes", EstimatedMinutes);
            
            if (Description != "")
                command.Parameters.AddWithValue("@Description", Description);
            else
                command.Parameters.AddWithValue("@Description", System.DBNull.Value);

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

        //Do not permanently delete Task Replace it
        public static bool SetStatusArchive(int TaskID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Tasks SET Status = 3 WHERE TaskID = @TaskID;";
        
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaskID", TaskID);

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

        public static DataTable GetAllTasks(int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT * FROM Tasks_View 
                             WHERE [Task ID] IN (SELECT TaskID FROM Tasks Where UserID = @UserID); ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    dt.Load(reader);

                }

                reader.Close();
            }
            catch
            {

            }
            finally
            {
                connection.Close();
            }


            return dt;
        }

        public static bool SetStatus(int TaskID, byte Status)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Tasks SET Status = @Status " +
                           "WHERE TaskID = @TaskID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaskID", TaskID);
            command.Parameters.AddWithValue("@Status", Status);

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

        public static bool SetStatusCompleted(int TaskID)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE Tasks SET Status = 2 , CompletedDate = GETDATE() " +
                           "WHERE TaskID = @TaskID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaskID", TaskID);
            
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


    }
}
