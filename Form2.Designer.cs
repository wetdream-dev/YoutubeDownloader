namespace YoutubeDownloader
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            pictureProgress = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            label9 = new Label();
            linkLabel2 = new LinkLabel();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            lblStatus = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProgress).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(pictureProgress);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 32);
            panel1.TabIndex = 1;
            // 
            // pictureProgress
            // 
            pictureProgress.Image = (Image)resources.GetObject("pictureProgress.Image");
            pictureProgress.Location = new Point(12, 4);
            pictureProgress.Name = "pictureProgress";
            pictureProgress.Size = new Size(32, 25);
            pictureProgress.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProgress.TabIndex = 3;
            pictureProgress.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Motley Forces", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(40, 3);
            label3.Name = "label3";
            label3.Size = new Size(57, 26);
            label3.TabIndex = 1;
            label3.Text = "ABOUT";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(341, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(32, 32);
            panel2.TabIndex = 0;
            panel2.Click += panel2_Click;
            panel2.MouseEnter += panel2_MouseEnter;
            panel2.MouseLeave += panel2_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Motley Forces", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(7, 7);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click;
            label1.MouseEnter += label1_MouseEnter;
            label1.MouseLeave += label1_MouseLeave;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(38, 41, 64);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(linkLabel2);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(linkLabel1);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(lblStatus);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(3, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(367, 346);
            panel4.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(14, 169);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 168);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Change Log";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.AutoScroll = true;
            panel5.Controls.Add(label9);
            panel5.Location = new Point(6, 22);
            panel5.Name = "panel5";
            panel5.Size = new Size(332, 140);
            panel5.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Size = new Size(153, 45);
            label9.TabIndex = 0;
            label9.Text = "💠 Changes on 13 May 2024\r\n\r\n   ◈ Nothing";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.DodgerBlue;
            linkLabel2.Location = new Point(260, 125);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(58, 15);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Telegram.";
            linkLabel2.VisitedLinkColor = Color.DodgerBlue;
            linkLabel2.Click += linkLabel2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(127, 124);
            label8.Name = "label8";
            label8.Size = new Size(137, 15);
            label8.TabIndex = 9;
            label8.Text = "Found bug? chat me on";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DodgerBlue;
            linkLabel1.Location = new Point(281, 109);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Github.";
            linkLabel1.VisitedLinkColor = Color.DodgerBlue;
            linkLabel1.Click += linkLabel1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(127, 109);
            label7.Name = "label7";
            label7.Size = new Size(157, 15);
            label7.TabIndex = 7;
            label7.Text = "Source code is available on";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(196, 78);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(74, 13);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Latest Version";
            lblStatus.Click += lblStatus_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(127, 75);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 5;
            label5.Text = "WetDream |";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Motley Forces", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(123, 43);
            label4.Name = "label4";
            label4.Size = new Size(234, 35);
            label4.TabIndex = 4;
            label4.Text = "YOUTUBE DOWNLOADER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(373, 368);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureProgress).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureProgress;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Panel panel4;
        private Label label7;
        private Label lblStatus;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel2;
        private Label label8;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private Panel panel5;
        private Label label9;
    }
}