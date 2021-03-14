using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_27
{
    class ValidateName : IValidateInput
    {
        public bool ValidateInput(string name)
        {
            if (name.Length <= 2)
            {
                Console.WriteLine($"\"{name}\" is not a valid first name. It is too short.");
                return false;
            }
            else if (name.Length == 0)
            {
                Console.WriteLine("The first name must be filled in.");
                return false;
            }
            return true;

        }
    }
}
