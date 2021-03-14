using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_52
{
    class Json
    {
        public static void InsertIntoJson(string path, Dictionary<string, string> dict1)
        {
            string json = JsonConvert.SerializeObject(dict1);

            File.WriteAllText(path, json);
        }
    }
}
