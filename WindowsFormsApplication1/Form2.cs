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

namespace HostedNetworkForm
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 sender)
        {
            form1 = sender;
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            form1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if ((this.textBoxSSID.Text != String.Empty) && (this.textBoxKey.Text.Length > 7))
            {
                form1.execNetSh("wlan set hostednetwork mode=allow  ssid=" + this.textBoxSSID.Text + " key=" + this.textBoxKey.Text + " keyUsage=persistent", 5000);
                form1.updateLabel1();
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

        private void button2_Click(object sender, EventArgs e)
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
    }
}
