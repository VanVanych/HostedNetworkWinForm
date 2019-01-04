namespace HostedNetworkForm
{
    public partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.SetHostedNetwork = new System.Windows.Forms.Button();
            this.hostedNetworkOn = new System.Windows.Forms.Button();
            this.hostedNetworkOff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // SetHostedNetwork
            // 
            this.SetHostedNetwork.Location = new System.Drawing.Point(194, 27);
            this.SetHostedNetwork.Name = "SetHostedNetwork";
            this.SetHostedNetwork.Size = new System.Drawing.Size(142, 23);
            this.SetHostedNetwork.TabIndex = 1;
            this.SetHostedNetwork.Text = "Update Settings";
            this.SetHostedNetwork.UseVisualStyleBackColor = true;
            this.SetHostedNetwork.Click += new System.EventHandler(this.SetHostedNetwork_Click);
            // 
            // hostedNetworkOn
            // 
            this.hostedNetworkOn.BackColor = System.Drawing.SystemColors.Highlight;
            this.hostedNetworkOn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.hostedNetworkOn.Location = new System.Drawing.Point(15, 12);
            this.hostedNetworkOn.Name = "hostedNetworkOn";
            this.hostedNetworkOn.Size = new System.Drawing.Size(150, 23);
            this.hostedNetworkOn.TabIndex = 2;
            this.hostedNetworkOn.Text = "Start Hosted Network";
            this.hostedNetworkOn.UseVisualStyleBackColor = false;
            this.hostedNetworkOn.Click += new System.EventHandler(this.hostedNetworkOn_Click);
            // 
            // hostedNetworkOff
            // 
            this.hostedNetworkOff.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hostedNetworkOff.Location = new System.Drawing.Point(15, 41);
            this.hostedNetworkOff.Name = "hostedNetworkOff";
            this.hostedNetworkOff.Size = new System.Drawing.Size(150, 23);
            this.hostedNetworkOff.TabIndex = 3;
            this.hostedNetworkOff.Text = "Stop Hosted Network";
            this.hostedNetworkOff.UseVisualStyleBackColor = false;
            this.hostedNetworkOff.Click += new System.EventHandler(this.hostedNetworkOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 337);
            this.Controls.Add(this.hostedNetworkOff);
            this.Controls.Add(this.hostedNetworkOn);
            this.Controls.Add(this.SetHostedNetwork);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MyHostedNetwork";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetHostedNetwork;
        private System.Windows.Forms.Button hostedNetworkOn;
        private System.Windows.Forms.Button hostedNetworkOff;
    }
}

