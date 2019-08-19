using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Serialization;


namespace ThirdStage.Serializ_Deserialize_Json_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Rootobject rootobject = Deserialize_JSON.Deserialize(@"https://static.h-bid.com/sncmp/sngvl.json");

            foreach (var item in rootobject.purposes)
            {
                Console.WriteLine(item.id + " -> " + item.name + " -> " + item.description);
                item.id = 5;
                item.name = "John";
            }

            File.WriteAllText(@"D:\jsonFile.json", Serialize_JSON.Serialize(rootobject));


            Console.WriteLine(new string('-', 20));
            foreach (var item in rootobject.purposes)
            {
                System.Console.WriteLine(item.id + " -> " + item.name + " -> " + item.description);
            }

            File.WriteAllText(@"D:\xmlFile.xml", Serialize_XML.Serialize(rootobject));
        }
    }
}