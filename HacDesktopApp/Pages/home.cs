using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace HacDesktopApp
{
    public partial class home : UserControl
    {
        public home()
        {
            ConfigCreator ConfigCreator = new ConfigCreator();
            ConfigCreator.CreateConfigFile();

            InitializeComponent();        

            SetUserInfo();
        }

        public void SetUserInfo()
        {
            Requests Request = new Requests();
            HTMLParser Parser = new HTMLParser();
            CookieContainer Cookies = new CookieContainer();
            Config Config = LoadJson();

            Request.LoginPost("https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Account/LogOn?ReturnUrl=%2fHomeAccess%2fClasses", Config, Cookies);

            string registrationSource = Request.GetRegistrationPage(Cookies);
            string studentName = Parser.GetStudentNameFromString(registrationSource);
            string buildingName = Parser.GetBuildingFromString(registrationSource);
            string gradeLv = Parser.GetGradeFromString(registrationSource);
            string birthDay = Parser.GetBirthdateFromString(registrationSource);
            string homeroom = Parser.GetHomeroomFromString(registrationSource);
            string counselor = Parser.GetCounselorFromString(registrationSource);
            studentNameLabel.Text = "Student Name: " + studentName;
            building_label.Text = "Building: " + buildingName;
            grade_label.Text = "Grade Level: " + gradeLv;
            birthday_label.Text = "Birthday: " + birthDay;
            hr_label.Text = "Homeroom: " + homeroom;
            counselor_label.Text = "Counselor: " + counselor;
        }

        static Config LoadJson()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";
            //D:/Code/Code/HacDesktopApp/HacDesktopApp/bin/Debug/config.json
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
                ParentForm.Location = new Point(
                    (ParentForm.Location.X - lastLocation.X) + e.X, (ParentForm.Location.Y - lastLocation.Y) + e.Y);

                ParentForm.Update();
            }
        }

        private void Draggable_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        #endregion
    }
}
