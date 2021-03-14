using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;


namespace Challenge_45
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (string file in Directory.EnumerateFiles(@"D:\nika\c#\Challenge_57\Challenge_45\Challenge_45\bin\Debug", "*.txt"))
            {
                string contents = File.ReadAllText(file);
                string newData = contents.Replace("utilize", "use");
                string newFileName = file.Insert(file.Length-4, "copy"); 
                StreamWriter second = File.AppendText(newFileName);
                second.Close();
                File.AppendAllText(newFileName, newData);

                Console.WriteLine("Given the input file of");
                Console.WriteLine("\n\t" + contents);
                Console.WriteLine("program generate this:");
                Console.WriteLine("\n\t" + newData);
                int count = CountObject.CountString(contents, "utilize");
                Console.WriteLine("\n\tthere are " + count + " replacments. ");
                Console.WriteLine("\n\n\n");

            }

            /*
            string data = File.ReadAllText("file1.txt");
            string newData = data.Replace("utilize", "use");
            
            
            StreamWriter file = File.AppendText("file2.txt");
            file.Close();
            
            File.AppendAllText("file2.txt", newData);

            Console.WriteLine("Given the input file of");
            Console.WriteLine("\n\t"+data);
            Console.WriteLine("program generate this:");
            Console.WriteLine("\n\t"+newData);
            int count = CountObject.CountString(data, "utilize");
            Console.WriteLine("\n\tthere are " + count + " replacments. ");
            */
            Console.ReadKey();
        }
    }
}
