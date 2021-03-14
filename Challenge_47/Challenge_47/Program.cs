using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_47
{
    class Program
    {
        static void Main(string[] args)
        {
            const string httpUrl = "http://api.open-notify.org/astros.json";

            string json = WorkingWithHttp.JsonToString(httpUrl);
            
            OutPutJson.PrintResult(json);

            Console.ReadKey();
        }
    }
}
