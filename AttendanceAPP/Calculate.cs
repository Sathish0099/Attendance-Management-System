using AttendanceAPP.Classes;
using System.Data.SqlClient;

namespace AttendanceAPP
{
    public partial class Calculate : UserControl
    {
        public Calculate()
        {
            InitializeComponent();
            dataGridUers.CellClick += dataGridUers_CellClick;
        }
        private System.Windows.Forms.Timer refreshTimer;
        private void Calculate_Load(object sender, EventArgs e)
        {
            Loader.LoadUserData(dataGridUers);
            Loader.setdataGrid(dataGridUers);
            InitializeTimer();
            load.Enabled = false;
            dateTimePickerStart.Value= new DateTime(2025, 4, 22);
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
            string username = textBoxUser.Text.Trim();
            Loader.SetUserJoinDateAsMinDate(username,dateTimePickerStart, dateTimePickerEnd);
            if (string.IsNullOrEmpty(username) || !Valid.UsernameExists(username))
            {
                load.Enabled = false;
                working.Clear();
                present.Clear();
                absent.Clear();
                SetVisible(false);
            }
            else
            {
                load.Enabled = true;
            }
        }
        private void SetVisible(bool  S)
        {
            progressPresent.Visible = S;
            progressAbsent.Visible = S;
            pPercent.Visible = S;
            aPercent.Visible = S;
        }
        private void LoadAttendance()
        {
            string username = textBoxUser.Text.Trim();
            DateTime startDate = dateTimePickerStart.Value.Date;
            DateTime endDate = dateTimePickerEnd.Value.Date;
            int presentCount = 0;
            int absentCount = 0;
            if (endDate < startDate)
            {
                MessageBox.Show("End date must be after start date.");
                return;
            }

            List<DateTime> presentDates = Loader.PresentDates(dateTimePickerStart, dateTimePickerEnd, username);
            DateTime joinDate = Loader.GetJoinDate(username);
            DateTime today = DateTime.Today;
            HashSet<DateTime> holidayDates = GetHolidayDates(startDate, endDate);

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                if (currentDate >= joinDate && currentDate <= today)
                {
                    bool isPresent = presentDates.Contains(currentDate.Date);
                    bool isHoliday = holidayDates.Contains(currentDate.Date);
                    bool isSunday = currentDate.DayOfWeek == DayOfWeek.Sunday;

                    if (isPresent)
                    {
                        presentCount++; 
                    }
                    else if (!isHoliday && !isSunday)
                    {
                        absentCount++;
                    }
                }
            }
            working.Text = (presentCount + absentCount).ToString();
            present.Text = presentCount.ToString();
            absent.Text = absentCount.ToString();
            int totalDays = presentCount + absentCount;
            if (totalDays > 0)
            {
                double p = (presentCount * 100.0) / totalDays;
                double a = (absentCount * 100.0) / totalDays;
                pPercent.Text = $"{p:F2} %";
                aPercent.Text = $"{a:F2} %";
            }
            else
            {
                pPercent.Text = "0 %";
                aPercent.Text = "0 %";
            }
            progressPresent.Value = (int)Math.Round((presentCount * 100.0) / (presentCount + absentCount));
            progressAbsent.Value = (int)Math.Round((absentCount * 100.0) / (presentCount + absentCount));
        }
        private void load_Click(object sender, EventArgs e)
        {
            LoadAttendance();
            SetVisible(true);
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
        private HashSet<DateTime> GetHolidayDates(DateTime startDate, DateTime endDate)
        {
            HashSet<DateTime> holidays = new HashSet<DateTime>();
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Database.mdf;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT CAST(Date AS DATE) AS HolidayDate
                         FROM Holidays
                         WHERE Date BETWEEN @Start AND @End";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Start", startDate);
                    cmd.Parameters.AddWithValue("@End", endDate);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            holidays.Add(Convert.ToDateTime(reader["HolidayDate"]));
                        }
                    }
                }
            }

            return holidays;
        }

    }
}
