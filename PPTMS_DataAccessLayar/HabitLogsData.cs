using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTMS_DataAccessLayar
{
    public class clsHabitLogsData
    {
        public static bool GetHabitLogInfoByLogID(int LogID, ref int HabitID, ref bool IsCompleted, ref DateTime LogDate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = "SELECT * FROM HabitLogs WHERE LogID = @LogID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LogID", LogID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    HabitID     = (int)reader["HabitID"];
                    IsCompleted = (bool)reader["IsCompleted"];
                    LogDate     = (DateTime)reader["LogDate"];

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

        public static int CheckIn(int HabitID)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = "INSERT INTO HabitLogs VALUES (@HabitID, 1, CAST(GETDATE() AS DATE) );" +
                           "SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@HabitID", HabitID);
           
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

        public static bool UndoCheckIn(int HabitID)
        {
            int RowAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"DELETE FROM HabitLogs
                             WHERE HabitID = @HabitID
                             AND LogDate = CAST(GETDATE() AS DATE);";

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

        public static DataTable GetAllHabitLogs()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);
            string query = @"SELECT * FROM HabitLogs";

            SqlCommand command = new SqlCommand(query, connection);
            

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
