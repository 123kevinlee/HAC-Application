using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HacDesktopApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";
            //try
            //{
            //    System.IO.Directory.GetDirectories(filePath);
            //}
            //catch
            //{
            //    System.IO.Directory.CreateDirectory(filePath);
            //    StreamWriter createFiles = new StreamWriter(filePath + "/config.json");
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
            //    createFiles.Write(configInfo);
            //    createFiles.Close();
            //}

            Thread Start = new Thread(new ThreadStart(Launch));
            Start.Start();
            

        }
        public static void Launch()
        {
            Application.Run(new LoginForm());
        }
    }
}
