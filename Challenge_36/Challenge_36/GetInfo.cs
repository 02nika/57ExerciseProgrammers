using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_36
{
    static class GetInfo
    {
        public static double GetMin(this List<int> array1)
        {
            return array1.Min();
        }
        public static double GetMax(this List<int> array1)
        {
            return array1.Max();
        }
        public static double GetAVG(this List<int> array1)
        {
            return array1.Average();
        }
        public static double GetDeviation(this List<int> array1)
        {
            int n = array1.Count();
            int sum = array1.Sum();
            double bigX = sum / n;
            double sUP = 0;
            foreach (int item in array1)
            {
                sUP += Math.Pow((item - bigX), 2);
                
            }
            sUP = Math.Sqrt(sUP / (n - 1));
            return Math.Round(sUP, 2);
        }
    }
}
