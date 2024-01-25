namespace ay
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAyDir = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAyConfig = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFF = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblBPVersion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUpdatesA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ay Directory:";
            // 
            // lblAyDir
            // 
            this.lblAyDir.AutoSize = true;
            this.lblAyDir.Location = new System.Drawing.Point(156, 49);
            this.lblAyDir.Name = "lblAyDir";
            this.lblAyDir.Size = new System.Drawing.Size(50, 15);
            this.lblAyDir.TabIndex = 3;
            this.lblAyDir.Text = "ay.value";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(320, 293);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Update";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ay Settings:";
            // 
            // lblAyConfig
            // 
            this.lblAyConfig.AutoSize = true;
            this.lblAyConfig.Location = new System.Drawing.Point(156, 75);
            this.lblAyConfig.Name = "lblAyConfig";
            this.lblAyConfig.Size = new System.Drawing.Size(56, 15);
            this.lblAyConfig.TabIndex = 8;
            this.lblAyConfig.Text = "ay.config";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Firefox:";
            // 
            // lblFF
            // 
            this.lblFF.AutoSize = true;
            this.lblFF.Location = new System.Drawing.Point(156, 103);
            this.lblFF.Name = "lblFF";
            this.lblFF.Size = new System.Drawing.Size(32, 15);
            this.lblFF.TabIndex = 10;
            this.lblFF.Text = "lblFF";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(25, 293);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Wipe ay";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblBPVersion
            // 
            this.lblBPVersion.AutoSize = true;
            this.lblBPVersion.Location = new System.Drawing.Point(156, 127);
            this.lblBPVersion.Name = "lblBPVersion";
            this.lblBPVersion.Size = new System.Drawing.Size(62, 15);
            this.lblBPVersion.TabIndex = 12;
            this.lblBPVersion.Text = "bp.version";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "BP Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Updates Available:";
            // 
            // lblUpdatesA
            // 
            this.lblUpdatesA.AutoSize = true;
            this.lblUpdatesA.Location = new System.Drawing.Point(154, 263);
            this.lblUpdatesA.Name = "lblUpdatesA";
            this.lblUpdatesA.Size = new System.Drawing.Size(51, 15);
            this.lblUpdatesA.TabIndex = 15;
            this.lblUpdatesA.Text = "Yes / No";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 337);
            this.Controls.Add(this.lblUpdatesA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBPVersion);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblFF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAyConfig);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblAyDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ay Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label lblAyDir;
        private Button btnReload;
        private Label label4;
        private Label lblAyConfig;
        private Label label5;
        private Label lblFF;
        private Button btnDelete;
        private Label lblBPVersion;
        private Label label6;
        private Label label3;
        private Label lblUpdatesA;
    }
}