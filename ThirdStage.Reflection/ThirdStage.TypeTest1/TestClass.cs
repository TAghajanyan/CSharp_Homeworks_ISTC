using System;
using System.Reflection;

namespace ThirdStage.TypeTest1
{
    class TestClass
    {
        public void ListVariosStats(Type type)
        {
            Console.WriteLine(new string('_', 30) + "Information Class1\n");

            Console.WriteLine("FullName: " + type.FullName);
            Console.WriteLine("BaseType: " + type.BaseType);
            Console.WriteLine("IsAbstract: " + type.IsAbstract);
            Console.WriteLine("IsInterface: " + type.IsInterface);
            Console.WriteLine("IsSealed: " + type.IsSealed);
            Console.WriteLine("IsClass: " + type.IsClass);
        }

        public void ListMethods(Type type)
        {
            Console.WriteLine(new string('_', 30) + "Information Methods of Class1 \n");

            MethodInfo[] methodInfo = type.GetMethods(BindingFlags.Instance
                | BindingFlags.Static
                | BindingFlags.Public
                | BindingFlags.NonPublic 
                | BindingFlags.DeclaredOnly);

            foreach (MethodInfo method in methodInfo)
            {
                Console.WriteLine("Method: {0}", method.Name);
            }
        }

        public void ListField(Type type)
        {
            Console.WriteLine(new string('_', 30) + "Information Fields of Class1 \n");

            FieldInfo[] fileInfo = type.GetFields(BindingFlags.Instance
                | BindingFlags.Static
                | BindingFlags.Public
                | BindingFlags.NonPublic);

            foreach (FieldInfo file in fileInfo)
            {
                if (file.IsPrivate)
                    Console.WriteLine("Private Field: {0}", file.Name);
                else
                    Console.WriteLine("Field: {0}", file.Name);
            }
        }

        public void ListProps(Type type)
        {
            Console.WriteLine(new string('_', 30) + "Information Props of Class1 \n");

            PropertyInfo[] propInfo = type.GetProperties();

            foreach (PropertyInfo prop in propInfo)
            {
                Console.WriteLine("Prpoertes: {0}", prop.Name);
            }
        }

        public void ListInterface(Type type)
        {
            Console.WriteLine(new string('_', 30) + "Information Interfaces of Class1 \n");

            Type[] interfaceInfo = type.GetInterfaces();

            foreach (Type @interface in interfaceInfo)
            {
                Console.WriteLine("Interfaces: {0}", @interface.Name);
            }
        }

        public void ListCtors(Type type)
        {
            Console.WriteLine(new string('_', 30) + "Information Ctors of Class1 \n");

            ConstructorInfo[] constructorInfo = type.GetConstructors();

            foreach (ConstructorInfo ctor in constructorInfo)
            {
                Console.WriteLine("Ctors: {0}", ctor);
            }
        }
    }
}
