using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThirdStage.Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Math);
            
            string fullName = type.FullName;
            Type baseType = type.BaseType;
            bool isPublic = type.IsPublic;
            bool isClass = type.IsClass;
            FieldInfo[] fields = type.GetFields();
            MethodInfo[] methods = type.GetMethods();
            ConstructorInfo[] constructors = type.GetConstructors();
            Type[] interfaces = type.GetInterfaces();
            
            Console.WriteLine("Full name: " + fullName);
            Console.WriteLine("Base type: " + baseType);
            Console.WriteLine("Is public: " + isPublic);
            Console.WriteLine("Is class: " + isClass);

            Console.WriteLine("\nFields Info.");
            foreach (FieldInfo item in fields)
            {
                Console.WriteLine(new string('-', 25));
                Console.WriteLine($"Name: {item.Name}\nValue: {item.GetValue(item)}\nType: {item.FieldType}\nIs static: {item.IsStatic}\nIs public: {item.IsPublic}");
            }

            Console.WriteLine("\nMethods Info");
            if (methods.Length > 0)
            {
                foreach (MethodInfo item in methods)
                {
                    Console.WriteLine(new string('-', 25));
                    Console.WriteLine($"Name: {item.Name}\nReturn Type: {item.ReturnType}\nIs static: {item.IsStatic}\nIs public: {item.IsPublic}\nIs abstract: {item.IsAbstract}");
                }
            }
            else
            {
                Console.WriteLine("NULL!");
            }

            Console.WriteLine("\nConstructors Info");
            if (constructors.Length > 0)
            {
                foreach (ConstructorInfo item in constructors)
                {
                    Console.WriteLine(new string('-', 25));
                    Console.WriteLine($"Name: {item.Name}\nIs static: {item.IsStatic}\nIs public: {item.IsPublic}");
                }
            }
            else
                Console.WriteLine("NULL!");

            Console.WriteLine("\nInterfaces Info");
            if (interfaces.Length > 0)
            {
                foreach (Type item in interfaces)
                {
                    Console.WriteLine(new string('-', 25));
                    Console.WriteLine($"Name: {item.Name}");
                }
            }
            else
                Console.WriteLine("NULL!");
            Console.ReadKey();
        }
    }
}
