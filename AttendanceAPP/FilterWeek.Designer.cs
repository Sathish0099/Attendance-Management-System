using System.Windows.Forms;

namespace AttendanceAPP
{
    partial class FilterWeek
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
            comboBoxWeek = new ComboBox();
            load = new Button();
            dateTimePickerYear = new DateTimePicker();
            comboBoxMonth = new ComboBox();
            dataGridUers = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxUser = new TextBox();
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
            dataGridView1.Location = new Point(379, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(617, 435);
            dataGridView1.TabIndex = 0;
            // 
            // comboBoxWeek
            // 
            comboBoxWeek.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            comboBoxWeek.FormattingEnabled = true;
            comboBoxWeek.Items.AddRange(new object[] { "Week 1", "Week 2", "Week 3", "Week 4", "Week 5" });
            comboBoxWeek.Location = new Point(152, 301);
            comboBoxWeek.Name = "comboBoxWeek";
            comboBoxWeek.Size = new Size(221, 28);
            comboBoxWeek.TabIndex = 1;
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
            load.Location = new Point(3, 440);
            load.Name = "load";
            load.Size = new Size(370, 29);
            load.TabIndex = 2;
            load.Text = "Get";
            load.UseVisualStyleBackColor = false;
            load.Click += Load_Click;
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerYear.Location = new Point(152, 369);
            dateTimePickerYear.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.Size = new Size(221, 31);
            dateTimePickerYear.TabIndex = 3;
            dateTimePickerYear.Value = new DateTime(2025, 4, 28, 0, 0, 0, 0);
            // 
            // comboBoxMonth
            // 
            comboBoxMonth.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            comboBoxMonth.FormattingEnabled = true;
            comboBoxMonth.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            comboBoxMonth.Location = new Point(152, 335);
            comboBoxMonth.Name = "comboBoxMonth";
            comboBoxMonth.Size = new Size(221, 28);
            comboBoxMonth.TabIndex = 4;
            // 
            // dataGridUers
            // 
            dataGridUers.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridUers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUers.Location = new Point(3, 34);
            dataGridUers.Name = "dataGridUers";
            dataGridUers.RowHeadersWidth = 51;
            dataGridUers.Size = new Size(370, 216);
            dataGridUers.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 31);
            label1.TabIndex = 6;
            label1.Text = "Users";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(3, 262);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 7;
            label2.Text = "UserName     :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(3, 301);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 8;
            label3.Text = "Select Week  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(3, 340);
            label4.Name = "label4";
            label4.Size = new Size(151, 23);
            label4.TabIndex = 9;
            label4.Text = "Select Month :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Purple;
            label5.Location = new Point(3, 373);
            label5.Name = "label5";
            label5.Size = new Size(152, 23);
            label5.TabIndex = 10;
            label5.Text = "Select Year    :";
            // 
            // textBoxUser
            // 
            textBoxUser.Cursor = Cursors.IBeam;
            textBoxUser.Font = new Font("Lucida Bright", 12F, FontStyle.Bold);
            textBoxUser.Location = new Point(152, 262);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Username";
            textBoxUser.Size = new Size(221, 31);
            textBoxUser.TabIndex = 11;
            // 
            // Exportbtn
            // 
            Exportbtn.Cursor = Cursors.Hand;
            Exportbtn.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Exportbtn.ForeColor = Color.DarkCyan;
            Exportbtn.Location = new Point(155, 405);
            Exportbtn.Name = "Exportbtn";
            Exportbtn.Size = new Size(218, 29);
            Exportbtn.TabIndex = 37;
            Exportbtn.Text = "Export";
            Exportbtn.UseVisualStyleBackColor = true;
            Exportbtn.Visible = false;
            Exportbtn.Click += Exportbtn_Click;
            // 
            // FilterWeek
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Exportbtn);
            Controls.Add(textBoxUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridUers);
            Controls.Add(comboBoxMonth);
            Controls.Add(dateTimePickerYear);
            Controls.Add(load);
            Controls.Add(comboBoxWeek);
            Controls.Add(dataGridView1);
            Name = "FilterWeek";
            Size = new Size(999, 501);
            Load += FilterWeek_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridUers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBoxWeek;
        private Button load;
        private DateTimePicker dateTimePickerYear;
        private ComboBox comboBoxMonth;
        private DataGridView dataGridUers;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxUser;
        private Button Exportbtn;
    }
}