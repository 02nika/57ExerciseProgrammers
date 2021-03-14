using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_27
{
    public class ValidateEmployeeID : IValidateInput
    {
        public bool ValidateInput(string employeeID)
        {
            bool returner = false;
            char[] charArr1 = employeeID.ToCharArray();
            if(charArr1.Length < 2)
            {
                Console.WriteLine($"\"{employeeID}\"" + " is not a valid ID.");
                returner = false;
                return returner;
            }
            for (int i = 0; i <= 1; i++)
            {
                if((int)charArr1[i] >= 65 && (int)charArr1[i] <= 90)
                {
                    returner = true;
                }
            }
            if(charArr1[2] != '-')
            {
                Console.WriteLine($"\"{employeeID}\"" + " is not a valid ID.");
                returner = false;
                return returner;
            }
            for (int i = 3; i < charArr1.Length; i++)
            {
                if ((int)charArr1[i] < 48 && (int)charArr1[i] > 57)
                    return false;
            }
            return returner;
        }
    }
}
