using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_48
{
    static class Temperature
    {
        public static double KelvinToFahrenheit(double json)
        {
            // °F = 9/5(K - 273) + 32

            double Fahrenheit = 9.0 / 5.0 * (json - 273.15) + 32;
            return Math.Round(Fahrenheit, 3);
        }
        public static double KelvinToCelcius(double kelvin)
        {
            double celsius = kelvin - 273.15;
            return celsius;
        }
    }
}
