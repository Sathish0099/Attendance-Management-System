namespace AttendanceAPP
{
    partial class Holidays
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
            btnAdd = new Button();
            btnRemove = new Button();
            dateTimePicker = new DateTimePicker();
            dataGridHolidays = new DataGridView();
            label2 = new Label();
            txtHoliday = new TextBox();
            label1 = new Label();
            dateTimePickerYear = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridHolidays).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderColor = Color.DarkTurquoise;
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Lucida Fax", 11F, FontStyle.Bold);
            btnAdd.ForeColor = Color.DarkTurquoise;
            btnAdd.Location = new Point(34, 307);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.FlatAppearance.BorderColor = Color.DarkTurquoise;
            btnRemove.FlatAppearance.BorderSize = 2;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Lucida Fax", 11F, FontStyle.Bold);
            btnRemove.ForeColor = Color.DarkTurquoise;
            btnRemove.Location = new Point(224, 307);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(125, 35);
            btnRemove.TabIndex = 1;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Lucida Fax", 9F, FontStyle.Bold);
            dateTimePicker.Location = new Point(172, 109);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(177, 25);
            dateTimePicker.TabIndex = 2;
            // 
            // dataGridHolidays
            // 
            dataGridHolidays.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridHolidays.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridHolidays.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridHolidays.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHolidays.Location = new Point(384, 12);
            dataGridHolidays.Name = "dataGridHolidays";
            dataGridHolidays.RowHeadersWidth = 51;
            dataGridHolidays.Size = new Size(695, 330);
            dataGridHolidays.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 11F, FontStyle.Bold);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(34, 210);
            label2.Name = "label2";
            label2.Size = new Size(136, 22);
            label2.TabIndex = 5;
            label2.Text = "Holiday       :";
            // 
            // txtHoliday
            // 
            txtHoliday.Font = new Font("Lucida Fax", 11F, FontStyle.Bold);
            txtHoliday.Location = new Point(172, 210);
            txtHoliday.Name = "txtHoliday";
            txtHoliday.Size = new Size(177, 29);
            txtHoliday.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 11F, FontStyle.Bold);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(34, 109);
            label1.Name = "label1";
            label1.Size = new Size(132, 22);
            label1.TabIndex = 37;
            label1.Text = "Select Date :";
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.Anchor = AnchorStyles.Bottom;
            dateTimePickerYear.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerYear.Location = new Point(636, 361);
            dateTimePickerYear.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.Size = new Size(265, 31);
            dateTimePickerYear.TabIndex = 39;
            dateTimePickerYear.Value = new DateTime(2025, 4, 28, 0, 0, 0, 0);
            dateTimePickerYear.ValueChanged += dateTimePickerYear_ValueChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Bright", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkTurquoise;
            label4.Location = new Point(458, 361);
            label4.Name = "label4";
            label4.Size = new Size(172, 29);
            label4.TabIndex = 38;
            label4.Text = "Select Year  :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Bright", 18F, FontStyle.Bold);
            label3.ForeColor = Color.DarkTurquoise;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(266, 34);
            label3.TabIndex = 40;
            label3.Text = "Special Holidays";
            // 
            // Holidays
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(label3);
            Controls.Add(dateTimePickerYear);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtHoliday);
            Controls.Add(label2);
            Controls.Add(dataGridHolidays);
            Controls.Add(dateTimePicker);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Name = "Holidays";
            Size = new Size(1128, 413);
            Load += Holidays_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridHolidays).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnRemove;
        private DateTimePicker dateTimePicker;
        private DataGridView dataGridHolidays;
        private Label label2;
        private TextBox txtHoliday;
        private Label label1;
        private DateTimePicker dateTimePickerYear;
        private Label label4;
        private Label label3;
    }
}