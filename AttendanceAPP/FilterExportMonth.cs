using AttendanceAPP.Classes;
using System.Data.SqlClient;
namespace AttendanceAPP
{
    public partial class FilterExportMonth : UserControl
    {
        private System.Windows.Forms.Timer refreshTimer;
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Database.mdf;Integrated Security=True";

        public FilterExportMonth()
        {
            InitializeComponent();
            InitializeTimer();
            Loader.ApplyFormatting(dataGridView1);
            Loader.setdataGrid(dataGridUers);
            Loader.setdataGrid(dataGridView1);
            dataGridUers.CellClick += dataGridUers_CellClick;
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
            string month = comboBoxMonth.Text.Trim();
            string username = textBoxUser.Text.Trim();
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(month) || !Valid.UsernameExists(username))
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
        private void LoadAttendanceGrid(string username, int year, int month)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Day", "Day");
            dataGridView1.Columns.Add("Status", "Status");
            Dictionary<DateTime, string> holidayDates = GetHolidayDates(year, month);

            List<DateTime> presentDates = Loader.GetPresentDates(year, month, username);
            DateTime joinDate = Loader.GetJoinDate(username);
            DateTime today = DateTime.Today;
            int daysInMonth = DateTime.DaysInMonth(year, month);

            for (int day = 1; day <= daysInMonth; day++)
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
        private void load_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            int month = comboBoxMonth.SelectedIndex + 1;
            string username = textBoxUser.Text.Trim();
            LoadAttendanceGrid(username, year, month);
            Exportbtn.Visible = true;
        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Attendance Records";
            string month = comboBoxMonth.Text.Trim();
            string username = textBoxUser.Text.Trim();
            string fileName = $"{username}_Records_{month}_Month.csv";
            CSVExporter.ExportToCSV(dataGridView1, folderPath, fileName);
        }

        private void FilterExportMonth_Load(object sender, EventArgs e)
        {
            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
        }
        private Dictionary<DateTime, string> GetHolidayDates(int year, int month)
        {
            Dictionary<DateTime, string> holidays = new Dictionary<DateTime, string>();

            using (SqlConnection con = new SqlConnection(connectionString))
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
                            DateTime date = Convert.ToDateTime(reader["HolidayDate"]);
                            string name = reader["HolidayName"].ToString();
                            holidays[date] = name;
                        }
                    }
                }
            }

            return holidays;
        }

    }
}
    

