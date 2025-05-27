namespace AttendanceAPP
{
    partial class FilterExportMonth
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
            dataGridView1 = new DataGridView();
            textBoxUser = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            comboBoxMonth = new ComboBox();
            dateTimePickerYear = new DateTimePicker();
            label1 = new Label();
            dataGridUers = new DataGridView();
            load = new Button();
            Exportbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUers).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(388, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(567, 426);
            dataGridView1.TabIndex = 0;
            // 
            // textBoxUser
            // 
            textBoxUser.Cursor = Cursors.IBeam;
            textBoxUser.Font = new Font("Lucida Bright", 12F, FontStyle.Bold);
            textBoxUser.Location = new Point(164, 265);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Username";
            textBoxUser.Size = new Size(218, 31);
            textBoxUser.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(12, 341);
            label5.Name = "label5";
            label5.Size = new Size(152, 23);
            label5.TabIndex = 15;
            label5.Text = "Select Year    :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(12, 308);
            label4.Name = "label4";
            label4.Size = new Size(151, 23);
            label4.TabIndex = 14;
            label4.Text = "Select Month :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(14, 274);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 13;
            label2.Text = "UserName     :";
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonth.Location = new Point(161, 303);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(221, 28);
            comboBoxMonth.TabIndex = 12;
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerYear.Location = new Point(161, 341);
            dateTimePickerYear.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.Size = new Size(221, 31);
            dateTimePickerYear.TabIndex = 17;
            dateTimePickerYear.Value = new DateTime(2025, 4, 28, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(92, 31);
            label1.TabIndex = 20;
            label1.Text = "Users";
            // 
            // dataGridUers
            // 
            dataGridUers.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridUers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUers.Location = new Point(12, 41);
            dataGridUers.Name = "dataGridUers";
            dataGridUers.RowHeadersWidth = 51;
            dataGridUers.Size = new Size(370, 216);
            dataGridUers.TabIndex = 19;
            // 
            // load
            // 
            load.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            load.BackColor = Color.Transparent;
            load.Cursor = Cursors.Hand;
            load.FlatAppearance.BorderColor = Color.Crimson;
            load.FlatAppearance.BorderSize = 2;
            load.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            load.ForeColor = Color.Crimson;
            load.Location = new Point(14, 438);
            load.Name = "load";
            load.Size = new Size(370, 29);
            load.TabIndex = 21;
            load.Text = "Get";
            load.UseVisualStyleBackColor = false;
            load.Click += load_Click;
            // 
            // Exportbtn
            // 
            Exportbtn.Cursor = Cursors.Hand;
            Exportbtn.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Exportbtn.ForeColor = Color.DarkCyan;
            Exportbtn.Location = new Point(161, 392);
            Exportbtn.Name = "Exportbtn";
            Exportbtn.Size = new Size(218, 29);
            Exportbtn.TabIndex = 36;
            Exportbtn.Text = "Export";
            Exportbtn.UseVisualStyleBackColor = true;
            Exportbtn.Visible = false;
            Exportbtn.Click += Exportbtn_Click;
            // 
            // FilterExportMonth
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(Exportbtn);
            Controls.Add(load);
            Controls.Add(label1);
            Controls.Add(dataGridUers);
            Controls.Add(dateTimePickerYear);
            Controls.Add(textBoxUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboBoxMonth);
            Controls.Add(dataGridView1);
            Name = "FilterExportMonth";
            Size = new Size(968, 482);
            Load += FilterExportMonth_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dataGridView1;
        #endregion

        private TextBox textBoxUser;
        private Label label5;
        private Label label4;
        private Label label2;
        private ComboBox comboBoxMonth;
        private DateTimePicker dateTimePickerYear;
        private Label label1;
        private DataGridView dataGridUers;
        private Button load;
        private Button Exportbtn;
    }
}