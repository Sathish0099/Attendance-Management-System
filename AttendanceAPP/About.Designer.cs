namespace AttendanceAPP
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            Title = new Label();
            icon = new PictureBox();
            label8 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)icon).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.SteelBlue;
            Title.Location = new Point(347, 142);
            Title.Name = "Title";
            Title.Size = new Size(559, 57);
            Title.TabIndex = 10;
            Title.Text = "Automatic Attendance ";
            // 
            // icon
            // 
            icon.Anchor = AnchorStyles.Top;
            icon.BackgroundImageLayout = ImageLayout.Zoom;
            icon.Image = (Image)resources.GetObject("icon.Image");
            icon.Location = new Point(502, -27);
            icon.Name = "icon";
            icon.Size = new Size(200, 200);
            icon.SizeMode = PictureBoxSizeMode.Zoom;
            icon.TabIndex = 9;
            icon.TabStop = false;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Fax", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(574, 550);
            label8.Name = "label8";
            label8.Size = new Size(61, 17);
            label8.TabIndex = 18;
            label8.Text = "©2025";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(556, 209);
            label1.Name = "label1";
            label1.Size = new Size(92, 18);
            label1.TabIndex = 19;
            label1.Text = "Version  1.0";
            // 
            // About
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(Title);
            Controls.Add(icon);
            Name = "About";
            Size = new Size(1250, 567);
            ((System.ComponentModel.ISupportInitialize)icon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Title;
        private PictureBox icon;
        private Label label8;
        private Label label1;
    }
}
