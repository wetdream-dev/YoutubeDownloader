namespace YoutubeDownloader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureIconYT = new PictureBox();
            pictureProgress = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            lblVersion = new Label();
            lblAbout = new Label();
            groupBox2 = new GroupBox();
            pThumbnail = new Panel();
            label17 = new Label();
            loadingDownload = new ProgressBar();
            lblPercent = new Label();
            lblStatus = new Label();
            lblSize = new Label();
            lblLength = new Label();
            lblTitle = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            pbThumbnail = new PictureBox();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            cbAudioOnly = new CheckBox();
            btnDownload = new Button();
            btnBrowse = new Button();
            tbPathFolder = new TextBox();
            label6 = new Label();
            tbTitle = new TextBox();
            label5 = new Label();
            btnStart = new Button();
            label4 = new Label();
            tbUrl = new TextBox();
            tpAbout = new ToolTip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureIconYT).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureProgress).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            pThumbnail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbThumbnail).BeginInit();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(pictureIconYT);
            panel1.Controls.Add(pictureProgress);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 32);
            panel1.TabIndex = 0;
            // 
            // pictureIconYT
            // 
            pictureIconYT.Image = (Image)resources.GetObject("pictureIconYT.Image");
            pictureIconYT.Location = new Point(12, 0);
            pictureIconYT.Name = "pictureIconYT";
            pictureIconYT.Size = new Size(32, 32);
            pictureIconYT.SizeMode = PictureBoxSizeMode.Zoom;
            pictureIconYT.TabIndex = 2;
            pictureIconYT.TabStop = false;
            // 
            // pictureProgress
            // 
            pictureProgress.Image = (Image)resources.GetObject("pictureProgress.Image");
            pictureProgress.Location = new Point(12, 0);
            pictureProgress.Name = "pictureProgress";
            pictureProgress.Size = new Size(32, 32);
            pictureProgress.SizeMode = PictureBoxSizeMode.Zoom;
            pictureProgress.TabIndex = 3;
            pictureProgress.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Motley Forces", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 3);
            label3.Name = "label3";
            label3.Size = new Size(169, 26);
            label3.TabIndex = 1;
            label3.Text = "YOUTUBE DOWNLOADER";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(406, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(32, 32);
            panel3.TabIndex = 1;
            panel3.Click += panel3_Click;
            panel3.MouseEnter += panel3_MouseEnter;
            panel3.MouseLeave += panel3_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Motley Forces", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 7);
            label2.Name = "label2";
            label2.Size = new Size(16, 19);
            label2.TabIndex = 1;
            label2.Text = "_";
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(438, 0);
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
            panel4.Controls.Add(lblVersion);
            panel4.Controls.Add(lblAbout);
            panel4.Controls.Add(groupBox2);
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(btnStart);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(tbUrl);
            panel4.Location = new Point(3, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(464, 443);
            panel4.TabIndex = 1;
            // 
            // lblVersion
            // 
            lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersion.ForeColor = Color.White;
            lblVersion.Location = new Point(396, 427);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(53, 9);
            lblVersion.TabIndex = 11;
            lblVersion.Text = "Version : 1.0.0";
            // 
            // lblAbout
            // 
            lblAbout.AutoSize = true;
            lblAbout.Cursor = Cursors.Hand;
            lblAbout.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblAbout.ForeColor = Color.White;
            lblAbout.Location = new Point(158, 423);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(149, 13);
            lblAbout.TabIndex = 11;
            lblAbout.Text = "Created with ❤️ by WetDream";
            lblAbout.TextAlign = ContentAlignment.MiddleCenter;
            lblAbout.Click += lblAbout_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(pThumbnail);
            groupBox2.Controls.Add(loadingDownload);
            groupBox2.Controls.Add(lblPercent);
            groupBox2.Controls.Add(lblStatus);
            groupBox2.Controls.Add(lblSize);
            groupBox2.Controls.Add(lblLength);
            groupBox2.Controls.Add(lblTitle);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(pbThumbnail);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(19, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(426, 167);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Video Details";
            // 
            // pThumbnail
            // 
            pThumbnail.BackColor = Color.SlateBlue;
            pThumbnail.Controls.Add(label17);
            pThumbnail.Location = new Point(15, 22);
            pThumbnail.Name = "pThumbnail";
            pThumbnail.Size = new Size(121, 86);
            pThumbnail.TabIndex = 21;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Motley Forces", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(9, 21);
            label17.Name = "label17";
            label17.Size = new Size(103, 44);
            label17.TabIndex = 22;
            label17.Text = "FAILED\r\nGET THUMBNAIL";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loadingDownload
            // 
            loadingDownload.Location = new Point(15, 128);
            loadingDownload.Name = "loadingDownload";
            loadingDownload.Size = new Size(369, 12);
            loadingDownload.TabIndex = 18;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPercent.ForeColor = Color.White;
            lblPercent.Location = new Point(390, 127);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(21, 13);
            lblPercent.TabIndex = 19;
            lblPercent.Text = "0%";
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Bottom;
            lblStatus.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(3, 133);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(420, 31);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status : Idle...";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSize.ForeColor = Color.White;
            lblSize.Location = new Point(199, 82);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(11, 15);
            lblSize.TabIndex = 17;
            lblSize.Text = "-";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblLength.ForeColor = Color.White;
            lblLength.Location = new Point(199, 67);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(11, 15);
            lblLength.TabIndex = 16;
            lblLength.Text = "-";
            // 
            // lblTitle
            // 
            lblTitle.AutoEllipsis = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(199, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(219, 36);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(142, 82);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 13;
            label11.Text = "Size :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(142, 67);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 12;
            label10.Text = "Length :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(142, 31);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 11;
            label9.Text = "Title :";
            // 
            // pbThumbnail
            // 
            pbThumbnail.Location = new Point(15, 22);
            pbThumbnail.Name = "pbThumbnail";
            pbThumbnail.Size = new Size(121, 86);
            pbThumbnail.SizeMode = PictureBoxSizeMode.Zoom;
            pbThumbnail.TabIndex = 0;
            pbThumbnail.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(panel5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(19, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 116);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Configuration";
            // 
            // panel5
            // 
            panel5.Controls.Add(cbAudioOnly);
            panel5.Controls.Add(btnDownload);
            panel5.Controls.Add(btnBrowse);
            panel5.Controls.Add(tbPathFolder);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(tbTitle);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(8, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(410, 85);
            panel5.TabIndex = 0;
            // 
            // cbAudioOnly
            // 
            cbAudioOnly.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbAudioOnly.AutoSize = true;
            cbAudioOnly.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            cbAudioOnly.Location = new Point(252, 61);
            cbAudioOnly.Name = "cbAudioOnly";
            cbAudioOnly.Size = new Size(77, 17);
            cbAudioOnly.TabIndex = 10;
            cbAudioOnly.Text = "Audio Only";
            cbAudioOnly.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDownload.BackColor = Color.SlateBlue;
            btnDownload.Enabled = false;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(335, 57);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 9;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.BackColor = Color.SlateBlue;
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(335, 28);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // tbPathFolder
            // 
            tbPathFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPathFolder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbPathFolder.Location = new Point(62, 29);
            tbPathFolder.Name = "tbPathFolder";
            tbPathFolder.ReadOnly = true;
            tbPathFolder.Size = new Size(267, 21);
            tbPathFolder.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 31);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 7;
            label6.Text = "Save to :";
            // 
            // tbTitle
            // 
            tbTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbTitle.BorderStyle = BorderStyle.FixedSingle;
            tbTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitle.Location = new Point(62, 0);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(348, 21);
            tbTitle.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 2);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 6;
            label5.Text = "Title :";
            // 
            // btnStart
            // 
            btnStart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnStart.BackColor = Color.SlateBlue;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(370, 66);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 39);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 1;
            label4.Text = "Youtube Link :";
            // 
            // tbUrl
            // 
            tbUrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbUrl.BorderStyle = BorderStyle.FixedSingle;
            tbUrl.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbUrl.Location = new Point(109, 37);
            tbUrl.Name = "tbUrl";
            tbUrl.Size = new Size(336, 21);
            tbUrl.TabIndex = 0;
            tbUrl.TextChanged += tbUrl_TextChanged;
            // 
            // tpAbout
            // 
            tpAbout.BackColor = Color.SlateBlue;
            tpAbout.ForeColor = Color.White;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(470, 465);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureIconYT).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureProgress).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            pThumbnail.ResumeLayout(false);
            pThumbnail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbThumbnail).EndInit();
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Label label2;
        private Label label1;
        private PictureBox pictureIconYT;
        private Label label3;
        private Label label4;
        private TextBox tbUrl;
        private Button btnStart;
        private GroupBox groupBox2;
        private PictureBox pictureProgress;
        private Label lblAbout;
        private Label lblVersion;
        private Label lblSize;
        private Label lblLength;
        private Label lblTitle;
        private Label label11;
        private Label label10;
        private Label label9;
        private PictureBox pbThumbnail;
        private ProgressBar loadingDownload;
        private Label lblStatus;
        private Label lblPercent;
        private GroupBox groupBox1;
        private Panel panel5;
        private CheckBox cbAudioOnly;
        private Button btnDownload;
        private Button btnBrowse;
        private TextBox tbPathFolder;
        private Label label6;
        private TextBox tbTitle;
        private Label label5;
        private Panel pThumbnail;
        private Label label17;
        private ToolTip tpAbout;
    }
}