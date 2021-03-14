using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Where are you? ");
            string city = Console.ReadLine();
            const string key = "498b8b06097b8f4566b3135b3d240cc8";
            
            WeatherInformation full = WorkWithJson.GetImportantInfo(key, city);
            dynamic fullJson = WorkWithJson.GetJsonByDynamic(key, city);
            double celsius = Temperature.KelvinToCelcius(full.Temperature);
            
            
            full.Temperature = Temperature.KelvinToFahrenheit(full.Temperature);
            string degreesByBinarySearch = GetInfoValue.ChooseByBinary(GetDegreesList.degrees, (double)fullJson.wind.deg);
            //
            Console.WriteLine($"Temperature(fahrenheit): {full.Temperature}\nTemperature(celsius): {Math.Round(celsius, 1)}\nDescription   {full.Description}\nSunrise   {full.Sunrise}\nSunset   {full.Sunset}\nHumidity   {full.Humidity}");
            Console.WriteLine("Degree: " + degreesByBinarySearch);
            Console.WriteLine("Wind Speed: " + fullJson.wind.speed);
            //string degreesToString = GetInfoValue.ChooseWiseValue(GetDegreesList.degrees, (double)fullJson.wind.deg);

            DescriptionForPeople(Convert.ToString(fullJson.weather[0].description), Convert.ToDouble(fullJson.wind.deg));
            DescriptionForCelsius(celsius);
            Console.ReadKey();
        }

        private static void DescriptionForCelsius(double celsius)
        {
            if(celsius < 2)
                Console.WriteLine("and outside is very cold temperature. put on winter clothe");
            else if(celsius < 10)
                Console.WriteLine("and outside is cold temperature. put on carefully");
            else if(celsius < 20)
                Console.WriteLine("and outside is normal temperature. you can to dress spring or summer clothes");
            else
                Console.WriteLine("also, outside is so warm temperature. actually summer season is going on :D :D :D");
        }

        private static void DescriptionForPeople(string dynamic1, double dynamic2)
        {
            Console.WriteLine();
            if(dynamic2 < 100 || dynamic1 == "clear sky")
                Console.WriteLine("outside is very nice weather");
            else if(dynamic2 < 200 || dynamic1 == "shattered cloueds")
                Console.WriteLine("there are little bit wind, so put on carefully");
            else if(dynamic1 == "broken clouds")
                Console.WriteLine("there are broken clouds, maybe soon starts rainings :(");
            else if(dynamic1 == "raining")
                Console.WriteLine("outside is raining, so get some ubrella if you are going there :3");
            else
                Console.WriteLine("there are some other weather, that i do not know");
        }
    }
}
