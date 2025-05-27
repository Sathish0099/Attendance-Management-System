namespace AttendanceAPP
{
    partial class Calculate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            textBoxUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridUers = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            load = new Button();
            working = new TextBox();
            present = new TextBox();
            absent = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            presentTimer = new System.Windows.Forms.Timer(components);
            AbsentTimer = new System.Windows.Forms.Timer(components);
            pPercent = new Label();
            aPercent = new Label();
            progressPresent = new ProgressBar();
            progressAbsent = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dataGridUers).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePickerStart.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePickerStart.Location = new Point(162, 451);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(205, 29);
            dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dateTimePickerEnd.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            dateTimePickerEnd.Location = new Point(162, 515);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(205, 29);
            dateTimePickerEnd.TabIndex = 1;
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxUser.Cursor = Cursors.IBeam;
            textBoxUser.Font = new Font("Lucida Bright", 12F, FontStyle.Bold);
            textBoxUser.Location = new Point(162, 387);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.PlaceholderText = "Username";
            textBoxUser.Size = new Size(205, 31);
            textBoxUser.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.Location = new Point(13, 387);
            label2.Name = "label2";
            label2.Size = new Size(149, 23);
            label2.TabIndex = 14;
            label2.Text = "UserName     :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(9, 8);
            label1.Name = "label1";
            label1.Size = new Size(92, 31);
            label1.TabIndex = 13;
            label1.Text = "Users";
            // 
            // dataGridUers
            // 
            dataGridUers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridUers.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridUers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUers.Location = new Point(12, 42);
            dataGridUers.Name = "dataGridUers";
            dataGridUers.RowHeadersWidth = 51;
            dataGridUers.Size = new Size(370, 279);
            dataGridUers.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Purple;
            label3.Location = new Point(13, 453);
            label3.Name = "label3";
            label3.Size = new Size(149, 23);
            label3.TabIndex = 16;
            label3.Text = "Start Date      :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Purple;
            label4.Location = new Point(13, 517);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 17;
            label4.Text = "End Date       :";
            // 
            // load
            // 
            load.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            load.BackColor = Color.Transparent;
            load.Cursor = Cursors.Hand;
            load.FlatAppearance.BorderColor = Color.Crimson;
            load.FlatAppearance.BorderSize = 2;
            load.FlatStyle = FlatStyle.Flat;
            load.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            load.ForeColor = Color.Crimson;
            load.Location = new Point(9, 588);
            load.Name = "load";
            load.Size = new Size(370, 38);
            load.TabIndex = 18;
            load.Text = "Get";
            load.UseVisualStyleBackColor = false;
            load.Click += load_Click;
            // 
            // working
            // 
            working.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            working.BackColor = SystemColors.InactiveBorder;
            working.BorderStyle = BorderStyle.FixedSingle;
            working.Enabled = false;
            working.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold);
            working.Location = new Point(620, 42);
            working.Name = "working";
            working.Size = new Size(125, 35);
            working.TabIndex = 19;
            // 
            // present
            // 
            present.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            present.BackColor = SystemColors.InactiveBorder;
            present.BorderStyle = BorderStyle.FixedSingle;
            present.Enabled = false;
            present.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            present.Location = new Point(620, 240);
            present.Name = "present";
            present.Size = new Size(125, 35);
            present.TabIndex = 20;
            // 
            // absent
            // 
            absent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            absent.BackColor = SystemColors.InactiveBorder;
            absent.BorderStyle = BorderStyle.FixedSingle;
            absent.Enabled = false;
            absent.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            absent.Location = new Point(620, 424);
            absent.Name = "absent";
            absent.Size = new Size(125, 35);
            absent.TabIndex = 21;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(445, 47);
            label5.Name = "label5";
            label5.Size = new Size(169, 17);
            label5.TabIndex = 22;
            label5.Text = "Total Working Days :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(450, 245);
            label6.Name = "label6";
            label6.Size = new Size(164, 17);
            label6.TabIndex = 23;
            label6.Text = "Total Days Present :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(447, 429);
            label7.Name = "label7";
            label7.Size = new Size(167, 17);
            label7.TabIndex = 24;
            label7.Text = "Total Days Absent  :";
            // 
            // pPercent
            // 
            pPercent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pPercent.AutoSize = true;
            pPercent.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pPercent.ForeColor = Color.MediumSeaGreen;
            pPercent.Location = new Point(1007, 295);
            pPercent.Name = "pPercent";
            pPercent.Size = new Size(28, 26);
            pPercent.TabIndex = 27;
            pPercent.Text = "%";
            // 
            // aPercent
            // 
            aPercent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            aPercent.AutoSize = true;
            aPercent.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aPercent.ForeColor = Color.IndianRed;
            aPercent.Location = new Point(1007, 480);
            aPercent.Name = "aPercent";
            aPercent.Size = new Size(28, 26);
            aPercent.TabIndex = 28;
            aPercent.Text = "%";
            // 
            // progressPresent
            // 
            progressPresent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            progressPresent.ForeColor = Color.MediumSeaGreen;
            progressPresent.Location = new Point(445, 295);
            progressPresent.Name = "progressPresent";
            progressPresent.Size = new Size(510, 26);
            progressPresent.Style = ProgressBarStyle.Continuous;
            progressPresent.TabIndex = 40;
            // 
            // progressAbsent
            // 
            progressAbsent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            progressAbsent.ForeColor = Color.IndianRed;
            progressAbsent.Location = new Point(445, 480);
            progressAbsent.Name = "progressAbsent";
            progressAbsent.Size = new Size(510, 26);
            progressAbsent.Style = ProgressBarStyle.Continuous;
            progressAbsent.TabIndex = 41;
            // 
            // Calculate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(progressAbsent);
            Controls.Add(progressPresent);
            Controls.Add(aPercent);
            Controls.Add(pPercent);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(absent);
            Controls.Add(present);
            Controls.Add(working);
            Controls.Add(load);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridUers);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Name = "Calculate";
            Size = new Size(1467, 641);
            Load += Calculate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private TextBox textBoxUser;
        private Label label2;
        private Label label1;
        private DataGridView dataGridUers;
        private Label label3;
        private Label label4;
        private Button load;
        private TextBox working;
        private TextBox present;
        private TextBox absent;
        private Label label5;
        private Label label6;
        private Label label7;
        private System.Windows.Forms.Timer presentTimer;
        private System.Windows.Forms.Timer AbsentTimer;
        private Label pPercent;
        private Label aPercent;
        private ProgressBar progressPresent;
        private ProgressBar progressAbsent;
    }
}
