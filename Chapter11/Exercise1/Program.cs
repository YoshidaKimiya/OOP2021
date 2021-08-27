﻿using System;
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
            
        }

        private static void Exercise1_3(string file)
        {
            
        }
    }
}
