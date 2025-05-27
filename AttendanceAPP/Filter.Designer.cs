namespace AttendanceAPP
{
    partial class Filter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filter));
            panelTop = new Panel();
            lbWindow = new Label();
            pictureBox1 = new PictureBox();
            Closebtn = new PictureBox();
            Minimize = new PictureBox();
            panelDown = new Panel();
            btnMonth = new Button();
            btnWeek = new Button();
            panelSlide = new Panel();
            panelBtn = new Panel();
            btnCalc = new Button();
            btnExMonth = new Button();
            btnHolidays = new Button();
            panel = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Closebtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            panelBtn.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Crimson;
            panelTop.Controls.Add(lbWindow);
            panelTop.Controls.Add(pictureBox1);
            panelTop.Controls.Add(Closebtn);
            panelTop.Controls.Add(Minimize);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1467, 50);
            panelTop.TabIndex = 0;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // lbWindow
            // 
            lbWindow.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbWindow.AutoSize = true;
            lbWindow.Font = new Font("Lucida Fax", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWindow.ForeColor = Color.DarkTurquoise;
            lbWindow.Location = new Point(56, 9);
            lbWindow.Name = "lbWindow";
            lbWindow.Size = new Size(350, 32);
            lbWindow.TabIndex = 13;
            lbWindow.Text = "Monthly Filter Window";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Closebtn
            // 
            Closebtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Closebtn.BackColor = Color.Transparent;
            Closebtn.BackgroundImageLayout = ImageLayout.Stretch;
            Closebtn.Cursor = Cursors.Hand;
            Closebtn.Image = (Image)resources.GetObject("Closebtn.Image");
            Closebtn.Location = new Point(1429, 12);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(30, 30);
            Closebtn.SizeMode = PictureBoxSizeMode.StretchImage;
            Closebtn.TabIndex = 12;
            Closebtn.TabStop = false;
            Closebtn.Click += Closebtn_Click;
            // 
            // Minimize
            // 
            Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimize.BackColor = Color.Transparent;
            Minimize.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize.Cursor = Cursors.Hand;
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(1393, 12);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(30, 30);
            Minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            Minimize.TabIndex = 9;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // panelDown
            // 
            panelDown.BackColor = SystemColors.Info;
            panelDown.Dock = DockStyle.Bottom;
            panelDown.Location = new Point(0, 791);
            panelDown.Name = "panelDown";
            panelDown.Size = new Size(1467, 8);
            panelDown.TabIndex = 1;
            // 
            // btnMonth
            // 
            btnMonth.Cursor = Cursors.Hand;
            btnMonth.FlatAppearance.BorderColor = Color.IndianRed;
            btnMonth.FlatAppearance.BorderSize = 2;
            btnMonth.FlatStyle = FlatStyle.Flat;
            btnMonth.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMonth.ForeColor = SystemColors.ButtonFace;
            btnMonth.Image = (Image)resources.GetObject("btnMonth.Image");
            btnMonth.ImageAlign = ContentAlignment.TopCenter;
            btnMonth.Location = new Point(2, -1);
            btnMonth.Name = "btnMonth";
            btnMonth.Size = new Size(200, 100);
            btnMonth.TabIndex = 0;
            btnMonth.Text = "Month";
            btnMonth.TextAlign = ContentAlignment.BottomCenter;
            btnMonth.UseVisualStyleBackColor = true;
            btnMonth.Click += btnMonth_Click;
            // 
            // btnWeek
            // 
            btnWeek.Cursor = Cursors.Hand;
            btnWeek.FlatAppearance.BorderColor = Color.IndianRed;
            btnWeek.FlatAppearance.BorderSize = 2;
            btnWeek.FlatStyle = FlatStyle.Flat;
            btnWeek.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWeek.ForeColor = SystemColors.ButtonFace;
            btnWeek.Image = (Image)resources.GetObject("btnWeek.Image");
            btnWeek.ImageAlign = ContentAlignment.TopCenter;
            btnWeek.Location = new Point(202, 2);
            btnWeek.Name = "btnWeek";
            btnWeek.Size = new Size(200, 100);
            btnWeek.TabIndex = 1;
            btnWeek.Text = "Week";
            btnWeek.TextAlign = ContentAlignment.BottomCenter;
            btnWeek.UseVisualStyleBackColor = true;
            btnWeek.Click += btnWeek_Click;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = SystemColors.Info;
            panelSlide.Location = new Point(0, 3);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(200, 8);
            panelSlide.TabIndex = 1;
            // 
            // panelBtn
            // 
            panelBtn.BackColor = Color.PaleVioletRed;
            panelBtn.Controls.Add(panelSlide);
            panelBtn.Controls.Add(btnWeek);
            panelBtn.Controls.Add(btnCalc);
            panelBtn.Controls.Add(btnMonth);
            panelBtn.Controls.Add(btnExMonth);
            panelBtn.Controls.Add(btnHolidays);
            panelBtn.Dock = DockStyle.Top;
            panelBtn.Location = new Point(0, 50);
            panelBtn.Name = "panelBtn";
            panelBtn.Size = new Size(1467, 100);
            panelBtn.TabIndex = 6;
            // 
            // btnCalc
            // 
            btnCalc.Cursor = Cursors.Hand;
            btnCalc.FlatAppearance.BorderColor = Color.IndianRed;
            btnCalc.FlatAppearance.BorderSize = 2;
            btnCalc.FlatStyle = FlatStyle.Flat;
            btnCalc.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.ForeColor = SystemColors.ButtonFace;
            btnCalc.Image = (Image)resources.GetObject("btnCalc.Image");
            btnCalc.ImageAlign = ContentAlignment.TopCenter;
            btnCalc.Location = new Point(402, -1);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(200, 100);
            btnCalc.TabIndex = 2;
            btnCalc.Text = "Calculate";
            btnCalc.TextAlign = ContentAlignment.BottomCenter;
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnExMonth
            // 
            btnExMonth.Cursor = Cursors.Hand;
            btnExMonth.FlatAppearance.BorderColor = Color.IndianRed;
            btnExMonth.FlatAppearance.BorderSize = 2;
            btnExMonth.FlatStyle = FlatStyle.Flat;
            btnExMonth.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExMonth.ForeColor = SystemColors.ButtonFace;
            btnExMonth.Image = (Image)resources.GetObject("btnExMonth.Image");
            btnExMonth.ImageAlign = ContentAlignment.TopCenter;
            btnExMonth.Location = new Point(602, -1);
            btnExMonth.Name = "btnExMonth";
            btnExMonth.Size = new Size(200, 100);
            btnExMonth.TabIndex = 3;
            btnExMonth.Text = "Month with Export";
            btnExMonth.TextAlign = ContentAlignment.BottomCenter;
            btnExMonth.UseVisualStyleBackColor = true;
            btnExMonth.Click += btnExMonth_Click;
            // 
            // btnHolidays
            // 
            btnHolidays.Cursor = Cursors.Hand;
            btnHolidays.FlatAppearance.BorderColor = Color.IndianRed;
            btnHolidays.FlatAppearance.BorderSize = 2;
            btnHolidays.FlatStyle = FlatStyle.Flat;
            btnHolidays.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHolidays.ForeColor = SystemColors.ButtonFace;
            btnHolidays.Image = (Image)resources.GetObject("btnHolidays.Image");
            btnHolidays.ImageAlign = ContentAlignment.TopCenter;
            btnHolidays.Location = new Point(802, -1);
            btnHolidays.Name = "btnHolidays";
            btnHolidays.Size = new Size(200, 100);
            btnHolidays.TabIndex = 4;
            btnHolidays.Text = "Holidays";
            btnHolidays.TextAlign = ContentAlignment.BottomCenter;
            btnHolidays.UseVisualStyleBackColor = true;
            btnHolidays.Click += btnHolidays_Click;
            // 
            // panel
            // 
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 150);
            panel.Name = "panel";
            panel.Size = new Size(1467, 641);
            panel.TabIndex = 0;
            // 
            // Filter
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1467, 799);
            Controls.Add(panel);
            Controls.Add(panelBtn);
            Controls.Add(panelDown);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Filter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtercs";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Closebtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            panelBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private PictureBox Closebtn;
        private PictureBox Minimize;
        private PictureBox pictureBox1;
        private Panel panelDown;
        private Button btnMonth;
        private Button btnWeek;
        private Panel panelSlide;
        private Panel panelBtn;
        private Panel panel;
        private Button btnCalc;
        private Button btnExMonth;
        private Label lbWindow;
        private Button btnHolidays;
    }
}