using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_DataAccessLayar
{
    public class clsTaskCategoriesData
    {
        public static bool GetCategoryInfoByCategoryID(int CategoryID, ref int UserID, ref string Name)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM TaskCategories WHERE CategoryID = @CategoryID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    UserID = reader["UserID"] == DBNull.Value ? -1 : (int)reader["UserID"]; 
                    Name = (string)reader["Name"];

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

        public static int AddNewCategory(int UserID, string Name)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO TaskCategories VALUES (@UserID , @Name );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Name", Name);
            
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

        public static bool UpdateCategory(int CategoryID, string Name)
        {
            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "UPDATE TaskCategories SET Name=@Name  " +
                           "WHERE CategoryID=@CategoryID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@Name", Name);

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

        public static bool DeleteCategory(int CategoryID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "DELETE FROM TaskCategories WHERE CategoryID = @CategoryID AND UserID IS Not Null";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@CategoryID", CategoryID);

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

        public static DataTable GetAllCategories(int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT CategoryID as [Category ID] , Name as [Category Name]  FROM TaskCategories
                             WHERE UserID IS NULL OR UserID = @UserID;";

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
