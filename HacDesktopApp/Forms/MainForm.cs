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
            ConfigCreator ConfigCreator = new ConfigCreator();
            ConfigCreator.CreateConfigFile();

            InitializeComponent();

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";

            Config Config = LoadJson();

            //Cookie Container Initialization
            CookieContainer Cookies = new CookieContainer();
            
            //Request Client
            Requests Request = new Requests();
            Request.LoginPost("https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Account/LogOn?ReturnUrl=%2fHomeAccess%2fClasses", Config, Cookies);

            //Side Bar Flag Initialization
            Flag.Height = home_button.Height;
            Flag.Top = home_button.Top;
   
            homePage.BringToFront();
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
            homePage.BringToFront();
            //home1.BringToFront();
            Flag.Height = home_button.Height;
            Flag.Top = home_button.Top;
        }

        private void class_button_Click(object sender, EventArgs e)
        {
            classPage.BringToFront();
            Flag.Height = class_button.Height;
            Flag.Top = class_button.Top;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            exit_button.BackColor = Color.DarkRed;
            Close();
        }

        //Currently only changes flag
        private void calendar_Click(object sender, EventArgs e)
        {
            Flag.Height = calendar.Height;
            Flag.Top = calendar.Top;
        }
    }
}
