using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_48
{
    static class WorkWithJson
    {
        public static WeatherInformation GetImportantInfo(string yourKey, string yourCity)
        {
            dynamic fullJson = GetJsonByDynamic(yourKey, yourCity);
            //----
            WeatherInformation temp1 = new WeatherInformation(
                (double)fullJson.main.temp, (long)fullJson.sys.sunrise,
                (long)fullJson.sys.sunset, (int)fullJson.main.humidity,
                Convert.ToString(fullJson.weather[0].description));
            //----
            return temp1;
        }
        public static dynamic GetJsonByDynamic(string yourKey, string yourCity)
        {
            string link = $"http://api.openweathermap.org/data/2.5/weather?q={yourCity}&appid={yourKey}";

            WebClient wc = new WebClient();

            string jsonString = wc.DownloadString(link);
            dynamic fromJson = JObject.Parse(jsonString);
            return fromJson;
                
            
            

            
        }
    }
}
