using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter the ZIP code: ");
            string zipCode = Console.ReadLine();
            Console.Write("Enter an employee ID: ");
            string employeeID = Console.ReadLine();



            ValidateName vNa = new ValidateName();
            ValidateLastName vlN = new ValidateLastName();
            ValidateZipCode vzC = new ValidateZipCode();
            ValidateEmployeeID veID = new ValidateEmployeeID();

            

            bool validateName = vNa.ValidateInput(firstName);
            bool validateLastName = vlN.ValidateInput(lastName);
            bool validateZipCode = vzC.ValidateInput(zipCode);
            bool validateEmployeeID = veID.ValidateInput(employeeID);


            while (!validateName || !validateLastName || !validateZipCode || !validateEmployeeID)
            {
                Console.Write("Enter the first name: ");
                firstName = Console.ReadLine();
                Console.Write("Enter the last name: ");
                lastName = Console.ReadLine();
                Console.Write("Enter the ZIP code: ");
                zipCode = Console.ReadLine();
                Console.Write("Enter an employee ID: ");
                employeeID = Console.ReadLine();
                
                validateName = vNa.ValidateInput(firstName);
                validateLastName = vlN.ValidateInput(lastName);
                validateZipCode = vzC.ValidateInput(zipCode);
                validateEmployeeID = veID.ValidateInput(employeeID);
            }

            ReturnTrue(validateName, validateLastName, validateZipCode, validateEmployeeID);
            Console.ReadLine();
        }
        static void ReturnTrue(bool validateName, bool validateLastName, bool validateZipCode, bool validateEmployeeID)
        {
            if (validateName && validateLastName && validateZipCode && validateEmployeeID)
            {
                Console.WriteLine("There were no errors found.");
            }
        }
    }
}
