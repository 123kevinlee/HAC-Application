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
            ConfigCreator ConfigCreator = new ConfigCreator();
            ConfigCreator.CreateConfigFile();

            Thread Start = new Thread(new ThreadStart(Launch));
            Start.Start();    
        }
        public static void Launch()
        {
            Application.Run(new LoginForm());
        }
    }
}
