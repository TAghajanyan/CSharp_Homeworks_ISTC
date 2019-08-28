using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Mutex
{
    class Program
    {
        static Mutex mutex = new Mutex(false, "MyMutex");

        static void Method1()
        {
            //mutex.WaitOne();
            Console.WriteLine("[Method1]Start. CurrentThread ID: " + Thread.CurrentThread.ManagedThreadId);
            Method2();
            //mutex.ReleaseMutex();
            Console.WriteLine("[Method1]Finish. CurrentThread ID: " + Thread.CurrentThread.ManagedThreadId);
        }

        private static void Method2()
        {
            //mutex.WaitOne();
            Console.WriteLine("[Method2]Start. CurrentThread ID: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            //mutex.ReleaseMutex();
            Console.WriteLine("[Method2]Finish. CurrentThread ID: " + Thread.CurrentThread.ManagedThreadId);
        }

        static void Main(string[] args)
        {
            Thread[] threads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                threads[i] = new Thread(Method1);
                threads[i].Start();
                threads[i].Join(); //another way, when commented all mutex methods
            }
        }
    }
}
