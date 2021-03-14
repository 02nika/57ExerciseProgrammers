using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_23
{
    static class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> information = new Dictionary<string, string>();
            information.Add("y"     ,     "Are the battery terminals corroded ? ");
            information.Add("n"     ,     "Does the car make a clicking noise ? ");
            information.Add("yy"    ,     "Clean terminals and try starting again.");
            information.Add("yn"    ,     "Replace cables and try again.");
            information.Add("ny"    ,     "Replace the battery.");
            information.Add("nn"    ,     "Does the car crank up but fail to start ? ");
            information.Add("nny"   ,     "Check spark plug connections.");
            information.Add("nnn"   ,     "Does the engine start and then die ? ");
            information.Add("nnny"  ,     "Does your car have fuel injection ? ");
            information.Add("nnnyy" ,     "Get it in for service.");
            information.Add("nnnyn" ,     "Check to ensure the choke is opening and closing.");

            CarAI car = new CarAI(information);
            car.StartCarAI();
            Console.ReadLine();
        }
    }
}
