using Microsoft.VisualBasic.Logging;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ay
{
    public partial class mainForm : Form
    {
        public string strProxy = "192.168.0.20";

        public mainForm()
        {
            InitializeComponent();

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 settingsForm = new Form2();
            settingsForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            launchBtn();

            // Populate the comboBoxCountry drop down
            if (System.IO.File.Exists(globals.ayLocationsList))
            {
                StreamReader sr1 = new StreamReader(globals.ayLocationsList);
                int lineNumber1 = 1;
                while (!sr1.EndOfStream)
                {
                    var eachRow = sr1.ReadLine();
                    var columns = eachRow.Split(',');

                    string strCountry = columns[0];
                    string strTimeZone = columns[1];
                    string strLanguage = columns[2];
                    string strHomePage = columns[3];
                    string strPort = columns[4];
                    string strLat = columns[5];
                    string strLong = columns[6];

                    if (lineNumber1 != 1)
                    {
                        comboBoxCountry.Items.Add(strCountry);
                    }
                    lineNumber1++;
                }
                sr1.Close();
            }
            //#####

            // Populate the BrowserProfile drop down
            if (System.IO.File.Exists(globals.ayBPList))
            {
                StreamReader sr1 = new StreamReader(globals.ayBPList);
                int lineNumber1 = 1;
                while (!sr1.EndOfStream)
                {
                    var eachRow = sr1.ReadLine();
                    var columns = eachRow.Split('|');

                    string strOS = columns[0];

                    if (lineNumber1 != 1)
                    {
                        comboBoxBP.Items.Add(strOS);
                    }

                    lineNumber1++;
                }
                sr1.Close();
            }
            //#####

            // Enable comboBoxBP if comboBoxCountry item is selected
            if (comboBoxCountry.SelectedItem == null)
            {
                comboBoxBP.Enabled = false;
            }
            else
            {
                comboBoxBP.Enabled = true;
            }
            //#####

            // Update default labels to "Not Set"
            checkProfile(lblCurrentIPValue);
            checkProfile(lblTimeZoneValue);
            checkProfile(lblLanguageValue);
            checkProfile(lblHPValue);
            checkProfile(lblLatValue);
            checkProfile(lblLongValue);
            checkProfile(lblPortValue);
            checkProfile(lblCountryValue);
            //#####
        }

        static void checkProfile(Label form1LBL)
        {
            form1LBL.ForeColor = System.Drawing.Color.Red;
            form1LBL.Text = "Not Set.";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            object selectedItem = comboBoxCountry.SelectedItem;
            string selectedProfile = Convert.ToString(selectedItem);

            if (System.IO.Directory.Exists(globals.ayDir + "\\Profiles\\" + selectedProfile))
            {
                Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe", @"-profile c:\ay\Profiles\" + selectedProfile);
            }
        }

        private void comboBoxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUASvalue.Text = null;

            if (System.IO.File.Exists(globals.ayLocationsList))
            {
                StreamReader sr1 = new StreamReader(globals.ayLocationsList);
                int lineNumber1 = 1;
                while (!sr1.EndOfStream)
                {
                    var eachRow = sr1.ReadLine();
                    var columns = eachRow.Split(',');

                    string strCountry = columns[0];
                    string strTimeZone = columns[1];
                    string strLanguage = columns[2];
                    string strHomePage = columns[3];
                    string strPort = columns[4];
                    string strLat = columns[5];
                    string strLong = columns[6];

                    if (comboBoxCountry.Text == strCountry)
                    {
                        methods.updateLabelG(lblCountryValue, strCountry);
                        methods.updateLabelG(lblTimeZoneValue, strTimeZone);
                        methods.updateLabelG(lblLanguageValue, strLanguage);
                        methods.updateLabelG(lblHPValue, strHomePage);
                        methods.updateLabelG(lblPortValue, strPort);
                        methods.updateLabelG(lblLongValue, strLat);
                        methods.updateLabelG(lblLatValue, strLong);

                        methods.createUserJS(strCountry, strHomePage, strTimeZone, strLanguage, strProxy, strPort, strLat, strLong);
                    }
                }

                sr1.Close();

            }
            comboBoxBP.Enabled = true;
            comboBoxBP.SelectedItem = null;
            comboBoxBP.Text = "Select Browser Profile";
        }


        private void comboBoxBP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strCountry = (string)comboBoxCountry.SelectedItem;

            launchBtn();

            StreamReader sr1 = new StreamReader(globals.ayBPList);
            int lineNumber1 = 1;
            while (!sr1.EndOfStream)
            {
                var eachRow = sr1.ReadLine();
                var columns = eachRow.Split('|');

                string strOS = columns[0];
                string strUAS = columns[1];
                string strCPU = columns[2];
                string strPlatform = columns[3];

                if (comboBoxBP.Text == strOS)
                {
                    lblUASvalue.MaximumSize = new Size(600, 0);
                    lblUASvalue.AutoSize = true;
                    methods.updateLabelG(lblUASvalue, strUAS);
                    methods.setUAS(strCountry, strOS, strUAS, strCPU, strPlatform);

                }
            }

            sr1.Close();
        }
        private void launchBtn()
        {
            if ((comboBoxCountry.SelectedIndex == -1) || (comboBoxBP.SelectedItem == null))
            {
                btnLaunch.Enabled = false;
            }
            else
            {
                btnLaunch.Enabled = true;
            }
        }


        private void textBoxGPS_Click(object sender, EventArgs e)
        {
            textBoxGPS.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string latlonfield = textBoxGPS.Text;

                string[] latlon = latlonfield.Split(',');

                foreach (var field in latlonfield)
                {
                    string lat = latlon[0];
                    string lon = latlon[1];

                methods.updateGPS(comboBoxCountry.Text, lat, lon);
                lblLongValue.Text = lon;
                lblLatValue.Text = lat;
            }

        }

        private void lblUASvalue_Click(object sender, EventArgs e)
        {

        }
    }
}