using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ThirdStage.Reflection
{
    class MyException : Exception
    {
        public override string Message { get; }

        public MyException(string message)
        {
            Message = message;
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    class MyClassAttribute : Attribute
    {
        int a;
        int b;

        public MyClassAttribute(int a, int b)
        {
            this.a = a;
            this.b = b;

            if (this.a > this.b)
            {
                Console.WriteLine("a > b");
            }
            else
            {
                throw new MyException("a < b: Exception");
            }
        }
    }

    [MyClass(1, 2)]
    class My
    {
        [MyClass(32, 2)]
        public void Method()
        {
            Console.WriteLine("Method();");
            try
            {
                Method();
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            My my = new My();
            my.Method();



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
