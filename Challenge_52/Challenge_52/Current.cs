using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_52
{
    class Current
    {
        public static void ShowCurrentTime(string path)
        {
            StreamReader v = new StreamReader(path);

            dynamic stringJson = JObject.Parse(v.ReadToEnd());


            DateTime dateTimeee = DateTime.ParseExact(stringJson.currentTime.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("The current time is " + dateTimeee.ToString("HH:mm:ss UTC MMMM dd yyyy"));
        }
    }
}
