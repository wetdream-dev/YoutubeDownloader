using NAudio.Lame;
using NAudio.Wave;
using System.Text.RegularExpressions;
using YoutubeDownloader.Properties;
using YoutubeExplode;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        private readonly YoutubeClient youtube;

        public Form1()
        {
            InitializeComponent();
            youtube = new YoutubeClient();
            tpAbout.SetToolTip(lblAbout, "About this application.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Gray;
            panel3.BackColor = Color.Lavender;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
            panel3.BackColor = Color.Transparent;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
            panel3.BackColor = Color.Transparent;
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
            panel3.BackColor = Color.Transparent;
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            pictureIconYT.Visible = false;
            try
            {
                lblStatus.Text = "Status: Fetching video info...";
                var url = tbUrl.Text.Trim();
                if (string.IsNullOrEmpty(url))
                {
                    MessageBox.Show("Please enter a vaild Youtube URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Text = "Status: Youtube URl not valid.";
                    pictureIconYT.Visible = true;
                    return;
                }

                var videoId = VideoId.Parse(url);
                var video = await youtube.Videos.GetAsync(videoId);
                var thumbnail = video.Thumbnails.GetWithHighestResolution();

                lblTitle.Text = $"{video.Title}";
                
                lblTitle.Tag = video;
                lblLength.Text = $"{video.Duration}";
                pictureIconYT.Visible = true;
                lblStatus.Text = "Status: Ready to download";
                btnDownload.Enabled = true;
                btnStart.Enabled = false;

                string inputText = lblTitle.Text;
                string cleanedText = RemoveSpecialCharacter(inputText);
                tbTitle.Text = cleanedText;
                //pbThumbnail.Image = (Image)video.Thumbnails;
                //pThumbnail.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Failed";
                pictureIconYT.Visible = false;
                btnStart.Enabled = true;
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            pictureIconYT.Visible = false;
            btnDownload.Enabled = false;
            string url = tbUrl.Text.Trim();
            lblStatus.Text = "Status: Prepairing to download...";
            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("Please enter a valid YouTube URL.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Youtube URl not valid.";
                btnDownload.Enabled = true;
                pictureIconYT.Visible = true;
                return;
            }

            if (tbPathFolder.Text == "")
            {
                MessageBox.Show("Please choose path folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Unable to find path folder.";
                btnDownload.Enabled = true;
                pictureIconYT.Visible = true;
                return;
            }

            loadingDownload.Value = 0;


            try
            {
                var video = await youtube.Videos.GetAsync(url);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                if (cbAudioOnly.Checked)
                {
                    await DownloadAudioAsync(video, streamManifest);
                }
                else
                {
                    await DownloadVideoAsync(video, streamManifest);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Failed";
                pictureIconYT.Visible = true;
                btnDownload.Enabled = true;
            }
        }

        private async Task DownloadVideoAsync(YoutubeExplode.Videos.Video video, StreamManifest streamMainfest)
        {
            // Mendapatkan stream video dengan resolusi tertinggi
            var streamInfo = streamMainfest.GetMuxedStreams().GetWithHighestVideoQuality();
            if (streamInfo == null)
            {
                MessageBox.Show("No suitable video stream found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Failed";
                pictureIconYT.Visible = true;
                return;
            }

            string filePath = Path.Combine(tbPathFolder.Text, $"{tbTitle.Text}.mp4");

            // Mengunduh video
            lblStatus.Text = "Status: Downloading...";
            pictureIconYT.Visible = false;
            await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath, new Progress<double>(p =>
            {
                loadingDownload.Value = (int)(p * 100);
                lblPercent.Text = $"{loadingDownload.Value}%";
            }));

            lblStatus.Text = "Status: Download complete";
            loadingDownload.Value = 100;

            MessageBox.Show("Video downloaded successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnDownload.Enabled = false;
            pictureIconYT.Visible = true;
            btnStart.Enabled = true;
        }

        private async Task DownloadAudioAsync(YoutubeExplode.Videos.Video video, StreamManifest streamManifest)
        {
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestBitrate();
            if (streamInfo == null)
            {
                MessageBox.Show("No suitable audio stream found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Status: Failed";

                pictureIconYT.Visible = true;
                return;
            }

            string tempPath = Path.Combine(Path.GetTempPath(), $"{tbTitle.Text}.mp4");
            string outputFilePath = Path.Combine(tbPathFolder.Text, $"{tbTitle.Text}.mp3");

            lblStatus.Text = "Status: Downloading...";

            pictureIconYT.Visible = false;
            await youtube.Videos.Streams.DownloadAsync(streamInfo, tempPath, new Progress<double>(p =>
            {
                loadingDownload.Value = (int)(p * 100);
                lblPercent.Text = $"{loadingDownload.Value}%";
            }));

            lblStatus.Text = "Status: Converting to MP3...";
            loadingDownload.Value = 0;

            //Mengkonversi file audio ke MP3
            await Task.Run(() => ConvertToMP3(tempPath, outputFilePath));

            File.Delete(tempPath);
            lblStatus.Text = "Status: Download complete.";
            loadingDownload.Value = 100;
            MessageBox.Show("Audio downloaded successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pictureIconYT.Visible = true;
            btnStart.Enabled = true;
        }

        private void ConvertToMP3(string inputPath, string outputFilePath)
        {
            using (var reader = new MediaFoundationReader(inputPath))
            using (var writer = new LameMP3FileWriter(outputFilePath, reader.WaveFormat, 128))
            {
                //reader.CopyTo(writer);
                byte[] buffer = new byte[4096];
                int bytesRead;
                long totalBytesRead = 0;
                long totalLength = reader.Length;

                while ((bytesRead = reader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    writer.Write(buffer, 0, bytesRead);
                    totalBytesRead += bytesRead;
                    int progress = (int)((double)totalBytesRead / totalLength * 100);
                    loadingDownload.Invoke((MethodInvoker)delegate { loadingDownload.Value = progress; lblPercent.Text = $"{loadingDownload.Value}%"; });
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                bool flag = folderBrowserDialog.ShowDialog() == DialogResult.OK;
                if (flag)
                {
                    tbPathFolder.Text = folderBrowserDialog.SelectedPath;
                    Settings.Default.tbPathFolder = tbPathFolder.Text;
                    Settings.Default.Save();
                }
            }
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private async Task LoadThumbnailAsync(string thumbnailUrl)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var imageData = await client.GetByteArrayAsync(thumbnailUrl);
                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        pbThumbnail.Image = Image.FromStream(stream);
                        pThumbnail.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading thumbnail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Clear()
        {
            btnStart.Enabled = true;
            btnDownload.Enabled = false;
            pThumbnail.Visible = true;
            tbTitle.Text = "";
            lblStatus.Text = "Status: Idle...";
            lblLength.Text = "-";
            lblTitle.Text = "-";
            lblSize.Text = "-";
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbPathFolder.Text = Properties.Settings.Default.tbPathFolder;
        }

        private string RemoveSpecialCharacter(string text)
        {
            string[] specialCharacters = { "/", ":","*","?","|","<",">"};

            foreach (var character in specialCharacters)
            {
                text = text.Replace(character, "");
            }

            return text;
        }
    }
}