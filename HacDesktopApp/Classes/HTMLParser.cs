using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HacDesktopApp
{
    class HTMLParser
    {
        public string GetStudentNameFromString(string inputHTML)
        {
            string startIndexText = "plnMain_lblRegStudentName";
            string endIndexText = "</span>";

            int startIndex = inputHTML.LastIndexOf(startIndexText) + startIndexText.Length + 2;
            int endIndex = inputHTML.IndexOf(endIndexText);
            int substringLength = endIndex - startIndex;
            //int substringLength = startIndex + 30;

            string StudentName = string.Empty;
            StudentName = inputHTML.Substring(startIndex, substringLength);

            return StudentName;
        }

        public string GetBuildingFromString(string inputHTML)
        {
            string startIndexText = "plnMain_lblBuildingName";
            string endIndexText = "</span>";

            int startIndex = inputHTML.LastIndexOf(startIndexText) + startIndexText.Length + 2;
            int endIndex = inputHTML.IndexOf(endIndexText, startIndex);
            int substringLength = endIndex - startIndex;

            string building = string.Empty;
            building = inputHTML.Substring(startIndex, substringLength);

            return building;
        }

        public string GetGradeFromString(string inputHTML)
        {
            string startIndexText = "plnMain_lblCalendar";
            string endIndexText = "</span>";

            int startIndex = inputHTML.LastIndexOf(startIndexText) + startIndexText.Length + 2;
            int endIndex = inputHTML.IndexOf(endIndexText, startIndex);
            int substringLength = endIndex - startIndex;

            string gradeLv = string.Empty;
            gradeLv = inputHTML.Substring(startIndex, substringLength);

            return gradeLv;
        }

        public string GetBirthdateFromString(string inputHTML)
        {
            string startIndexText = "plnMain_lblBirthDate";
            string endIndexText = "</span>";

            int startIndex = inputHTML.LastIndexOf(startIndexText) + startIndexText.Length + 2;
            int endIndex = inputHTML.IndexOf(endIndexText, startIndex);
            int substringLength = endIndex - startIndex;

            string birth = string.Empty;
            birth = inputHTML.Substring(startIndex, substringLength);

            return birth;
        }

        public string GetHomeroomFromString(string inputHTML)
        {
            string startIndexText = "plnMain_lblHomeroom";
            string endIndexText = "</span>";

            int startIndex = inputHTML.IndexOf(startIndexText, inputHTML.IndexOf("Homeroom")) + startIndexText.Length + 2;
            int endIndex = inputHTML.IndexOf(endIndexText, startIndex);
            int substringLength = endIndex - startIndex;

            string homeroom = string.Empty;
            homeroom = inputHTML.Substring(startIndex, substringLength);

            return homeroom;
        }

        public string GetCounselorFromString(string inputHTML)
        {
            string startIndexText = "@CRSD.ORG";
            string endIndexText = "</span>";

            int startIndex = inputHTML.LastIndexOf(startIndexText) + startIndexText.Length + 2;
            int endIndex = inputHTML.IndexOf(endIndexText, startIndex) - 4;
            int substringLength = endIndex - startIndex;

            string counselor = string.Empty;
            counselor = inputHTML.Substring(startIndex, substringLength);

            return counselor;
        }

        public string GetGradePercentFromString(string inputHTML)
        {
            string startIndexText = ">MP:</td><td>";
            string endIndexText = "</td>";

            int startIndex = inputHTML.IndexOf(startIndexText) + startIndexText.Length;
            int endIndex = inputHTML.LastIndexOf(endIndexText);
            int substringLength = endIndex - startIndex;

            string gradePercent = string.Empty;
            gradePercent = inputHTML.Substring(startIndex, substringLength);
            return gradePercent;
        }

        public string GetClassNameFromString(string inputHTML)
        {
            string startIndexText = "plnMain_lblCourse";
            string endIndexText = "</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";

            int startIndex = inputHTML.LastIndexOf(startIndexText) + startIndexText.Length;
            int endIndex = inputHTML.IndexOf(endIndexText);
            int substringLength = endIndex - startIndex;

            string unformattedClassName = inputHTML.Substring(startIndex, substringLength);
            //className = new string(className.Where(char.IsLetter).ToArray());  
            //Above line cut out everything but letters, including spaces
            //Below keeps the spaces between letters
            string className = string.Empty;
            foreach (char index in unformattedClassName)
            {
                if (index >= 65 && index <= 122)
                {
                    className += index;
                }
                else if (index == 32)
                {
                    className += index;
                }

            }

            return className;
        }
    }
}
