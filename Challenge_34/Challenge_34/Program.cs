using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "D:/nika/c#/Challenge_57/Challenge_34/Challenge_34/file123.txt";
            List<string> linesList = File.ReadAllLines(address).ToList();


            Employes employes = new Employes(linesList, address);
            employes.OutputEm();

            Console.Write("Enter an employee name to remove: ");
            string removeguy = Console.ReadLine();
            employes.DeleteEmployee(removeguy);
            Console.ReadLine();
        }
    }
}
