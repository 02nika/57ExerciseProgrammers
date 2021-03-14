using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_34
{
    class Employes
    {
        public List<string> employees { get; set; }
        public string address { get; set; }
        public Employes(List<string> list, string addr)
        {
            employees = list;
            address = addr;
        }
        public void DeleteEmployee(string name)
        {
            if (employees.Contains(name))
            {
                employees.Remove(name);
                File.WriteAllLines((address), employees.ToArray());
                OutputEm();
            }
            else
                Console.WriteLine("there is noone name like that. ");
        }
        public void OutputEm()
        {
            Console.WriteLine("There are " +  GetLength() +  " employees: \n");
            foreach (string item in employees)
            {
                Console.WriteLine(item);
            }
        }
        private int GetLength()
        {
            return employees.Count();
        }
    }
}
