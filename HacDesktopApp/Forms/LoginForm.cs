using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using HacDesktopApp.Classes;

namespace HacDesktopApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";
            ConfigCreator ConfigCreator = new ConfigCreator();
            ConfigCreator.CreateConfigFile();

            InitializeComponent();
            progressBar1.Hide();
            try
            {
                Icon icon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream("Icon_icofile.ico"));
                this.Icon = icon;
            }
            catch
            {
                //no icon directory file found
            }

            Status_label.Text = "";

            //Read Config
            Config Config = LoadJson();
            if (Config.Rem == "yes")
            {
                Username_text.Text = Config.Username;
                Password_text.Text = Config.Pass;
                remember.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status_label.Text = "";
            
            //Cookie Container Initialization
            CookieContainer Cookies = new CookieContainer();

            //Request Client
            Requests Request = new Requests();
            bool Success = Request.CheckCredentials("https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Account/LogOn?ReturnUrl=%2fHomeAccess%2fClasses",Username_text.Text, Password_text.Text, Cookies);
   
            if (Success)
            {
                label1.Select();
                Exit.Hide();
                login_button.Hide();
                Status_label.Top = progressBar1.Bottom;
                Username_text.ReadOnly = true;
                Password_text.ReadOnly = true;
                progressBar1.BringToFront();
                progressBar1.Show();
                Status_label.ForeColor = Color.DodgerBlue;
                Status_label.Text = "Checking Credentials";
                Remember();
                Thread NewForm = new Thread(new ThreadStart(CreateForm));
                NewForm.Start();
                InitializeMyTimer();
            }
            else
            {
                Status_label.Text = "Login Failed.";
            }
        }

        private System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();

        private void InitializeMyTimer()
        {
            // Set the interval for the timer.
            time.Interval = 30;
            // Connect the Tick event of the timer to its event handler.
            time.Tick += new EventHandler(IncreaseProgressBar);
            // Start the timer.
            time.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            progressBar1.Maximum = 160;
     
            progressBar1.Increment(1);

            if (progressBar1.Value == progressBar1.Maximum)
            {
                time.Stop();
            }

            string[] loadingMessages = new string[4] { "Credentials Correct!", "Logging In", "Collecting Information", "Opening Application" };
            switch (progressBar1.Value)
            {
                case 20:
                    Status_label.Text = loadingMessages[0];
                    break;
                case 60:
                    Status_label.Text = loadingMessages[1];
                    break;
                case 95:
                    Status_label.Text = loadingMessages[2];
                    break;
                case 145:
                    Status_label.Text = loadingMessages[3];
                    break;
            }
        }

        private void CreateForm()
        {
            MainForm mainForm = new MainForm();
            if (progressBar1.Value >= progressBar1.Maximum - 15)
            {
                this.Close();
                mainForm.ShowDialog();
                Application.EnableVisualStyles();
            }
            
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


        private void Exit_Click(object sender, EventArgs e)
        {
            Remember();
            this.Close();
        }

        private void Reveal_button_Click(object sender, EventArgs e)
        {
            if (Password_text.UseSystemPasswordChar == true)
            {
                Password_text.UseSystemPasswordChar = false;
            }

            else if (Password_text.UseSystemPasswordChar == false)
            {
                Password_text.UseSystemPasswordChar = true;
            }
        }

        public void Remember()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";
            if (remember.Checked == true)
            {
                
                StreamReader configReader = new StreamReader(filePath + "/config.json");
                string configText = configReader.ReadToEnd();
                configReader.Close();
                if (configText.Contains("no") == true)
                {
                    configText = configText.Replace("no", "yes");
                }
                if (configText.Contains("user") == true)
                {
                    configText = configText.Replace("user", Username_text.Text);
                    configText = configText.Replace("pass", Password_text.Text);
                }
                StreamWriter configWriter = new StreamWriter(filePath + "/config.json");
                configWriter.Write(configText);
                configWriter.Close();
            }
            if (remember.Checked == false)
            {
                StreamReader configReader = new StreamReader(filePath + "/config.json");
                string configText = configReader.ReadToEnd();
                configReader.Close();
                if (configText.Contains("yes") == true)
                {
                    configText = configText.Replace("yes", "no");
                }
                if (configText.Contains("user") == true)
                {
                    configText = configText.Replace("user", Username_text.Text);
                    configText = configText.Replace("pass", Password_text.Text);
                }
                StreamWriter configWriter = new StreamWriter(filePath + "/config.json");
                configWriter.Write(configText);
                configWriter.Close();
            }
        }
    }
}
