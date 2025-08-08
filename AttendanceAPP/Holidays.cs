using AttendanceAPP.Classes;
using Microsoft.Data.SqlClient;
using System.Data;

namespace AttendanceAPP
{
    public partial class Holidays : UserControl
    {
        public Holidays()
        {
            InitializeComponent();
        }

        private void Holidays_Load(object sender, EventArgs e)
        {
            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            Loader.setdataGrid(dataGridHolidays);
            LoadHoliDays();
        }

        private void dateTimePickerYear_ValueChanged(object sender, EventArgs e)
        {
            LoadHoliDays();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker.Value.Date;
            string name = txtHoliday.Text.Trim();
            if (dateExists(selectedDate)&& name!=null)
            {
                MessageBox.Show("Selected Date is already Added");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter Holiday Name");
                }
                else
                {
                    SaveHoliday(selectedDate, name);
                    MessageBox.Show("Selected date saved successfully!");
                }
            }
            LoadHoliDays();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridHolidays.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridHolidays.SelectedRows[0];
                DateTime date = Convert.ToDateTime(selectedRow.Cells["Date"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this date?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeletedateFromDatabase(date);
                    MessageBox.Show("Selected date deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a date to delete.");
            }
            LoadHoliDays();
        }
        private void SaveHoliday(DateTime date, string name)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string Query = "IF NOT EXISTS (SELECT 1 FROM Holidays WHERE Date = @Date) " +
                        "INSERT INTO Holidays (Date, HolidayName) VALUES (@Date, @HolidayName)";
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@HolidayName", name);
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        public static bool dateExists(DateTime date)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Holidays WHERE Date = @date";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", date);
                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private void DeletedateFromDatabase(DateTime date)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Holidays WHERE Date = @date";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Date", date);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        private void LoadHoliDays()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int year = dateTimePickerYear.Value.Year;

                    // Corrected SQL query: match by YEAR(Date)
                    string query = "SELECT Date, HolidayName FROM Holidays WHERE YEAR(Date) = @Year ORDER BY Date";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", year);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridHolidays.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading holidays: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
