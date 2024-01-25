using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ay
{
    internal class requirements
    {
        public static void preReqs()
        {
            methods.createDir(globals.ayDir);

            downloadFile("https://raw.githubusercontent.com/ayapppub/ay/main/settings.conf", globals.aySettings);
            downloadFile("https://raw.githubusercontent.com/ayapppub/ay/main/bp.txt", globals.ayBPList);
            downloadFile("https://raw.githubusercontent.com/ayapppub/ay/main/locations.txt", globals.ayLocationsList);
            downloadFile("https://raw.githubusercontent.com/ayapppub/ay/main/template.js", globals.userJStemplate);
            downloadFile("https://raw.githubusercontent.com/ayapppub/ay/main/version.txt", globals.ayVersion);
        }


        private static void downloadFile(string url, string downloadLoc)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, downloadLoc);
        }



        public static void validate(Label lblayDir, Label lblayConfig, Label lblffPath, Label lblayBPList, Label lblayVersion)
        {
            validateItem(globals.ayDir, lblayDir, "");
            validateItem(globals.aySettings, lblayConfig, "");
            validateItem(globals.ffPath, lblffPath, "");
            validateItem(globals.ayBPList, lblayBPList, "");
            validateItem(globals.ayVersion, lblayVersion, "Not yet checked for updates.");
        }

        private static void validateItem(string objName, Label lblToUpdate, string customError)
        {
            if (Directory.Exists(objName) || File.Exists(objName))
            {
                methods.updateLabelG(lblToUpdate, objName);
                //lblToUpdate.ForeColor = System.Drawing.Color.Green;
               // lblToUpdate.Text = objName;
            }

            else
            {
                if (customError == "")
                {
                    lblToUpdate.ForeColor = System.Drawing.Color.Red;
                    lblToUpdate.Text = objName + " does not exist.";
                }
                else
                {
                    lblToUpdate.ForeColor = System.Drawing.Color.Red;
                    lblToUpdate.Text = customError;
                }

                
            }
        }



    }
}
