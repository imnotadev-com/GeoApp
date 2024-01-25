using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net;
using System.Collections;

namespace ay
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm settingsForm = new mainForm();
            settingsForm.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            requirements.validate(lblAyDir, lblAyConfig, lblFF, lblBPVersion, lblUpdatesA);
            methods.checkForUpdates(lblUpdatesA);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
                    
            requirements.preReqs();
            methods.checkForUpdates(lblUpdatesA);
            requirements.validate(lblAyDir, lblAyConfig, lblFF, lblBPVersion, lblUpdatesA);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            methods.delObj(globals.ayDir);
            requirements.validate(lblAyDir, lblAyConfig, lblFF, lblBPVersion, lblUpdatesA);
        }



    }
}
