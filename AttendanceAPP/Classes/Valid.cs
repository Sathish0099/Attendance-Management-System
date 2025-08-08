using Microsoft.Data.SqlClient;
namespace AttendanceAPP.Classes
{
    internal class Valid
    {
        public static bool UsernameExists(string username)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
