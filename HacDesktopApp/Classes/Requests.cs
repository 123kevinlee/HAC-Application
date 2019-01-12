using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HacDesktopApp
{
    class Requests
    {
        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/HACViewer";
        
        private CookieContainer container = new CookieContainer();

        public void LoginPost(string url, Config config, CookieContainer container)
        {
            //this.container = container;
            //Default URL: https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Account/LogOn?ReturnUrl=%2fHomeAccess%2fClasses
            var request = (HttpWebRequest)WebRequest.Create(url);
            CookieContainer cookies = container;
            this.container = container;
            var postData = "Database=" + config.Database;
            postData += "&LogOnDetails.UserName=" + config.Username;
            postData += "&LogOnDetails.Password=" + config.Pass;
            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
            request.CookieContainer = cookies;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
        }

        public bool CheckCredentials(string url, string username, string password, CookieContainer container)
        {
            //Default URL: https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Account/LogOn?ReturnUrl=%2fHomeAccess%2fClasses
            var request = (HttpWebRequest)WebRequest.Create(url);
            CookieContainer cookies = container;
            //this.container = container;
            var postData = "Database=50";
            postData += "&LogOnDetails.UserName=" + username;
            postData += "&LogOnDetails.Password=" + password;
            var data = Encoding.ASCII.GetBytes(postData);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
            request.CookieContainer = cookies;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            bool Success = false;
            if (responseString.Contains("LogOff"))
            {
                //Success = true;
                //MessageBox.Show(responseString);
                //StreamWriter writer = new StreamWriter("D:/Code/Code/GradeViewer/GradeViewer/bin/Debug/test3.txt");
                //writer.WriteLine(responseString);
                //writer.Close();
                return Success = true;
            }
            else
            {
                return Success = false;
            }
        }

        public string GetRegistrationPage(CookieContainer container)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Content/Student/Registration.aspx");
            //CookieContainer cookies = container;
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
            request.CookieContainer = container;
            var response = (HttpWebResponse)request.GetResponse();
            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            return responseString;
        }

        public void viewGradeAverage(CookieContainer container, string averageUrl)
        {
            CookieContainer cookies = container;

            var request = (HttpWebRequest)WebRequest.Create(averageUrl);
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
            request.CookieContainer = cookies;
            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            //Console.WriteLine(responseString);

            //StreamWriter writer = new StreamWriter("info.txt");
            //writer.Write(responseString);
            //writer.Close();
            //response.Close();
            ////Console.WriteLine("HTML written to info.txt");

            //StreamReader reader = new StreamReader("info.txt");
            string grade = string.Empty;
            string className = string.Empty;
            //string input = reader.ReadToEnd();
            //reader.Close();
            HTMLParser parser = new HTMLParser();
            grade = parser.GetGradePercentFromString(responseString);
            className = parser.GetClassNameFromString(responseString);

            //reader.Close();
            className = className.Trim();
            Console.WriteLine(className + ": " + grade);
            //Console.WriteLine(responseString);
        }

        public void getClasspageSource(CookieContainer container)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://esp41pehac.eschoolplus.powerschool.com/HomeAccess/Content/Student/Classes.aspx");
            CookieContainer cookies = container;
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
            request.CookieContainer = cookies;
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            response.Close();
            //Console.WriteLine(responseString);
            StreamWriter classWriter = new StreamWriter(filePath + "/tempFile.txt");
            classWriter.Write(responseString);
            classWriter.Close();
        }
    }
}
