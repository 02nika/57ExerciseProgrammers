using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_23
{
    class CarAI
    {
        private string text = "";
        Dictionary<string, string> carInformation;
        public CarAI(Dictionary<string, string> info)
        {
            carInformation = info;
        }
        public void StartCarAI()
        {
            Console.Write("Is the car silent when you turn the key ? ");
            CheckYesOrNo(Console.ReadLine());
            GetText(text);

        }
        private void GetText(string Key)
        {
            if (carInformation.ContainsKey(Key))
            {
                carInformation.TryGetValue(Key, out string value1);
                Console.Write(value1);
                if (value1.Last() != '.')
                {
                    string newText = CheckYesOrNo(Console.ReadLine());
                    GetText(newText);
                }
                else
                    Console.WriteLine("\ngoodbye.");
            }
            else
                Console.WriteLine("goodbye.");


        }
        private string CheckYesOrNo(string input)
        {
            if (input == "y")
                return text += "y";
            else if (input == "n")
                return text += "n";
            else
            {
                Console.Write("please input yes or no. ");
                string newInput = Console.ReadLine();
                return CheckYesOrNo(newInput);
            } 
        }
        
        
    }
}
