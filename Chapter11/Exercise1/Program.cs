using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("----------");

            Exercise1_2(file);
            Console.WriteLine("----------");

            Exercise1_3(file);
            Console.WriteLine("----------");

            Exercise1_4(file);
            Console.WriteLine("----------");

        }

        private static void Exercise1_4(string file)
        {
            var newfile = "sports.xml";

            var xdoc = XDocument.Load(file);

            var element = new XElement("ballsport",
                    new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                    new XElement("teammembers", "11"),
                    new XElement("firstplayed", "1863")
                    );

            xdoc.Root.Add(element);
            xdoc.Save(newfile);
        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load("Sample.xml");
            var ballSports = xdoc.Root.Elements()
                             .Select(x => new 
                             {
                                 Name = (string)x.Element("name"),
                                 KanjiName = (string)(x.Element("name").Attribute("kanji")),
                                 Member = (int)x.Element("teammembers"),
                             });
            foreach (var ballsport in ballSports)
            {
                Console.WriteLine("{0} {1}",
                            ballsport.Name, ballsport.Member);
            }
        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load("Sample.xml");
            var xballsports = xdoc.Root.Elements().OrderBy(x => (int)(x.Element("firstplayed")));

            foreach (var xballsport in xballsports)
            {
                var xname = (string)xballsport.Element("name").Attribute("kanji");



                Console.WriteLine(xname);
            }
        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                                    .Select(x => new
                                    {
                                        Name = x.Element("name").Value,
                                        Teammembers = x.Element("teammembers").Value

                                    })
                                      .OrderByDescending(x => int.Parse(x.Teammembers))
                                      .First();

            Console.WriteLine("{0}", sports.Name);
        }
    }
}
