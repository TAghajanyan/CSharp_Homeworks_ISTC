using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Inheritance.Homework
{
    class Animal
    {
        public static string Gender { get; } = "Male or Female";
        public string Type { get; protected set; }
        public int MaxAge { get; protected set; }
        public string Skin { get; protected set; }

        public Animal(string type, int maxAge, string skin)
        {
            Type = type;
            MaxAge = maxAge;
            Skin = skin;
        }
    }
}
