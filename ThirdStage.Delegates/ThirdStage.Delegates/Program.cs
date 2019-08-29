using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdStage.Delegates
{
    delegate string MyDelegate1();
    delegate int MyDelegate2(int a);
    delegate int MyDelegate3();
    delegate int[] MyDelegate4(params int[] a);

    delegate string Del2();
    delegate Del2 Del1();

    class Program
    {
        public static string Method1()
        {
            return "Program.Method1";
        }

        public static Del2 Method2()
        {
            return Method1;
        }

        static void Main(string[] args)
        {
            IMethods methods = new MyClass();

            MyDelegate1 myDelegate1 = new MyDelegate1(methods.Method1);
            Console.WriteLine(myDelegate1.Invoke());

            Console.WriteLine(new string('-', 25));

            MyDelegate1 myDelegate1_2 = methods.Method1;
            MyDelegate1 mydel = myDelegate1 + myDelegate1_2 + delegate { return "Anonymous Method"; };
            Console.WriteLine("myDelegate1 + myDelegate2 + Anonymous Method");
            Console.WriteLine(mydel);

            Console.WriteLine(new string('-', 25));

            MyDelegate4 myDelegate4 = null;
            int[] @params = { 1, 2, 3, 4, 5 };

            myDelegate4 = delegate (int[] a) { return a; };
            foreach (string item in methods.Method2(myDelegate4(1, 2, 3, 4, 5, 6)))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 25));

            MyDelegate2 myDelegate2 = delegate (int a) { Console.WriteLine("Method Param is delegate."); return a * 2; };
            Console.WriteLine(methods.Method3(myDelegate2(5)));

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Lambda operator.");
            myDelegate2 = (a) => { return a * 2; };
            Console.WriteLine(methods.Method3(myDelegate2(5)));

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Lambda Expression.");
            myDelegate2 = a => a * 2;
            Console.WriteLine(methods.Method3(myDelegate2(5)));

            Console.WriteLine(new string('-', 25));

            MyDelegate3 del = () => 6;
            Console.WriteLine("Lambda Expression.");
            Console.WriteLine(del + "\nMyDelegate3 => " + del());

            Console.WriteLine(new string('-', 25));

            Del1 delegate1 = new Del1(Method2);

            Del2 delegate2 = delegate1();

            Console.WriteLine("Del2.Method2() => Method1() => " + delegate2());

            Console.ReadKey();

        }
    }
}
