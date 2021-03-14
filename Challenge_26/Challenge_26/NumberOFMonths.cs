using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_26
{
    class NumberOFMonths
    {
        public static double dailyRate { get; set; }
        public static double balance { get; set; }
        public static double monthlyPayment { get; set; }
        public static double APR { get; set; }
        public static double NumberOfTheMonths()
        {
            double i = APR / 365;
            double test = 1 + balance / monthlyPayment * (1 - Math.Round(Axarisxeba(1 + i, 30), 2));
            double up = Math.Log(-1 * test);
            double down = Math.Log(i+1);
            //1 + i, 30
            Console.WriteLine(test);
            double n = (-1 / 30) * (up / down);
            return Math.Round(n, 2);
        }

        private static double Axarisxeba(double v1, int v2)
        {
            double num = v1;
            for (int i = 1; i < v2; i++)
            {
                v1 *= num;
            }
            return v1;
        }
    }
}
