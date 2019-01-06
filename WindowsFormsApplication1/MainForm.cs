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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            updateLabel1();
        }

        protected override void OnClosed(EventArgs e)
        {
            foreach (var prc in Process.GetProcessesByName("netsh"))
            {
                prc.Kill();
            }
        }

        private void hostedNetworkOn_Click(object sender, EventArgs e)
        {
            onButtonClick();
            execNetShWlan("start hostednetwork");
            updateLabel1();
            postButtonClick();
        }

        private void hostedNetworkOff_Click(object sender, EventArgs e)
        {
            onButtonClick();
            execNetShWlan("stop hostednetwork");
            updateLabel1();
            postButtonClick();
        }

        public string execNetShWlan(string strCmdText) 
        {
            Process proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = Environment.SystemDirectory,
                    FileName = Environment.SystemDirectory + "\\netsh.exe",
                    UseShellExecute = false,
                    RedirectStandardInput = true,
                    StandardOutputEncoding = Encoding.GetEncoding("CP866"),
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    Arguments = ""
                    
                }
            };

            proc.Start();
            var pWriter = proc.StandardInput;
            pWriter.WriteLine("wlan " + strCmdText);
            pWriter.WriteLine("exit");

            var output = proc.StandardOutput.ReadToEnd();
            proc.Dispose();

            return output;
        }

        public void updateLabel1()
        {
            label1.Text = execNetShWlan("show hostednetwork");
        }

        private void SetHostedNetwork_Click(object sender, EventArgs e)
        {
            SettingsForm newForm = new SettingsForm(this);
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
