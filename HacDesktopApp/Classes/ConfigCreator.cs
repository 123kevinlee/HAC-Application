using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HacDesktopApp
{
    class ConfigCreator
    {
        public void CreateConfigFile()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";

            //Attempting to find Config File
            try
            {
                System.IO.Directory.GetDirectories(filePath);
            }
            catch
            {
                Directory.CreateDirectory(filePath);
                StreamWriter CreateFile = new StreamWriter(filePath + "/config.json");

                #region configFileString
                string configInfo =
                "{" +
                "\n\"Database\": \"50\"," +
                "\n\"Username\": \"user\"," +
                "\n\"Pass\": \"pass\"," +
                "\n\"ClassUrl1\": \"classurl1\"," +
                "\n\"ClassUrl2\": \"classurl2\"," +
                "\n\"ClassUrl3\": \"classurl3\"," +
                "\n\"ClassUrl4\": \"classurl4\"," +
                "\n\"ClassUrl5\": \"classurl5\"," +
                "\n\"ClassUrl6\": \"classurl6\"," +
                "\n\"ClassUrl7\": \"classurl7\"," +
                "\n\"Rem\": \"no\"" +
                "\n}";
                #endregion

                CreateFile.Write(configInfo);
                CreateFile.Close();
            }
        }
    }
}
