using System;
using System.IO;
using System.Xml;
using System.Configuration;
using System.Collections.Specialized;

namespace ThirdStage.XMLConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection state = ConfigurationSettings.AppSettings;
            int count = 0;

            Console.WriteLine("Key / Value\n------------");
            foreach (string item in state)
            {
                Console.WriteLine($"<{++count}>: " + item + " -> " + state[item]);
            }

            Console.ReadKey();
        }
    }
}
