using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace HacDesktopApp.Pages
{
    public partial class classes : UserControl
    {
        public classes()
        {
            ConfigCreator ConfigCreator = new ConfigCreator();
            ConfigCreator.CreateConfigFile();

            InitializeComponent(); 
            Requests Request = new Requests();
            HTMLParser Parser = new HTMLParser();
            CookieContainer Cookies = new CookieContainer();
            Config Config = LoadJson();
            Request.LoginPost("https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Account/LogOn?ReturnUrl=%2fHomeAccess%2fClasses", Config, Cookies);

            //if (Config.ClassUrl1 == "classurl1")
            //{
                #region getClassURLS
                string pageSource = Request.GetClassID(Cookies);
                List<string> classIDs = Parser.GetClassIDsFromString(pageSource);

                #region configFileString
                string configInfo =
                "{" +
                "\n\"Database\": \"50\"," +
                $"\n\"Username\": \"{Config.Username}\"," +
                $"\n\"Pass\": \"{Config.Pass}\",";
                #endregion

                int classNumber = 0;
                foreach (string classID in classIDs)
                {
                    if (classID != "ALL")
                    {
                        string classId = classID;
                        classId = classId.Remove(classId.IndexOf("|"));
                        configInfo += $"\n\"ClassUrl{classNumber}\": \"https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Content/Student/ClassworkAverages.aspx?section_key=" + classId + "&course_session=1&rc_run=2\",";
                    }
                    classNumber++;
                }
                configInfo += $"\n\"Rem\": \"" + Config.Rem + "\"\n}";
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";
                StreamWriter configWriter = new StreamWriter(filePath + "/config.json");
                configWriter.Write(configInfo);
                configWriter.Close();
            #endregion
            //}

            #region GetAndDisplayGrades
            //string[] classURLS = new string[] { Config.ClassUrl1, Config.ClassUrl2, Config.ClassUrl3, Config.ClassUrl4, Config.ClassUrl5, Config.ClassUrl6, Config.ClassUrl7 };
            //string[] grades = new string[] { grades1.Text, grades2.Text, grades3.Text, grades4.Text, grades5.Text, grades6.Text, grades7.Text };
            //string[] classNames = new string[] { className1.Text, className2.Text, className3.Text, className4.Text, className5.Text, className6.Text, className7.Text };
            //string gradesource = "";
            //for (int i = 0; i < classURLS.Length; i++)
            //{
            //    gradesource = Request.viewGradeAverage(Cookies, classURLS[i]);
            //    grades[i] = Parser.GetGradePercentFromString(gradesource);
            //    classNames[i] = Parser.GetClassNameFromString(gradesource);
            //}
            //MessageBox.Show(Config.ClassUrl1);
            Config = LoadJson();
            string GradeSource = Request.viewGradeAverage(Cookies, Config.ClassUrl1);
            grades1.Text = Parser.GetGradePercentFromString(GradeSource);
            className1.Text = Parser.GetClassNameFromString(GradeSource);

            GradeSource = Request.viewGradeAverage(Cookies, Config.ClassUrl2);
            grades2.Text = Parser.GetGradePercentFromString(GradeSource);
            className2.Text = Parser.GetClassNameFromString(GradeSource);

            GradeSource = Request.viewGradeAverage(Cookies, Config.ClassUrl3);
            grades3.Text = Parser.GetGradePercentFromString(GradeSource);
            className3.Text = Parser.GetClassNameFromString(GradeSource);

            GradeSource = Request.viewGradeAverage(Cookies, Config.ClassUrl4);
            grades4.Text = Parser.GetGradePercentFromString(GradeSource);
            className4.Text = Parser.GetClassNameFromString(GradeSource);

            GradeSource = Request.viewGradeAverage(Cookies, Config.ClassUrl5);
            grades5.Text = Parser.GetGradePercentFromString(GradeSource);
            className5.Text = Parser.GetClassNameFromString(GradeSource);

            GradeSource = Request.viewGradeAverage(Cookies, Config.ClassUrl6);
            grades6.Text = Parser.GetGradePercentFromString(GradeSource);
            className6.Text = Parser.GetClassNameFromString(GradeSource);

            GradeSource = Request.viewGradeAverage(Cookies, Config.ClassUrl7);
            grades7.Text = Parser.GetGradePercentFromString(GradeSource);
            className7.Text = Parser.GetClassNameFromString(GradeSource);
            #endregion
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

        private void Draggable_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
        #endregion
    }
}
