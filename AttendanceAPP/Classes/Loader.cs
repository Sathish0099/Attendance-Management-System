using Microsoft.Data.SqlClient;
using System.Data;
using AForge.Video.DirectShow;

namespace AttendanceAPP.Classes
{
    internal class Loader
    {
        public static void LoadUserData(DataGridView datagrid)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserId, UserName, Gender, Age FROM Users";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        datagrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }
        public static void setdataGrid(DataGridView S)
        {
            S.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida", 10, FontStyle.Bold);
            S.DefaultCellStyle.Font = new Font("Lucida", 14);
            S.ColumnHeadersDefaultCellStyle.ForeColor = Color.OrangeRed;
            S.EnableHeadersVisualStyles = false;

        }
        public static void SetDefaultCameraResolution(VideoCaptureDevice device, int width, int height)
        {
            VideoCapabilities[] capabilities = device.VideoCapabilities;

            foreach (var cap in capabilities)
            {
                if (cap.FrameSize.Width == width && cap.FrameSize.Height == height)
                {
                    device.VideoResolution = cap;
                    return;
                }
            }

            if (capabilities.Length > 0)
            {
                device.VideoResolution = capabilities[0];
            }
        }
        public static void SetUserJoinDateAsMinDate(string username,DateTimePicker StartDate, DateTimePicker EndDate)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT JoinDate FROM Users WHERE UserName = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            DateTime joinDate = Convert.ToDateTime(result);
                            StartDate.MinDate = joinDate < StartDate.MaxDate ? joinDate : StartDate.MaxDate;
                            EndDate.MinDate = joinDate;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error setting join date: " + ex.Message);
            }
        }
        public static DateTime GetJoinDate(string username)
        {
            DateTime joinDate = new DateTime(2024, 1, 1); 
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT JoinDate FROM Users WHERE Username = @username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        joinDate = Convert.ToDateTime(result);
                    }
                }
            }
            return joinDate;
        }
        public static List<DateTime> GetPresentDates(int year, int month,string username)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            List<DateTime> dates = new List<DateTime>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT Date FROM Attendance
                         WHERE UserName = @Username
                         AND YEAR([Date]) = @Year
                         AND MONTH([Date]) = @Month";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Month", month);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dates.Add(Convert.ToDateTime(reader["Date"]).Date);
                        }
                    }
                }
            }

            return dates;
        }
        public static List<DateTime> PresentDates(DateTimePicker Start, DateTimePicker End, string username)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            List<DateTime> dates = new List<DateTime>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT Date FROM Attendance
                         WHERE UserName = @Username
                        AND Date BETWEEN @StartDate AND @EndDate";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@StartDate", Start.Value.Date);
                    cmd.Parameters.AddWithValue("@EndDate", End.Value.Date);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dates.Add(Convert.ToDateTime(reader["Date"]).Date);
                        }
                    }
                }
            }

            return dates;
        }
        public static void ApplyFormatting(DataGridView grid)
        {
            grid.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var value = e.Value?.ToString();

                    if (value == "Present")
                    {
                        e.CellStyle.ForeColor = Color.LimeGreen;
                        e.CellStyle.BackColor = Color.White;
                    }
                    else if (value == "Absent")
                    {
                        e.CellStyle.ForeColor = Color.LightCoral;
                        e.CellStyle.BackColor = Color.White;
                    }
                    else if (string.IsNullOrEmpty(value))
                    {
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.BackColor = Color.White;
                    }
                    else if (value == "Holiday")
                    {
                        e.CellStyle.ForeColor = Color.Blue;
                        e.CellStyle.BackColor = Color.White;
                    }
                    else if (value == "Special Holiday")
                    {
                        e.CellStyle.ForeColor = Color.DarkCyan;
                        e.CellStyle.BackColor = Color.White;
                    }
                    
                }
            };
        }

    }
}
