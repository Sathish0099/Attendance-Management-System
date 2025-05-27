namespace AttendanceAPP
{
    partial class FilterMonth
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
            dataGridUser = new DataGridView();
            label3 = new Label();
            TextBoxUser = new TextBox();
            label4 = new Label();
            LayoutMonth = new TableLayoutPanel();
            dec = new Button();
            nov = new Button();
            oct = new Button();
            sep = new Button();
            aug = new Button();
            july = new Button();
            june = new Button();
            may = new Button();
            april = new Button();
            march = new Button();
            feb = new Button();
            jan = new Button();
            btnBack = new Button();
            LayoutDate = new TableLayoutPanel();
            dateTimePickerYear = new DateTimePicker();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            LayoutMonth.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridUser
            // 
            dataGridUser.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridUser.BorderStyle = BorderStyle.Fixed3D;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(12, 40);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.RowHeadersWidth = 51;
            dataGridUser.Size = new Size(400, 300);
            dataGridUser.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkTurquoise;
            label3.Location = new Point(12, 360);
            label3.Name = "label3";
            label3.Size = new Size(139, 23);
            label3.TabIndex = 3;
            label3.Text = "Select User  :";
            // 
            // TextBoxUser
            // 
            TextBoxUser.Cursor = Cursors.IBeam;
            TextBoxUser.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TextBoxUser.Location = new Point(147, 357);
            TextBoxUser.Name = "TextBoxUser";
            TextBoxUser.PlaceholderText = "Username";
            TextBoxUser.Size = new Size(265, 31);
            TextBoxUser.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkTurquoise;
            label4.Location = new Point(12, 397);
            label4.Name = "label4";
            label4.Size = new Size(140, 23);
            label4.TabIndex = 6;
            label4.Text = "Select Year  :";
            // 
            // LayoutMonth
            // 
            LayoutMonth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LayoutMonth.BackColor = SystemColors.ActiveCaption;
            LayoutMonth.ColumnCount = 3;
            LayoutMonth.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LayoutMonth.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LayoutMonth.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            LayoutMonth.Controls.Add(dec, 2, 3);
            LayoutMonth.Controls.Add(nov, 1, 3);
            LayoutMonth.Controls.Add(oct, 0, 3);
            LayoutMonth.Controls.Add(sep, 2, 2);
            LayoutMonth.Controls.Add(aug, 1, 2);
            LayoutMonth.Controls.Add(july, 0, 2);
            LayoutMonth.Controls.Add(june, 2, 1);
            LayoutMonth.Controls.Add(may, 1, 1);
            LayoutMonth.Controls.Add(april, 0, 1);
            LayoutMonth.Controls.Add(march, 2, 0);
            LayoutMonth.Controls.Add(feb, 1, 0);
            LayoutMonth.Controls.Add(jan, 0, 0);
            LayoutMonth.Location = new Point(421, 11);
            LayoutMonth.Name = "LayoutMonth";
            LayoutMonth.RowCount = 4;
            LayoutMonth.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LayoutMonth.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LayoutMonth.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LayoutMonth.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            LayoutMonth.Size = new Size(554, 464);
            LayoutMonth.TabIndex = 9;
            // 
            // dec
            // 
            dec.BackColor = Color.Transparent;
            dec.Dock = DockStyle.Fill;
            dec.FlatAppearance.BorderColor = SystemColors.Highlight;
            dec.FlatStyle = FlatStyle.Flat;
            dec.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dec.ForeColor = Color.Crimson;
            dec.Location = new Point(371, 351);
            dec.Name = "dec";
            dec.Size = new Size(180, 110);
            dec.TabIndex = 11;
            dec.Text = "December";
            dec.UseVisualStyleBackColor = false;
            dec.Click += dec_Click;
            // 
            // nov
            // 
            nov.BackColor = Color.Transparent;
            nov.Dock = DockStyle.Fill;
            nov.FlatAppearance.BorderColor = SystemColors.Highlight;
            nov.FlatStyle = FlatStyle.Flat;
            nov.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nov.ForeColor = Color.Crimson;
            nov.Location = new Point(187, 351);
            nov.Name = "nov";
            nov.Size = new Size(178, 110);
            nov.TabIndex = 10;
            nov.Text = "November";
            nov.UseVisualStyleBackColor = false;
            nov.Click += nov_Click;
            // 
            // oct
            // 
            oct.BackColor = Color.Transparent;
            oct.Dock = DockStyle.Fill;
            oct.FlatAppearance.BorderColor = SystemColors.Highlight;
            oct.FlatStyle = FlatStyle.Flat;
            oct.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            oct.ForeColor = Color.Crimson;
            oct.Location = new Point(3, 351);
            oct.Name = "oct";
            oct.Size = new Size(178, 110);
            oct.TabIndex = 9;
            oct.Text = "October";
            oct.UseVisualStyleBackColor = false;
            oct.Click += oct_Click;
            // 
            // sep
            // 
            sep.BackColor = Color.Transparent;
            sep.Dock = DockStyle.Fill;
            sep.FlatAppearance.BorderColor = SystemColors.Highlight;
            sep.FlatStyle = FlatStyle.Flat;
            sep.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sep.ForeColor = Color.Crimson;
            sep.Location = new Point(371, 235);
            sep.Name = "sep";
            sep.Size = new Size(180, 110);
            sep.TabIndex = 8;
            sep.Text = "September";
            sep.UseVisualStyleBackColor = false;
            sep.Click += sep_Click;
            // 
            // aug
            // 
            aug.BackColor = Color.Transparent;
            aug.Dock = DockStyle.Fill;
            aug.FlatAppearance.BorderColor = SystemColors.Highlight;
            aug.FlatStyle = FlatStyle.Flat;
            aug.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aug.ForeColor = Color.Crimson;
            aug.Location = new Point(187, 235);
            aug.Name = "aug";
            aug.Size = new Size(178, 110);
            aug.TabIndex = 7;
            aug.Text = "August";
            aug.UseVisualStyleBackColor = false;
            aug.Click += aug_Click;
            // 
            // july
            // 
            july.BackColor = Color.Transparent;
            july.Dock = DockStyle.Fill;
            july.FlatAppearance.BorderColor = SystemColors.Highlight;
            july.FlatStyle = FlatStyle.Flat;
            july.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            july.ForeColor = Color.Crimson;
            july.Location = new Point(3, 235);
            july.Name = "july";
            july.Size = new Size(178, 110);
            july.TabIndex = 6;
            july.Text = "July";
            july.UseVisualStyleBackColor = false;
            july.Click += july_Click;
            // 
            // june
            // 
            june.BackColor = Color.Transparent;
            june.Dock = DockStyle.Fill;
            june.FlatAppearance.BorderColor = SystemColors.Highlight;
            june.FlatStyle = FlatStyle.Flat;
            june.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            june.ForeColor = Color.Crimson;
            june.Location = new Point(371, 119);
            june.Name = "june";
            june.Size = new Size(180, 110);
            june.TabIndex = 5;
            june.Text = "June";
            june.UseVisualStyleBackColor = false;
            june.Click += june_Click;
            // 
            // may
            // 
            may.BackColor = Color.Transparent;
            may.Dock = DockStyle.Fill;
            may.FlatAppearance.BorderColor = SystemColors.Highlight;
            may.FlatStyle = FlatStyle.Flat;
            may.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            may.ForeColor = Color.Crimson;
            may.Location = new Point(187, 119);
            may.Name = "may";
            may.Size = new Size(178, 110);
            may.TabIndex = 4;
            may.Text = "May";
            may.UseVisualStyleBackColor = false;
            may.Click += may_Click;
            // 
            // april
            // 
            april.BackColor = Color.Transparent;
            april.Dock = DockStyle.Fill;
            april.FlatAppearance.BorderColor = SystemColors.Highlight;
            april.FlatStyle = FlatStyle.Flat;
            april.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            april.ForeColor = Color.Crimson;
            april.Location = new Point(3, 119);
            april.Name = "april";
            april.Size = new Size(178, 110);
            april.TabIndex = 3;
            april.Text = "April";
            april.UseVisualStyleBackColor = false;
            april.Click += april_Click;
            // 
            // march
            // 
            march.BackColor = Color.Transparent;
            march.Dock = DockStyle.Fill;
            march.FlatAppearance.BorderColor = SystemColors.Highlight;
            march.FlatStyle = FlatStyle.Flat;
            march.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            march.ForeColor = Color.Crimson;
            march.Location = new Point(371, 3);
            march.Name = "march";
            march.Size = new Size(180, 110);
            march.TabIndex = 2;
            march.Text = "March";
            march.UseVisualStyleBackColor = false;
            march.Click += march_Click;
            // 
            // feb
            // 
            feb.BackColor = Color.Transparent;
            feb.Dock = DockStyle.Fill;
            feb.FlatAppearance.BorderColor = SystemColors.Highlight;
            feb.FlatStyle = FlatStyle.Flat;
            feb.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feb.ForeColor = Color.Crimson;
            feb.Location = new Point(187, 3);
            feb.Name = "feb";
            feb.Size = new Size(178, 110);
            feb.TabIndex = 1;
            feb.Text = "February";
            feb.UseVisualStyleBackColor = false;
            feb.Click += feb_Click;
            // 
            // jan
            // 
            jan.BackColor = Color.Transparent;
            jan.Dock = DockStyle.Fill;
            jan.FlatAppearance.BorderColor = SystemColors.Highlight;
            jan.FlatStyle = FlatStyle.Flat;
            jan.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            jan.ForeColor = Color.Crimson;
            jan.Location = new Point(3, 3);
            jan.Name = "jan";
            jan.Size = new Size(178, 110);
            jan.TabIndex = 0;
            jan.Text = "January";
            jan.UseVisualStyleBackColor = false;
            jan.Click += jan_Click;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.LightSeaGreen;
            btnBack.FlatAppearance.BorderSize = 2;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.LightSeaGreen;
            btnBack.Location = new Point(216, 443);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(196, 34);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // LayoutDate
            // 
            LayoutDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            LayoutDate.BackColor = SystemColors.ActiveCaption;
            LayoutDate.ColumnCount = 7;
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857141F));
            LayoutDate.Location = new Point(418, 14);
            LayoutDate.Name = "LayoutDate";
            LayoutDate.RowCount = 5;
            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LayoutDate.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            LayoutDate.Size = new Size(554, 464);
            LayoutDate.TabIndex = 11;
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerYear.Location = new Point(147, 397);
            dateTimePickerYear.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.Size = new Size(265, 31);
            dateTimePickerYear.TabIndex = 18;
            dateTimePickerYear.Value = new DateTime(2025, 4, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(92, 31);
            label1.TabIndex = 19;
            label1.Text = "Users";
            // 
            // FilterMonth
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(label1);
            Controls.Add(dateTimePickerYear);
            Controls.Add(LayoutMonth);
            Controls.Add(label4);
            Controls.Add(btnBack);
            Controls.Add(TextBoxUser);
            Controls.Add(label3);
            Controls.Add(dataGridUser);
            Controls.Add(LayoutDate);
            Name = "FilterMonth";
            Size = new Size(984, 488);
            Load += UserFilter_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            LayoutMonth.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridUser;
        private Label label3;
        private TextBox TextBoxUser;
        private Label label4;
        private TableLayoutPanel LayoutMonth;
        private Button btnBack;
        private Button dec;
        private Button nov;
        private Button oct;
        private Button sep;
        private Button aug;
        private Button july;
        private Button june;
        private Button may;
        private Button april;
        private Button march;
        private Button feb;
        private Button jan;
        private TableLayoutPanel LayoutDate;
        private DateTimePicker dateTimePickerYear;
        private Label label1;
    }
}