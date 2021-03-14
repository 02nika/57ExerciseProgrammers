using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_48
{
    class WeatherInformation
    {
        public double Temperature { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
        public int Humidity { get; set; }
        public string Description { get; set; }
        public WeatherInformation(double temperature, long sunrise,
                                  long sunset, int humidity,
                                  string description)
        {
            this.Temperature = temperature;
            this.Sunrise = sunrise;
            this.Sunset = sunset;
            this.Humidity = humidity;
            this.Description = description;
        }
    }
}
