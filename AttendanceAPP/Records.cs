using System.Data;
using System.Data.SqlClient;
using AttendanceAPP.Classes;
namespace AttendanceAPP
{
    public partial class Records : UserControl
    {
        private System.Windows.Forms.Timer refreshTimer;
        public Records()
        {
            InitializeComponent();
            Loader.ApplyFormatting(dataGridView);
            Loader.ApplyFormatting(dataGrid);
            dateTimePicker1.MinDate = new DateTime(2025, 4, 22);
            dateTimePicker1.MaxDate = DateTime.Today;

            dateTimePickerStart.MinDate = new DateTime(2025, 4, 22);
            dateTimePickerStart.MaxDate = DateTime.Today;

            dateTimePickerEnd.MinDate = new DateTime(2025, 4, 22);
            dateTimePickerEnd.MaxDate = DateTime.Today;

            dateTimePickerStart.Value = dateTimePickerStart.MinDate;
        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Attendance Records";
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string fileName = $"Attendance_Records_{selectedDate}.csv";
            CSVExporter.ExportToCSV(dataGrid, folderPath, fileName);
        }

        private void Records_Load(object sender, EventArgs e)
        {
            Loader.setdataGrid(dataGrid);
            Loader.setdataGrid(dataGridView);
            InitializeTimer();
        }
        private void LoadUserData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    DateTime selectedDate = dateTimePicker1.Value.Date;
                    string dateParam = selectedDate.ToString("yyyy-MM-dd");
                    bool isSunday = selectedDate.DayOfWeek == DayOfWeek.Sunday;

                    string query = @"
                        SELECT 
                            u.UserId,
                            u.UserName,
                            u.Gender,
                            u.Age,
                            CASE 
                                WHEN a.UserId IS NOT NULL THEN 'Present'
                                WHEN EXISTS (
                                    SELECT 1 FROM Holidays h WHERE CAST(h.Date AS DATE) = @SelectedDate
                                ) THEN 'Special Holiday'
                                ELSE @AbsentStatus
                            END AS Status
                        FROM Users u
                        LEFT JOIN Attendance a
                            ON u.UserId = a.UserId AND CAST(a.Date AS DATE) = @SelectedDate
                        WHERE u.JoinDate <= @SelectedDate
                        ORDER BY u.UserId;";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDate", dateParam);
                        bool Sunday = selectedDate.DayOfWeek == DayOfWeek.Sunday;
                        cmd.Parameters.AddWithValue("@AbsentStatus", Sunday ? "Holiday" : "Absent");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance records: " + ex.Message);
            }
        }

        private void InitializeTimer()
        {
            refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 1000; 
            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void btnGet_Click(object sender, EventArgs e)
        {
            LoadAttendanceReport();
            ExportbtnFilter.Enabled = true;
        }
        private void LoadAttendanceReport()
        {
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;

            DataTable dtReport = new DataTable();
            dtReport.Columns.Add("UserId", typeof(int));
            dtReport.Columns.Add("UserName", typeof(string));

            List<DateTime> allDates = new List<DateTime>();
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                string columnName = date.ToString("yyyy-MM-dd");
                dtReport.Columns.Add(columnName);
                allDates.Add(date);
            }

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Database.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmdUsers = new SqlCommand("SELECT UserId, UserName, JoinDate FROM Users", conn);
                SqlDataAdapter daUsers = new SqlDataAdapter(cmdUsers);
                DataTable dtUsers = new DataTable();
                daUsers.Fill(dtUsers);

                foreach (DataRow userRow in dtUsers.Rows)
                {
                    int userId = Convert.ToInt32(userRow["UserId"]);
                    string username = userRow["UserName"].ToString();
                    DateTime joinDate = Convert.ToDateTime(userRow["JoinDate"]);

                    DataRow newRow = dtReport.NewRow();
                    newRow["UserId"] = userId;
                    newRow["UserName"] = username;

                    foreach (DateTime date in allDates)
                    {
                        string columnKey = date.ToString("yyyy-MM-dd");

                        if (date < joinDate)
                        {
                            newRow[columnKey] = "";
                        }
                        else
                        {
                            SqlCommand cmdAttendance = new SqlCommand(
                                "SELECT COUNT(*) FROM Attendance WHERE UserId = @UserId AND CAST(Date AS DATE) = @Date", conn);
                            cmdAttendance.Parameters.AddWithValue("@UserId", userId);
                            cmdAttendance.Parameters.AddWithValue("@Date", date);

                            int count = (int)cmdAttendance.ExecuteScalar();

                            if (count > 0)
                            {
                                newRow[columnKey] = "Present";
                            }
                            else
                            {
                                // Check if holiday
                                SqlCommand cmdHoliday = new SqlCommand("SELECT TOP 1 HolidayName FROM Holidays WHERE CAST(Date AS DATE) = @Date", conn);
                                cmdHoliday.Parameters.AddWithValue("@Date", date);
                                object holidayObj = cmdHoliday.ExecuteScalar();

                                if (holidayObj != null)
                                {
                                    newRow[columnKey] = "Special Holiday"; 
                                }
                                else if (date.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    newRow[columnKey] = "Holiday";
                                }
                                else
                                {
                                    newRow[columnKey] = "Absent";
                                }
                            }
                        }
                    }

                    dtReport.Rows.Add(newRow);
                }

                conn.Close();
            }

            dataGridView.DataSource = dtReport;
        }

        private void ExportbtnFilter_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Attendance Records";
            string startDate = dateTimePickerStart.Value.ToString("yyyy-MM-dd");
            string endDate = dateTimePickerEnd.Value.ToString("yyyy-MM-dd");
            string fileName = $"Attendance_Records_{startDate}_to_{endDate}.csv";
            CSVExporter.ExportToCSV(dataGridView, folderPath, fileName);
        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            ExportbtnFilter.Enabled = false;
        }
        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            ExportbtnFilter.Enabled = false;
        }

        private void SpecificData_Click(object sender, EventArgs e)
        {
            Filter fil = new Filter();
            fil.Show();
        }

    }
}
