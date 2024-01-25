namespace ay
{
    partial class mainForm
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblCurrentIPValue = new System.Windows.Forms.Label();
            this.lblCurrentIP = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.lblTimeZone = new System.Windows.Forms.Label();
            this.lblTimeZoneValue = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblLanguageValue = new System.Windows.Forms.Label();
            this.textBoxGPS = new System.Windows.Forms.TextBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCountryValue = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblLong = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblHPValue = new System.Windows.Forms.Label();
            this.lblPortValue = new System.Windows.Forms.Label();
            this.lblLongValue = new System.Windows.Forms.Label();
            this.lblLatValue = new System.Windows.Forms.Label();
            this.comboBoxBP = new System.Windows.Forms.ComboBox();
            this.lblUAS = new System.Windows.Forms.Label();
            this.lbltmp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblUASvalue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(319, 292);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblCurrentIPValue
            // 
            this.lblCurrentIPValue.AutoSize = true;
            this.lblCurrentIPValue.Location = new System.Drawing.Point(153, 203);
            this.lblCurrentIPValue.Name = "lblCurrentIPValue";
            this.lblCurrentIPValue.Size = new System.Drawing.Size(40, 15);
            this.lblCurrentIPValue.TabIndex = 2;
            this.lblCurrentIPValue.Text = "x.x.x.x";
            // 
            // lblCurrentIP
            // 
            this.lblCurrentIP.AutoSize = true;
            this.lblCurrentIP.Location = new System.Drawing.Point(27, 203);
            this.lblCurrentIP.Name = "lblCurrentIP";
            this.lblCurrentIP.Size = new System.Drawing.Size(65, 15);
            this.lblCurrentIP.TabIndex = 3;
            this.lblCurrentIP.Text = "IP Address:";
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(29, 292);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 4;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // lblTimeZone
            // 
            this.lblTimeZone.AutoSize = true;
            this.lblTimeZone.Location = new System.Drawing.Point(27, 142);
            this.lblTimeZone.Name = "lblTimeZone";
            this.lblTimeZone.Size = new System.Drawing.Size(66, 15);
            this.lblTimeZone.TabIndex = 5;
            this.lblTimeZone.Text = "Time Zone:";
            // 
            // lblTimeZoneValue
            // 
            this.lblTimeZoneValue.AutoSize = true;
            this.lblTimeZoneValue.Location = new System.Drawing.Point(153, 142);
            this.lblTimeZoneValue.Name = "lblTimeZoneValue";
            this.lblTimeZoneValue.Size = new System.Drawing.Size(59, 15);
            this.lblTimeZoneValue.TabIndex = 6;
            this.lblTimeZoneValue.Text = "time zone";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(411, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(27, 171);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(62, 15);
            this.lblLanguage.TabIndex = 9;
            this.lblLanguage.Text = "Language:";
            // 
            // lblLanguageValue
            // 
            this.lblLanguageValue.AutoSize = true;
            this.lblLanguageValue.Location = new System.Drawing.Point(153, 171);
            this.lblLanguageValue.Name = "lblLanguageValue";
            this.lblLanguageValue.Size = new System.Drawing.Size(56, 15);
            this.lblLanguageValue.TabIndex = 10;
            this.lblLanguageValue.Text = "language";
            // 
            // textBoxGPS
            // 
            this.textBoxGPS.Location = new System.Drawing.Point(28, 79);
            this.textBoxGPS.Name = "textBoxGPS";
            this.textBoxGPS.Size = new System.Drawing.Size(366, 23);
            this.textBoxGPS.TabIndex = 11;
            this.textBoxGPS.Text = "Update GPS (lat,lon), eg: 51.5287718,-0.2416802, (Optional)";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.AutoCompleteCustomSource.AddRange(new string[] {
            "spain",
            "france",
            "united kingdom"});
            this.comboBoxCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(29, 21);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(457, 23);
            this.comboBoxCountry.TabIndex = 12;
            this.comboBoxCountry.Text = "Select Country";
            this.comboBoxCountry.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountry_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(27, 113);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(100, 15);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "Selected Country:";
            // 
            // lblCountryValue
            // 
            this.lblCountryValue.AutoSize = true;
            this.lblCountryValue.Location = new System.Drawing.Point(153, 113);
            this.lblCountryValue.Name = "lblCountryValue";
            this.lblCountryValue.Size = new System.Drawing.Size(63, 15);
            this.lblCountryValue.TabIndex = 14;
            this.lblCountryValue.Text = "lblCountry";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(271, 115);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(72, 15);
            this.lblHP.TabIndex = 15;
            this.lblHP.Text = "Home Page:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(271, 145);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(65, 15);
            this.lblPort.TabIndex = 16;
            this.lblPort.Text = "Proxy Port:";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Location = new System.Drawing.Point(271, 203);
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(64, 15);
            this.lblLong.TabIndex = 17;
            this.lblLong.Text = "Longitude:";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(271, 171);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(53, 15);
            this.lblLat.TabIndex = 18;
            this.lblLat.Text = "Latitude:";
            // 
            // lblHPValue
            // 
            this.lblHPValue.AutoSize = true;
            this.lblHPValue.Location = new System.Drawing.Point(372, 115);
            this.lblHPValue.Name = "lblHPValue";
            this.lblHPValue.Size = new System.Drawing.Size(101, 15);
            this.lblHPValue.TabIndex = 19;
            this.lblHPValue.Text = "www.google.com";
            // 
            // lblPortValue
            // 
            this.lblPortValue.AutoSize = true;
            this.lblPortValue.Location = new System.Drawing.Point(372, 145);
            this.lblPortValue.Name = "lblPortValue";
            this.lblPortValue.Size = new System.Drawing.Size(31, 15);
            this.lblPortValue.TabIndex = 20;
            this.lblPortValue.Text = "1234";
            // 
            // lblLongValue
            // 
            this.lblLongValue.AutoSize = true;
            this.lblLongValue.Location = new System.Drawing.Point(372, 203);
            this.lblLongValue.Name = "lblLongValue";
            this.lblLongValue.Size = new System.Drawing.Size(47, 15);
            this.lblLongValue.TabIndex = 21;
            this.lblLongValue.Text = "lblLong";
            // 
            // lblLatValue
            // 
            this.lblLatValue.AutoSize = true;
            this.lblLatValue.Location = new System.Drawing.Point(372, 171);
            this.lblLatValue.Name = "lblLatValue";
            this.lblLatValue.Size = new System.Drawing.Size(36, 15);
            this.lblLatValue.TabIndex = 22;
            this.lblLatValue.Text = "lblLat";
            // 
            // comboBoxBP
            // 
            this.comboBoxBP.FormattingEnabled = true;
            this.comboBoxBP.Location = new System.Drawing.Point(28, 50);
            this.comboBoxBP.Name = "comboBoxBP";
            this.comboBoxBP.Size = new System.Drawing.Size(457, 23);
            this.comboBoxBP.TabIndex = 23;
            this.comboBoxBP.Text = "Select Browser Profile";
            this.comboBoxBP.SelectedIndexChanged += new System.EventHandler(this.comboBoxBP_SelectedIndexChanged);
            // 
            // lblUAS
            // 
            this.lblUAS.AutoSize = true;
            this.lblUAS.Location = new System.Drawing.Point(29, 230);
            this.lblUAS.Name = "lblUAS";
            this.lblUAS.Size = new System.Drawing.Size(102, 15);
            this.lblUAS.TabIndex = 24;
            this.lblUAS.Text = "User Agent String:";
            // 
            // lbltmp
            // 
            this.lbltmp.AutoSize = true;
            this.lbltmp.Location = new System.Drawing.Point(106, 282);
            this.lbltmp.Name = "lbltmp";
            this.lbltmp.Size = new System.Drawing.Size(0, 15);
            this.lbltmp.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblUASvalue
            // 
            this.lblUASvalue.AutoSize = true;
            this.lblUASvalue.Location = new System.Drawing.Point(153, 230);
            this.lblUASvalue.Name = "lblUASvalue";
            this.lblUASvalue.Size = new System.Drawing.Size(87, 15);
            this.lblUASvalue.TabIndex = 28;
            this.lblUASvalue.Text = "Select a device.";
            this.lblUASvalue.Click += new System.EventHandler(this.lblUASvalue_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblUASvalue);
            this.Controls.Add(this.lbltmp);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblUAS);
            this.Controls.Add(this.comboBoxBP);
            this.Controls.Add(this.lblLatValue);
            this.Controls.Add(this.lblLongValue);
            this.Controls.Add(this.lblPortValue);
            this.Controls.Add(this.lblHPValue);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.lblLong);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.lblCountryValue);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.textBoxGPS);
            this.Controls.Add(this.lblLanguageValue);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTimeZoneValue);
            this.Controls.Add(this.lblTimeZone);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.lblCurrentIP);
            this.Controls.Add(this.lblCurrentIPValue);
            this.Controls.Add(this.btnSettings);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSettings;
        private Label lblCurrentIPValue;
        private Label lblCurrentIP;
        private Button btnLaunch;
        private Label lblTimeZone;
        private Label lblTimeZoneValue;
        private Button btnExit;
        private Label lblLanguage;
        private Label lblLanguageValue;
        private TextBox textBoxGPS;
        private ComboBox comboBoxCountry;
        private Label lblCountry;
        private Label lblCountryValue;
        private Label lblHP;
        private Label lblPort;
        private Label lblLong;
        private Label lblLat;
        private Label lblHPValue;
        private Label lblPortValue;
        private Label lblLongValue;
        private Label lblLatValue;
        private ComboBox comboBoxBP;
        private Label lblUAS;
        private Label lbltmp;
        private Button button1;
        private Label lblUASvalue;
    }
}