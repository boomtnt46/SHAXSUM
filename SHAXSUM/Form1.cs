using System;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;

namespace SHAXSUM
{
    public partial class SHAXSUM : Form
    {
        public SHAXSUM()
        {
            InitializeComponent();
            this.Text +=  " "+ProductVersion;
        }

        public Stream file;
        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                file = ofd.OpenFile();
            }
        }

        private void checkSHA1Button_Click(object sender, EventArgs e)
        {
            SHA1 sha1 = SHA1.Create();
            string fileHash = BitConverter.ToString(sha1.ComputeHash(file)).Replace("-", String.Empty).ToLower();

            if (sha1TextBox.Text == fileHash)
            {
                sha1Result.ForeColor = Color.LightGreen;
                sha1Result.Text = "MATCH!";
            }
            else
            {
                sha1Result.ForeColor = Color.Red;
                sha1Result.Text = "ERROR!";
                MessageBox.Show(fileHash + " vs " + sha1TextBox.Text);
            }
        }

        private void checkSHA256Button_Click(object sender, EventArgs e)
        {
            SHA256 sha256 = SHA256.Create();
            string fileHash = BitConverter.ToString(sha256.ComputeHash(file)).Replace("-", String.Empty).ToLower();

            if (sha256TextBox.Text == fileHash)
            {
                sha256Result.ForeColor = Color.LightGreen;
                sha256Result.Text = "MATCH!";
            }
            else
            {
                sha256Result.ForeColor = Color.Red;
                sha256Result.Text = "ERROR!";
                MessageBox.Show(fileHash + " vs " + sha256TextBox.Text);
            }
        }
    }
}
