using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Site name: ");
            string siteName = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();

            CreatingFoldersAndFiles.CreateFolder(siteName);

            writeIntoHTML.AddHTMLBody(siteName, author);

            CreateZipFile.ToZip(siteName, "MainSite.zip");
            Console.WriteLine("Created " + "./" + siteName);
            Console.WriteLine("Created " + "./" + siteName + "/index.html");

            Console.ReadKey();
        }



    }
}
