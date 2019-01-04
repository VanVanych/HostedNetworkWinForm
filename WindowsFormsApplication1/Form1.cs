using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;


namespace HostedNetworkForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateLabel1();
        }

        private void hostedNetworkOn_Click(object sender, EventArgs e)
        {
            onButtonClick();
            execNetSh("wlan start hostednetwork", 0);
            updateLabel1();
            postButtonClick();
        }

        private void hostedNetworkOff_Click(object sender, EventArgs e)
        {
            onButtonClick();
            execNetSh("wlan stop hostednetwork", 0);
            updateLabel1();
            postButtonClick();
        }

        public string execNetSh(string strCmdText, int sleep) 
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = @"C:\Windows\System32",
                    FileName = @"C:\Windows\System32\netsh.exe",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    StandardOutputEncoding = Encoding.ASCII,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = ""
                    
                }
            };

            proc.Start();
            var pWriter = proc.StandardInput;
            pWriter.WriteLine(strCmdText);

            var output = proc.StandardOutput;
            if (sleep > 0)
            {
                Thread.Sleep(sleep);
                proc.Kill();
                string result = output.ReadToEnd();

                return result;
            }
            return string.Empty;
        }

        public void updateLabel1()
        {
            int slp = 2000;
            label1.Text = execNetSh("wlan show hostednetwork", slp);
            

            while (!(label1.Text.EndsWith("netsh>")&&label1.Text.Length>14))//Equals(string.Empty)) 
            {
                slp = slp + 2000;
                label1.Text = execNetSh("wlan show hostednetwork", slp);
            }
        }

        private void SetHostedNetwork_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
            this.Enabled = false;
        }

        private void onButtonClick()
        {
            this.Enabled = false;
        }

        private void postButtonClick()
        {
            this.Enabled = true;
        }
    }
}
