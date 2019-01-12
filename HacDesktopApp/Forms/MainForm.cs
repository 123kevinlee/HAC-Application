using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HacDesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";
            try
            {
                System.IO.Directory.GetDirectories(filePath);
            }
            catch
            {
                System.IO.Directory.CreateDirectory(filePath);
                StreamWriter createFiles = new StreamWriter(filePath + "/config.json");
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
                createFiles.Write(configInfo);
                createFiles.Close();
            }
            //MessageBox.Show(filePath);
            //Read Config
            Config Config = LoadJson();

            //Cookie Container Initialization
            CookieContainer Cookies = new CookieContainer();
            
            //Request Client
            Requests Request = new Requests();
            Request.LoginPost("https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Account/LogOn?ReturnUrl=%2fHomeAccess%2fClasses", Config, Cookies);

            //Flag Initialization
            Flag.Height = home_button.Height;
            Flag.Top = home_button.Top;
   
            home1.BringToFront();
            //MessageBox.Show(Directory.)
            //StreamWriter testWriter = new StreamWriter(filePath + "/testwriter.txt");
            //testWriter.Write("this is a test");
            //testWriter.Close();


        }

        static Config LoadJson()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";
            Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(filePath + "/config.json"));
            return config;
        }

        #region MakeDraggable
        private bool mouseDown;
        private Point lastLocation;

        private void Draggable_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Draggable_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Draggable_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion

        private void home_button_Click(object sender, EventArgs e)
        {
            home2.BringToFront();
            //home1.BringToFront();
            Flag.Height = home_button.Height;
            Flag.Top = home_button.Top;
        }

        private void class_button_Click(object sender, EventArgs e)
        {
            classes1.BringToFront();
            Flag.Height = class_button.Height;
            Flag.Top = class_button.Top;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            exit_button.BackColor = Color.DarkRed;
            Close();
        }

        private void calendar_Click(object sender, EventArgs e)
        {
            //calendarView1.BringToFront();
            Flag.Height = calendar.Height;
            Flag.Top = calendar.Top;
        }
    }
}
