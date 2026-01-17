using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_DataAccessLayar
{
    public class clsTaskAttachmentsData
    {
        public static bool GetAttachmentInfoByAttachmentID(int AttachmentID, ref int TaskID, ref string FileName,ref string FilePath, ref DateTime UploadedDate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM TaskAttachments WHERE AttachmentID = @AttachmentID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AttachmentID", AttachmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    TaskID       = (int)reader["TaskID"];
                    FileName     = (string)reader["FileName"];
                    FilePath     = (string)reader["FilePath"];
                    UploadedDate = (DateTime)reader["UploadedDate"];

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

        public static int AddNewAttachment(int TaskID, string FileName, string FilePath, DateTime UploadedDate)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO TaskAttachments VALUES (@TaskID , @FileName , @FilePath , @UploadedDate );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TaskID", TaskID);
            command.Parameters.AddWithValue("@FileName", FileName);
            command.Parameters.AddWithValue("@FilePath", FilePath);
            command.Parameters.AddWithValue("@UploadedDate", UploadedDate);

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

        public static bool UpdateAttachment(int AttachmentID, string FileName, string FilePath )
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE TaskAttachments SET FileName=@FileName , FilePath=@FilePath  " +
                           "WHERE AttachmentID=@AttachmentID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AttachmentID", AttachmentID);
            command.Parameters.AddWithValue("@FileName", FileName);
            command.Parameters.AddWithValue("@FilePath", FilePath);
           
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

        public static bool DeleteAttachment(int AttachmentID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM TaskAttachments WHERE AttachmentID = @AttachmentID ;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AttachmentID", AttachmentID);

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

        public static DataTable GetAllAttachments(int TaskID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT ta.AttachmentID as [Attachment ID] , ta.FileName as [File Name] ,ta.UploadedDate as [Uploaded Date]
                             FROM TaskAttachments ta
                             WHERE ta.TaskID = @TaskID;";

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
