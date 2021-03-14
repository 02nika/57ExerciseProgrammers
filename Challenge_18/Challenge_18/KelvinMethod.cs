using System;

namespace Challenge_18
{
    class KelvinMethod
    {
        public static void GetKelvin()
        {
            Console.Write("\nConvert from Celsius or Fahrenheit? (press C or F) : ");
            string choice1 = Console.ReadLine();
            if (choice1 == "C")
            {
                GetKelvinByCelsius();
            }
            else if (choice1 == "F")
            {
                GetKelvinByFahrenheit();
            }
            else
            {
                Console.WriteLine("please input correctly! ");
                GetKelvin();
            }

        }
        private static void GetKelvinByCelsius()
        {
            Console.Write("Please enter the temperature in Celsius: ");
            try
            {

                string kelvin = Console.ReadLine();
                double k2 = Convert.ToDouble(kelvin);
                k2 += 273.15;
                Console.WriteLine("The temperature in Kelvin is " + Math.Round(k2, 2).ToString());
            }
            catch
            {
                Console.WriteLine("input must be numeric! ");
                GetKelvinByCelsius();
            }
        }
        private static void GetKelvinByFahrenheit()
        {
            Console.Write("Please enter the temperature in Fahrenheit: ");
            try
            {

                string kelvin = Console.ReadLine();
                double k2 = Convert.ToDouble(kelvin);
                double result = ((k2 - 32) * 5 / 9) + 273.15;
                Console.WriteLine("The temperature in Kelvin is " + Math.Round(result, 2).ToString());
            }
            catch
            {
                Console.WriteLine("input must be numeric! ");
                GetKelvinByCelsius();
            }
        }
    }
}
