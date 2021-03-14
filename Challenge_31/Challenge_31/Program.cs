using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_31
{
    static class Program
    {
        public static List<double> TargetHeartRate(this List<double> list,
                                                            double age, 
                                                                double restingHR)
        {
            double targetHeartRate;
            Console.WriteLine("Intensity        |   Rate");
            for (int intensity = 55; intensity <= 95; intensity += 5)
            {
                targetHeartRate = (((220 - age) - restingHR) * intensity / 100) + restingHR;
                list.Add(Math.Round(targetHeartRate, 0));               
                Console.WriteLine(intensity + "%              |   " + targetHeartRate);
            }
            return list;
        }
        static void Main(string[] args)
        {
            Console.Write("Resting Pulse: ");
            string rp = Console.ReadLine();
            Console.Write("Age: ");
            string age = Console.ReadLine();
            double rpd;
            double aged;
            List<double> list1 = new List<double>();
            while (true)
            {
                try
                {
                    rpd = Convert.ToDouble(rp);
                    aged = Convert.ToDouble(age);
                    break;
                }
                catch
                {
                    Console.WriteLine("input correctly: ");
                    Console.Write("Resting Pulse: ");
                    rp = Console.ReadLine();
                    Console.Write("Age: ");
                    age = Console.ReadLine();

                }
            }


            list1.TargetHeartRate(aged, rpd);

            Console.ReadLine();
        }
    }
}
