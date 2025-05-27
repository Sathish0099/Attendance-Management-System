using System.Runtime.InteropServices;
namespace AttendanceAPP
{
    public partial class Filter : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private FilterWeek week = new FilterWeek();
        private FilterExportMonth month = new FilterExportMonth();
        private FilterMonth Month = new FilterMonth();
        private Calculate calc = new Calculate();
        private Holidays Holidays = new Holidays();
        public Filter()
        {
            InitializeComponent();
            panelViewing(Month);
        }
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Closebtn_Click(object sender, EventArgs e)
        {

            Dispose();
            this.Close();
        }
        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void btnWeek_Click(object sender, EventArgs e)
        {
            panelSlide.Left = btnWeek.Left;
            panelSlide.Width = btnWeek.Width;
            panelViewing(week);
            lbWindow.Text = "Weekly Filter Window";
        }
        private void btnMonth_Click(object sender, EventArgs e)
        {
            panelSlide.Left = btnMonth.Left;
            panelSlide.Width = btnMonth.Width;
            panelViewing(Month);
            lbWindow.Text = "Monthly Filter Window";
        }
        UserControl prevControl = null;
        private void panelViewing(UserControl form1)
        {
            if (prevControl == form1)
            {
                return;
            }
            prevControl = form1;
            panel.SuspendLayout();
            panel.Controls.Clear();
            panel.Controls.Add(form1);
            form1.Dock = DockStyle.Fill;
            panel.ResumeLayout();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            panelSlide.Left = btnCalc.Left;
            panelSlide.Width = btnCalc.Width;
            panelViewing(calc);
            lbWindow.Text = "Caluculate Percentage Window";
        }
        private void btnExMonth_Click(object sender, EventArgs e)
        {
            panelSlide.Left = btnExMonth.Left;
            panelSlide.Width = btnExMonth.Width;
            panelViewing(month);
            lbWindow.Text = "Monthly Filter with Export Window";
        }
        private void btnHolidays_Click(object sender, EventArgs e)
        {
            panelSlide.Left = btnHolidays.Left;
            panelSlide.Width = btnHolidays.Width;
            panelViewing(Holidays);
            lbWindow.Text = "List of Holidays Window";
        }
    }
}
