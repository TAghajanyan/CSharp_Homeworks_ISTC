using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int ID = Thread.CurrentThread.ManagedThreadId;

            Console.WriteLine("Main: Thread ID: " + ID);

            Action action = new Action(Method);
            Task task = new Task(action);
            task.Start(); // for async runing

            //task.RunSynchronously(); // for sync runing

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(100);
                Console.Write(" * ");
            }

            {
                Task task1 = new Task(Method1);
                task1.Start();

                //for Method1()
                Thread.Sleep(500);
            }
            Console.WriteLine("\nEnd of Mein: Thread ID: " + ID);

        }


        private static void Method1()
        {
            // if CurrentThread.IsBackground = true, Method1 will work until end of primary thread

            //Thread.CurrentThread.IsBackground = false; //default true

            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(100);
                Console.Write("Method1 ");
            }
        }

        private static void Method()
        {
            int ID = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("\nMethod: Thread ID: " + ID);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(" . ");
                Thread.Sleep(100);
            }

            Console.WriteLine("\nEnd of Method: Thread ID: " + ID);
        }
    }
}
