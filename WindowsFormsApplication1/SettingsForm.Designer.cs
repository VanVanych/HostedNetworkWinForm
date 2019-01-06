namespace HostedNetworkForm
{
    public partial class SettingsForm
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
            this.SettingsOK = new System.Windows.Forms.Button();
            this.SettingsCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSSID = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.AllowBtn = new System.Windows.Forms.Button();
            this.DisallowBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SettingsOK
            // 
            this.SettingsOK.Location = new System.Drawing.Point(15, 117);
            this.SettingsOK.Name = "SettingsOK";
            this.SettingsOK.Size = new System.Drawing.Size(96, 23);
            this.SettingsOK.TabIndex = 0;
            this.SettingsOK.Text = "OK";
            this.SettingsOK.UseVisualStyleBackColor = true;
            this.SettingsOK.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // SettingsCancel
            // 
            this.SettingsCancel.Location = new System.Drawing.Point(151, 117);
            this.SettingsCancel.Name = "SettingsCancel";
            this.SettingsCancel.Size = new System.Drawing.Size(92, 23);
            this.SettingsCancel.TabIndex = 1;
            this.SettingsCancel.Text = "Cancel";
            this.SettingsCancel.UseVisualStyleBackColor = true;
            this.SettingsCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SSID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key";
            // 
            // textBoxSSID
            // 
            this.textBoxSSID.Location = new System.Drawing.Point(50, 45);
            this.textBoxSSID.Name = "textBoxSSID";
            this.textBoxSSID.Size = new System.Drawing.Size(193, 20);
            this.textBoxSSID.TabIndex = 5;
            this.textBoxSSID.TextChanged += new System.EventHandler(this.textBoxSSID_TextChanged);
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(50, 82);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(193, 20);
            this.textBoxKey.TabIndex = 6;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // AllowBtn
            // 
            this.AllowBtn.Location = new System.Drawing.Point(15, 12);
            this.AllowBtn.Name = "AllowBtn";
            this.AllowBtn.Size = new System.Drawing.Size(96, 23);
            this.AllowBtn.TabIndex = 7;
            this.AllowBtn.Text = "Allow";
            this.AllowBtn.UseVisualStyleBackColor = true;
            this.AllowBtn.Click += new System.EventHandler(this.AllowBtn_Click);
            // 
            // DisallowBtn
            // 
            this.DisallowBtn.Location = new System.Drawing.Point(151, 12);
            this.DisallowBtn.Name = "DisallowBtn";
            this.DisallowBtn.Size = new System.Drawing.Size(92, 23);
            this.DisallowBtn.TabIndex = 8;
            this.DisallowBtn.Text = "Disallow";
            this.DisallowBtn.UseVisualStyleBackColor = true;
            this.DisallowBtn.Click += new System.EventHandler(this.DisallowBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 152);
            this.Controls.Add(this.DisallowBtn);
            this.Controls.Add(this.AllowBtn);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxSSID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingsCancel);
            this.Controls.Add(this.SettingsOK);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingsOK;
        private System.Windows.Forms.Button SettingsCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSSID;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Button AllowBtn;
        private System.Windows.Forms.Button DisallowBtn;
    }
}