﻿using Newtonsoft.Json;
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

namespace HacDesktopApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
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

            InitializeComponent();
            try
            {
                Icon icon = new Icon("Pictures/icon.ico");
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
            //MessageBox.Show(Password_text.Text + Username_text.Text);
            if (Success)
            {
                Status_label.Text = "Logged In!";
                Remember();

                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                Status_label.Text = "Login Failed.";
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
                StreamWriter configWriter = new StreamWriter(filePath + "/config.json");
                configWriter.Write(configText);
                configWriter.Close();
            }
            else
            {

                StreamReader configReader = new StreamReader(filePath + "/config.json");
                string configText = configReader.ReadToEnd();
                configReader.Close();
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