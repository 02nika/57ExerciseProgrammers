using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Challenge_49
{
    class Program
    {
        static void Main(string[] args)
        {

            const string link = "https://www.flickr.com/services/feeds/photos_public.gne";
            /*
            XmlDocument doc1 = new XmlDocument();
            doc1.Load(link);
            XmlElement root = doc1.DocumentElement;
            XmlNodeList nodes = root.GetElementsByTagName("author");
            //SelectNodes("descendant::entry[title='doing some thinking']");

            Console.WriteLine(nodes.Count);
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(nodes[i].InnerXml);
            }*/
            XDocument testXML = XDocument.Load(link);
            var students = testXML.Element(XName.Get("link", link)).Attribute("href").Value;


            Console.WriteLine(students);
            //rss.Link1 = (string)rssItem.Element(XName.Get("link", "http://www.w3.org/2005/Atom")).Attribute("href");
            //Console.WriteLine(students.Count());

            Console.ReadKey();
        }
    }
}
