using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_51
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("$ ");
            string text = Console.ReadLine();
            
            if (text.StartsWith("mynotes new"))
            {
                Dictionary<string, List<DateAndNode>> info = DictInfo("data.json");
                serializeJson(text.Substring(12), info);
                Console.WriteLine("Your note was saved.");

            }
            else if (text.StartsWith("mynotes show"))
            {
                Dictionary<string, List<DateAndNode>> info = DictInfo("data.json");
                foreach (var item in info)
                {
                    foreach (var item2 in item.Value)
                    {
                        Console.Write(item2.Date + " - " + item2.Node + "\n");
                    }
                }
            }
            else
            {
                Console.WriteLine("wrong input.");
            }
            Console.ReadKey();
        }

        private static Dictionary<string, List<DateAndNode>> DictInfo(string address)
        {
            StreamReader r = new StreamReader(address);

            string jsonString = r.ReadToEnd();
            r.Close();

             return WorkingWithJson.JsonToDict(jsonString);
        }

        private static void serializeJson(string node, Dictionary<string, List<DateAndNode>> info)
        {
            foreach (var item in info)
            {
                if(item.Key == "ListofNodes")
                {
                    item.Value.Add(new DateAndNode()
                    {
                        Date = DateTime.Now.ToString("yyyy-MM-dd"),
                        Node = node
                    });
                }
            }

            string json = JsonConvert.SerializeObject(info);

            File.WriteAllText("data.json", json);
        }
    }
}
