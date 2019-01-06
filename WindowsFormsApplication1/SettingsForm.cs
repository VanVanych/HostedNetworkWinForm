using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.IO;

namespace HostedNetworkForm
{
    public partial class SettingsForm : Form
    {
        private MainForm mainForm;
        
        public SettingsForm(MainForm sender)
        {
            mainForm = sender;
            InitializeComponent();
            if (File.Exists("HostedNetworkForm.settings"))
            {
                StreamReader reader = new StreamReader(Environment.CurrentDirectory + "\\HostedNetworkForm.settings");
                var line = reader.ReadLine();
                if (line != null) textBoxSSID.Text = line;
                line = reader.ReadLine();
                if (line != null) textBoxKey.Text = line;
                reader.Close();
            }
            else
            {
                File.Create("HostedNetworkForm.settings");
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            mainForm.Enabled = true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if ((this.textBoxSSID.Text != String.Empty) && (this.textBoxKey.Text.Length > 7))
            {
                mainForm.execNetShWlan("set hostednetwork ssid=" + this.textBoxSSID.Text + " key=" + this.textBoxKey.Text + " keyUsage=persistent");

                //write settings to file
                File.WriteAllText("HostedNetworkForm.settings", string.Empty);
                var writer = new StreamWriter(Environment.CurrentDirectory + "\\HostedNetworkForm.settings");
                writer.WriteLine(textBoxSSID.Text);
                writer.WriteLine(textBoxKey.Text);
                writer.Close();


                mainForm.updateLabel1();
                this.Close();
            }
            else 
            {
                if (this.textBoxSSID.Text == String.Empty) 
                {
                    MessageBox.Show(
                    "Please, set SSID",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }

                if (this.textBoxSSID.Text == String.Empty)
                {
                    MessageBox.Show(
                    "Please, set key",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }

                if (this.textBoxSSID.Text.Length < 8)
                {
                    MessageBox.Show(
                    "Key length must be more than 8 characters",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            this.Enabled = true;
        }

        private void Filter_TextChanged(object sender, EventArgs e)
        {
            var textboxSender = (TextBox)sender;
            var cursorPosition = textboxSender.SelectionStart;
            textboxSender.Text = Regex.Replace(textboxSender.Text, "[^0-9a-zA-Z ]", "");
            textboxSender.SelectionStart = cursorPosition;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSSID_TextChanged(object sender, EventArgs e)
        {
            Filter_TextChanged(sender, e);
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            Filter_TextChanged(sender, e);
        }

        private void AllowBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            mainForm.execNetShWlan("set hostednetwork mode=allow");
            mainForm.updateLabel1();
            this.Enabled = true;
        }

        private void DisallowBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            mainForm.execNetShWlan("set hostednetwork mode=disallow");
            mainForm.updateLabel1();
            this.Enabled = true;
        }
    }
}
