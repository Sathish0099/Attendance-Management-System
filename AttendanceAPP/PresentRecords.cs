using System.Data;
using System.Data.SqlClient;
using AttendanceAPP.Classes;
namespace AttendanceAPP
{
    public partial class PresentRecords : UserControl
    {
        private System.Windows.Forms.Timer refreshTimer;
        public PresentRecords()
        {
            InitializeComponent();
        }
        private void AttendanceRecords_Load(object sender, EventArgs e)
        {
            InitializeTimer();

            dataGrid.CellClick += dataGrid_CellClick;

            dateTimePicker1.MinDate = new DateTime(2025, 4, 22);
            dateTimePicker1.MaxDate = DateTime.Today;

            dtpStartDate.MinDate = new DateTime(2025, 4, 22);
            dtpStartDate.MaxDate = DateTime.Today;

            dtpEndDate.MinDate = new DateTime(2025, 4, 22);
            dtpEndDate.MaxDate = DateTime.Today;

            dtpStartDate.Value = dtpStartDate.MinDate;
            Loader.setdataGrid(dataGrid);
            Loader.setdataGrid(dataGridView);
            Exportbtn.Enabled = true;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Exportbtn.Enabled = false;
            txtUsername.Clear();
            dataGridView.DataSource = null;
            LoadUserData();
            Exportbtn.Enabled = true;
            if (pictureBoxImage.Image != null)
            {
                pictureBoxImage.Image.Dispose();
            }
            pictureBoxImage.Image = null;
        }
        private void LoadUserData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"); 
                    string query = "SELECT UserId, Username, Gender, Age, EnterTime, ExitTime, FORMAT(WorkedHours, '00') + ':' + FORMAT((WorkedHours * 60) % 60, '00') AS WorkedHours  FROM Attendance WHERE CONVERT(date, Date) = @SelectedDate";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

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
        private void Exportbtn_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Attendance Records";
            
            if (userCheckbox.Checked)
            {
                if (dataGridView.DataSource != null)
                {
                    string username = txtUsername.Text.Trim();
                    string fileName = $"{username}-Present Records.csv";
                    CSVExporter.ExportToCSV(dataGridView, folderPath, fileName);
                }
                else
                {
                    MessageBox.Show("No Data founded Please Ensure the user data is getted or Not");
                }
            }
            else
            {
                string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string fileName = $"Present_Attendance_{selectedDate}.csv";
                CSVExporter.ExportToCSV(dataGrid, folderPath, fileName);
            }
        }
        private void btnTotalDaysPresent_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after end date.");
                dataGridView.DataSource = null;
                return;
            }
            LoadByDateRange();
        }
        private void LoadByDateRange()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string username = txtUsername.Text.Trim();

                    if (string.IsNullOrEmpty(username))
                    {
                        MessageBox.Show("Please enter a username.", "Input Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        pictureBoxImage.Image = null;
                        dataGridView.DataSource = null;
                        return;
                    }

                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE UserName = @Username";
                    using (SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@Username", username);
                        int userExists = (int)checkUserCmd.ExecuteScalar();

                        if (userExists == 0)
                        {
                            MessageBox.Show("Invalid Username! Please enter a valid username.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtUsername.Clear();
                            pictureBoxImage.Image = null;
                            dataGridView.DataSource = null;
                            return;
                        }
                    }
                    ShowDaysPresentForUser(username);
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching attendance count: " + ex.Message);
            }
        }
        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string username = dataGrid.Rows[e.RowIndex].Cells["Username"].Value?.ToString();
                int userId;
                if (dataGrid.Rows[e.RowIndex].Cells["UserId"].Value != DBNull.Value &&
                    int.TryParse(dataGrid.Rows[e.RowIndex].Cells["UserId"].Value.ToString(), out userId))
                {
                    txtUsername.Text = username;
                    LoadUserImage(userId);
                    Loader.SetUserJoinDateAsMinDate(username, dtpStartDate, dtpEndDate);
                }
                else
                {
                    txtUsername.Clear();
                    if (pictureBoxImage.Image != null)
                    {
                        pictureBoxImage.Image.Dispose();
                    }
                    pictureBoxImage.Image = null;
                }
            }
        }
        private void LoadUserImage(int userId)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Database.mdf;Integrated Security=True";
            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ImageData FROM Attendance WHERE UserId = @UserId AND CONVERT(date, Date) = @SelectedDate";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            byte[] imageData = (byte[])result;

                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBoxImage.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBoxImage.Image = null; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
        private void ShowDaysPresentForUser(string username)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\AttendanceAPP\\AttendanceAPP\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                                SELECT DISTINCT CONVERT(date, Date) AS PresentDate 
                                    FROM Attendance 
                                    WHERE Username = @Username 
                                    AND Date BETWEEN @StartDate AND @EndDate 
                                    AND CONVERT(date, Date) NOT IN (SELECT CAST(Date AS DATE) FROM Holidays)
                                    ORDER BY PresentDate
                                    ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView.DataSource = dt;
                        dataGridView.Columns[0].HeaderText = "Date Present";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user's attendance dates: " + ex.Message);
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
            string username = txtUsername.Text.Trim();
            Loader.SetUserJoinDateAsMinDate(username, dtpStartDate, dtpEndDate);
            if (dataGridView.DataSource != null)
            {
                ExpUser.Visible = true;
                userCheckbox.Visible = true;
                ExpUser.Text = username + " Total days Absent Records";
            }
            else
            {
                ExpUser.Visible = false;
                userCheckbox.Visible = false;
                userCheckbox.Checked = false;
            }
        }
    }
}
