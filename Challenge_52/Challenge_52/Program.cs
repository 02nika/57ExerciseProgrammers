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
    class Program
    {
        static void Main(string[] args)
        {
            
            const string path = "data.json";
            string dateTimeNow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            
            Dictionary<string, string> dateTime = new Dictionary<string, string>()
            {
                { "currentTime", dateTimeNow }
            };

            Json.InsertIntoJson(path, dateTime);
            //
            Current.ShowCurrentTime(path);

            Console.ReadKey();
        }


    }
}
