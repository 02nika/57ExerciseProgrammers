using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_43
{
    public class CreateZipFile
    {
        public static void ToZip(string siteName, string ZipName)
        {
            ZipFile.CreateFromDirectory(siteName, ZipName);
        }
    }
}
