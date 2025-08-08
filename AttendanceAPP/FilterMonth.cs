using AttendanceAPP.Classes;
using Microsoft.Data.SqlClient;
namespace AttendanceAPP
{
    public partial class FilterMonth : UserControl
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Scita-Pc-23\\Source\\Repos\\Attendance_Project\\AttendanceAPP\\Database.mdf";
        private System.Windows.Forms.Timer refreshTimer;
        public FilterMonth()
        {
            InitializeComponent();
            dataGridUser.CellClick += dataGridUer_CellClick;
        }
        private void dataGridUer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string username = dataGridUser.Rows[e.RowIndex].Cells["Username"].Value?.ToString();
                int userId;
                if (dataGridUser.Rows[e.RowIndex].Cells["UserId"].Value != DBNull.Value &&
                    int.TryParse(dataGridUser.Rows[e.RowIndex].Cells["UserId"].Value.ToString(), out userId))
                {
                    TextBoxUser.Text = username;
                }
                else
                {
                    TextBoxUser.Clear();
                }
            }
        }

        private void UserFilter_Load(object sender, EventArgs e)
        {
            InitializeTimer();
            LayoutMonth.Visible = false;
            LayoutDate.Visible = false;
            btnBack.Enabled = false;
            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.CustomFormat = "yyyy";
            Loader.setdataGrid(dataGridUser);
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
            Loader.LoadUserData(dataGridUser);
            string username = TextBoxUser.Text.Trim();
            if (string.IsNullOrEmpty(username) || !Valid.UsernameExists(username))
            {
                LayoutMonth.Visible = false;
                LayoutDate.Visible = false;
                Layout();
            }
            else
            {
                LayoutMonth.Visible = true;
                LayoutDate.Visible = true;
            }
        }
        private List<DateTime> GetPresentDates(int year, int month, string username)
        {
            List<DateTime> dates = new List<DateTime>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT Date FROM Attendance
                                 WHERE Username = @username
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
        private void jan_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 1);
        }

        private void feb_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 2);
        }

        private void march_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 3);
        }

        private void april_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 4);
        }

        private void may_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 5);
        }

        private void june_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 6);
        }

        private void july_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 7);
        }
        private void aug_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 8);
        }

        private void sep_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 9);
        }

        private void oct_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 10);
        }

        private void nov_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 11);
        }

        private void dec_Click(object sender, EventArgs e)
        {
            int year = dateTimePickerYear.Value.Year;
            LoadAttendanceTable(year, 12);
        }
        private void LoadAttendanceTable(int year, int month)
        {
            btnBack.Enabled = true;
            LayoutDate.Visible = true;
            LayoutDate.BringToFront();
            LayoutDate.ColumnCount = 0;
            LayoutDate.RowCount = 0;
            string username = TextBoxUser.Text.Trim();
            List<DateTime> presentDates = GetPresentDates(year, month, username);
            Dictionary<DateTime, string> holidayDates = GetHolidayDates(year, month);
            DateTime joinDate = Loader.GetJoinDate(username);

            int daysInMonth = DateTime.DaysInMonth(year, month);
            DateTime today = DateTime.Today;
            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime currentDate = new DateTime(year, month, day);
                string status = "";

                if (currentDate >= joinDate && currentDate <= today)
                {
                    bool isPresent = presentDates.Contains(currentDate.Date);
                    bool isSunday = currentDate.DayOfWeek == DayOfWeek.Sunday;
                    bool isHoliday = holidayDates.ContainsKey(currentDate.Date);

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

                string text = $"{currentDate:dd-MMM-yyyy}\n{currentDate.DayOfWeek}\n{status}";

                Label label = new Label();
                label.Text = text;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;
                label.Margin = new Padding(2);
                label.Font = new Font("lucid Fax", 12F, FontStyle.Bold);
                label.ForeColor = Color.Black;
                label.BorderStyle = BorderStyle.FixedSingle;

                if (status == "Present")
                    label.BackColor = Color.LightGreen;
                else if (status == "Absent")
                    label.BackColor = Color.LightCoral;
                else if (holidayDates.Values.Contains(status))
                    label.BackColor = Color.MediumPurple;
                else if (status == "Holiday")
                    label.BackColor = Color.DodgerBlue;
                else if (status == "Special Holiday")
                    label.BackColor = Color.Purple;
                else
                    label.BackColor = Color.White;

                if (LayoutDate.ColumnCount != 7)
                {
                    LayoutDate.Controls.Add(label, LayoutDate.ColumnCount, LayoutDate.RowCount);
                    LayoutDate.ColumnCount += 1;
                }
                else
                {
                    LayoutDate.Controls.Add(label, LayoutDate.ColumnCount, LayoutDate.RowCount);
                    LayoutDate.ColumnCount = 0;
                    LayoutDate.RowCount += 1;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Layout();
        }
        private void Layout()
        {
            LayoutMonth.BringToFront();
            btnBack.Enabled = false;

            LayoutDate.Controls.Clear();
            LayoutDate.RowStyles.Clear();
            LayoutDate.ColumnStyles.Clear();

            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));

            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
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