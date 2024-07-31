using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace YoutubeDownloader
{
    public partial class Form2 : Form
    {
        private string currentVersion = "1.0.1";
        private string pastebinUrl = "https://pastebin.com/raw/N9mWUyzm";

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Transparent;
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            string latestVersion = await GetLatestVersionFromPastebin();

            if (latestVersion == null)
            {
                lblStatus.Text = "Check update failed";
                return;
            }

            if (IsUpdateAvailable(currentVersion, latestVersion))
            {
                lblStatus.Text = "Click here to update";
            }
            else
            {
                lblStatus.Text = "Latest Version";
            }
        }

        private async Task<string> GetLatestVersionFromPastebin()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(pastebinUrl);
                    response.EnsureSuccessStatusCode();

                    string latestVersion = await response.Content.ReadAsStringAsync();
                    return latestVersion.Trim();
                }
                catch (Exception ex)
                {
                    //Debug
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private bool IsUpdateAvailable(string currentVersion, string latestVersion)
        {
            Version current = new Version(currentVersion);
            Version latest = new Version(latestVersion);

            return latest > current;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            if (lblStatus.Text == "Click here to update")
            {
                Process p = new Process();
                p.StartInfo.FileName = "Updater.exe";
                p.Start();
                Application.Exit();
            }
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://github.com/wetdream-dev/YoutubeDownloader") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo("https://t.me/itsWetdream") { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
