using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace startPage.Models
{
    public class Parser
    {
        private static string path= @"C:\Users\Админ\source\repos\About.txt";
        public static string WriteAboutContectToFile(string aboutContext)
        {
          
            File.WriteAllText(path, aboutContext);
            return path;
        }
        public static string WriteAboutContectToPage()
        {
            return File.ReadAllText(path);
        }
    }
}