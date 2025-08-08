using AttendanceAPP.Classes;
using Microsoft.Data.SqlClient;
namespace AttendanceAPP
{
    public partial class FilterWeek : UserControl
    {
        private System.Windows.Forms.Timer refreshTimer;
        public FilterWeek()
        {
            InitializeComponent();
            dataGridUers.CellClick += dataGridUers_CellClick;
            Loader.setdataGrid(dataGridUers);
            Loader.setdataGrid(dataGridView1);
            Loader.ApplyFormatting(dataGridView1);
            InitializeTimer();
            load.Enabled = false;
            dateTimePickerYear.MaxDate = DateTime.Today;
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
            Loader.LoadUserData(dataGridUers);
            string week = comboBoxWeek.Text.Trim();
            string month = comboBoxMonth.Text.Trim();
            string username = textBoxUser.Text.Trim();
            if (string.IsNullOrWhiteSpace(week) || string.IsNullOrWhiteSpace(month) || !Valid.UsernameExists(username))
            {
                load.Enabled = false;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
            else
            {
                load.Enabled = true;
            }
        }
        private void Load_Click(object sender, EventArgs e)
        {
            Exportbtn.Visible = true;
            int selectedWeek = comboBoxWeek.SelectedIndex + 1;
            int year = dateTimePickerYear.Value.Year;
            int month = comboBoxMonth.SelectedIndex + 1;
            string username = textBoxUser.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("please enter the username");
            }
            else
            {
                if (!Valid.UsernameExists(username))
                {
                    MessageBox.Show("please enter the valid username");
                }
                else
                {
                    LoadAttendanceGrid(year, month, selectedWeek);
                }

            }

        }
        private void LoadAttendanceGrid(int year, int month, int weekNumber)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Day", "Day");
            dataGridView1.Columns.Add("Status", "Status");

            string username = textBoxUser.Text.Trim();
            List<DateTime> presentDates = Loader.GetPresentDates(year, month, username);
            Dictionary<DateTime, string> holidayDates = GetHolidayDates(year, month);
            DateTime joinDate = Loader.GetJoinDate(username);

            int daysInMonth = DateTime.DaysInMonth(year, month);
            DateTime today = DateTime.Today;
            int startDay = 1 + (weekNumber - 1) * 7;
            int endDay = Math.Min(startDay + 6, daysInMonth);

            for (int day = startDay; day <= endDay; day++)
            {
                DateTime currentDate = new DateTime(year, month, day);

                string status = "";

                if (currentDate >= joinDate && currentDate <= today)
                {
                    bool isPresent = presentDates.Contains(currentDate.Date);
                    bool isHoliday = holidayDates.ContainsKey(currentDate.Date);
                    bool isSunday = currentDate.DayOfWeek == DayOfWeek.Sunday;

                    if (isPresent)
                    {
                        status = "Present";
                    }
                    else if (isHoliday)
                    {
                        status = "Special Holiday";
                    }
                    else if (isSunday)
                    {
                        status = "Holiday";
                    }
                    else
                    {
                        status = "Absent";
                    }

                }
                else
                {
                    status = "";
                }
                dataGridView1.Rows.Add(
                    currentDate.ToString("dd-MMM-yyyy"),
                    currentDate.DayOfWeek.ToString(),
                    status
                );
            }

        }
        private void dataGridUers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string username = dataGridUers.Rows[e.RowIndex].Cells["Username"].Value?.ToString();
                int userId;
                if (dataGridUers.Rows[e.RowIndex].Cells["UserId"].Value != DBNull.Value &&
                    int.TryParse(dataGridUers.Rows[e.RowIndex].Cells["UserId"].Value.ToString(), out userId))
                {
                    textBoxUser.Text = username;
                }
                else
                {
                    textBoxUser.Clear();
                }
            }
        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\Users\Scita-Pc-23\source\repos\Attendance_Project\AttendanceAPP\Attendance Records";
            string month = comboBoxMonth.Text.Trim();
            string week = comboBoxWeek.Text.Trim();
            string username = textBoxUser.Text.Trim();
            string fileName = $"{username}_Records_{month}_{week}.csv";
            CSVExporter.ExportToCSV(dataGridView1, folderPath, fileName);
        }

        private void FilterWeek_Load(object sender, EventArgs e)
        {

            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
        }
        private Dictionary<DateTime, string> GetHolidayDates(int year, int month)
        {
            Dictionary<DateTime, string> holidays = new Dictionary<DateTime, string>();

            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf"))
            {
                string query = @"SELECT CAST(Date AS DATE) AS HolidayDate, HolidayName
                         FROM Holidays
                         WHERE YEAR(Date) = @Year AND MONTH(Date) = @Month";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Year", year);
                    cmd.Parameters.AddWithValue("@Month", month);
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            holidays[Convert.ToDateTime(reader["HolidayDate"])] = reader["HolidayName"].ToString();
                        }
                    }
                }
            }

            return holidays;
        }

    }
}
