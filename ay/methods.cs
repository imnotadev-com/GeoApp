using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ay
{
    internal class methods
    {


        public static void checkItem(string itemPath, Label updateLbl)
        {

            if (Directory.Exists(itemPath) || File.Exists(itemPath))
            {
                updateLbl.ForeColor = System.Drawing.Color.Green;
                updateLbl.Text = itemPath;
            }

            else
            {
                updateLbl.ForeColor = System.Drawing.Color.Red;
                updateLbl.Text = itemPath + " does not exist.";
            }

        }

        public static void createDir(string dirToCheck)
        {
            if (!Directory.Exists(dirToCheck))
                Directory.CreateDirectory(dirToCheck);
        }

        public static void delObj(string dirToDel)
        {

            if(File.Exists(dirToDel) || (Directory.Exists(dirToDel)))
            {
                FileAttributes attr = File.GetAttributes(dirToDel);
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    Directory.Delete(dirToDel, true);
                }
                else
                {
                    File.Delete(dirToDel);
                }
            }


        }


        public static void checkForUpdates(Label updateLBL)
        {
               
            if (File.Exists(globals.ayVersion))
            {
                decimal updateSourced;
                string updateSource = File.ReadLines(globals.ayVersion).First();

                decimal checkayConfigd;
                decimal checklocationsd;
                
                string checkayConfig = File.ReadLines(globals.aySettings).First();
                string checklocations = File.ReadLines(globals.ayLocationsList).First();


                Decimal.TryParse(updateSource, out updateSourced);
                
                Decimal.TryParse(checkayConfig, out checkayConfigd);
                Decimal.TryParse(checklocations, out checklocationsd);
                

                if (checkayConfigd < updateSourced || checklocationsd < updateSourced)
                {
                    updateLBL.ForeColor = System.Drawing.Color.Red;
                    updateLBL.Text = "Yes.";
                }
                else
                {
                    
                    updateLBL.ForeColor = System.Drawing.Color.Green;
                    updateLBL.Text = "No updates available.";
                }
            }

            else
            {
                updateLBL.ForeColor = System.Drawing.Color.Red;
                updateLBL.Text = "Could not check for updates.";
            }

        }

        public static void createUserJS(string country, string strHomePage, string strTimeZone, string strLanguage, string strProxy, string strPort, string strLat, string strLong) {
        
            string dir = globals.ayDir + "\\Profiles\\" + country;
            string userJS = dir + "\\user.js";
            string prefJS = dir + "\\prefs.js";

            string userJStemplate = globals.userJStemplate;

            createDir(dir);

            delObj(userJS);
            delObj(prefJS);

            File.Copy(userJStemplate, userJS, true);
            
            string text = File.ReadAllText(userJS);
            
            text = text.Replace("?BROWSERHOMEPAGE?", strHomePage).Replace("?PROXYSVR?", strProxy).Replace("?PROXYPORT?", strPort).Replace("?LANGUAGECODE?", strLanguage).Replace("?GPSLAT?", strLat).Replace("?GPSLONG?", strLong);


            File.WriteAllText(userJS, text);
        }

        public static void setUAS(string strCountry, string strOS, string strUAS, string strOScpu, string strPlatform)
        {
            string dir = globals.ayDir + "\\Profiles\\" + strCountry;
            string UAS = dir + "\\user.js";

            string[] lines = System.IO.File.ReadAllLines(UAS);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains("general.useragent.override"))
                    lines[i] = "user_pref(\"general.useragent.override\", \"" + strUAS + "\");";
                if (lines[i].Contains("general.oscpu.overrid"))
                    lines[i] = "user_pref(\"general.oscpu.overrid\", \"" + strOScpu + "\");";
                if (lines[i].Contains("general.platform.override"))
                    lines[i] = "user_pref(\"general.platform.override\", \"" + strPlatform + "\");";
            }
            //and save it:
            File.WriteAllLines(UAS, lines);
        }
        
        

        public static void updateGPS(string strCountry, string strLat, string strLon)
        {
                string dir = globals.ayDir + "\\Profiles\\" + strCountry;
                string UAS = dir + "\\user.js";
                string PJS = dir + "\\prefs.js";
                string[] lines = System.IO.File.ReadAllLines(UAS);
            
                for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].Contains("geo.wifi.uri"))
                            lines[i] = "user_pref(\"geo.wifi.uri\", \"data:application/json,{\\\"location\\\": {\\\"lat\\\": " + strLat + ", \\\"lng\\\": " + strLon + "}, \\\"accuracy\\\": 500.0}\");";
                        if (lines[i].Contains("geo.provider.network.url"))
                            lines[i] = "user_pref(\"geo.provider.network.url\", \"data:application/json,{\\\"location\\\": {\\\"lat\\\": " + strLat + ", \\\"lng\\\": " + strLon + "}, \\\"accuracy\\\": 500.0}\");";

                    }

            File.WriteAllLines(UAS, lines);

                if (File.Exists(PJS))
                    {

                        string[] lines1 = System.IO.File.ReadAllLines(PJS);
                        for (int i = 0; i < lines1.Length; i++)
                        {
                            if (lines1[i].Contains("geo.wifi.uri"))
                                lines1[i] = "user_pref(\"geo.wifi.uri\", \"data:application/json,{\\\"location\\\": {\\\"lat\\\": " + strLat + ", \\\"lng\\\": " + strLon + "}, \\\"accuracy\\\": 500.0}\");";
                            if (lines1[i].Contains("geo.provider.network.url"))
                                lines1[i] = "user_pref(\"geo.provider.network.url\", \"data:application/json,{\\\"location\\\": {\\\"lat\\\": " + strLat + ", \\\"lng\\\": " + strLon + "}, \\\"accuracy\\\": 500.0}\");";

                        }
                        File.WriteAllLines(PJS, lines1);
                    }

        }



        public static void updateLabelG(Label label, string value)
        {
            
            label.ForeColor = System.Drawing.Color.Green;
            label.Text = value;
        }


        public static void delText(string fileToSearch, string wordToDel)
        {
            string search_text = wordToDel;
            string old;
            string n = "";
            StreamReader sr = File.OpenText(fileToSearch);
            while ((old = sr.ReadLine()) != null)
            {
                if (!old.Contains(search_text))
                {
                    n += old + Environment.NewLine;
                }
            }
            sr.Close();
            File.WriteAllText(fileToSearch, n);
        }


    }
}
