using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ThirdStage.TypeTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(MyClass);

            TestClass test = new TestClass();

            test.ListVariosStats(type);
            test.ListMethods(type);
            test.ListProps(type);
            test.ListField(type);
            test.ListInterface(type);
            test.ListCtors(type);

            Console.ReadKey();
        }
    }
}
