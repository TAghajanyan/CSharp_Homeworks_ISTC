using System;
using System.IO;
using System.Xml;
using System.Configuration;
using System.Collections;

namespace ThirdStage.XMLConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            var state = ConfigurationSettings.AppSettings;

            Console.WriteLine("Key / Value\n------------");
            foreach (string item in state)
            {
                Console.WriteLine(item + " -> " + state.Get(item));
            }

            Console.ReadKey();
        }
    }
}
