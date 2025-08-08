
using System.Diagnostics;
using System.Drawing.Imaging;
using Microsoft.Data.SqlClient;


namespace AttendanceAPP.Classes
{
    internal class Attendance
    {
        public static void MarkAttendance(string userName, byte[] imageBytes)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string getUserQuery = "SELECT UserId, Gender, Age FROM Users WHERE UserName = @UserName";
                int userIdFromUsers = 0;
                string gender = "";
                int age = 0;

                using (SqlCommand cmd = new SqlCommand(getUserQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userIdFromUsers = reader.GetInt32(0);
                            gender = reader.GetString(1);
                            age = reader.GetInt32(2);
                        }
                    }
                }
                if (userIdFromUsers == 0) return; 
                string checkAttendanceQuery = "SELECT COUNT(*) FROM Attendance WHERE UserId = @UserId AND Date = CAST(GETDATE() AS DATE)";

                using (SqlCommand cmd = new SqlCommand(checkAttendanceQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userIdFromUsers);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0) return;
                }

                string insertQuery = "INSERT INTO Attendance (UserId, Username, Gender, Age, EnterTime, ImageData) " +
                                     "VALUES (@UserId, @UserName, @Gender, @Age, CONVERT(VARCHAR(5), GETDATE(), 108), @ImageData)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userIdFromUsers);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@ImageData", imageBytes);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static   float[] ConvertBytesToFloatArray(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0) return null;

            if (byteArray.Length % sizeof(float) != 0)
            {
                Debug.WriteLine("Error: Face feature byte array is not a valid size.");
                return null;
            }

            float[] floatArray = new float[byteArray.Length / sizeof(float)];
            Buffer.BlockCopy(byteArray, 0, floatArray, 0, byteArray.Length);
            return floatArray;
        }
        public static   Bitmap CropImage(Bitmap source, Rectangle cropArea)
        {
            cropArea.Intersect(new Rectangle(0, 0, source.Width, source.Height));
            if (cropArea.Width <= 0 || cropArea.Height <= 0)
                return null;
            return source.Clone(cropArea, source.PixelFormat);
        }
        public static byte[] ImageToByteArray(Bitmap image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public static void UpdateExitTime(string userName)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string getUserQuery = "SELECT UserId FROM Users WHERE UserName = @UserName";
                int userId = 0;

                using (SqlCommand cmd = new SqlCommand(getUserQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = reader.GetInt32(0);
                        }
                    }
                }
                if (userId == 0) return;

                string checkAttendanceQuery = "SELECT COUNT(*) FROM Attendance WHERE UserId = @UserId AND Date = CAST(GETDATE() AS DATE)";

                using (SqlCommand cmd = new SqlCommand(checkAttendanceQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0) return;
                }

                string updateQuery = "UPDATE Attendance SET ExitTime = CONVERT(VARCHAR(5), GETDATE(), 108) WHERE UserId = @UserId AND Date = CAST(GETDATE() AS DATE)";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
