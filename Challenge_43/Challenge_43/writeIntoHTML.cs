using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Challenge_43
{
    public class writeIntoHTML
    {
        public static void AddHTMLBody(string nameOfTheSite, string outhor)
        {
            List<string> html = new List<string>()
            {
                "<!doctype html>",
                "<html>",
                "<head>",
                $"<meta name={nameOfTheSite}>",
                $"<title> {outhor} </title>",
                "</head>",
                "<body>",
                "<H1>main outhor is : " + outhor + "</H1>",
                "<H3>" + "Thanks for Being on the site" + "</H3>",
                "<H3>" + "Goodbye..." + "</H3>",
                "</body>",
                "</html>"
            };

            File.WriteAllLines(nameOfTheSite+@"\index.html", html);

        }
    }
}
