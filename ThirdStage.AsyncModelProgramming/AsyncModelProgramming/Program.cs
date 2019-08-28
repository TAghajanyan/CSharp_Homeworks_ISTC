using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncModelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start primary thread: {0}", Thread.CurrentThread.ManagedThreadId);

            Func<int,int,int> func = new Func<int, int, int>(Method);
            AsyncCallback callback = new AsyncCallback(CallBack);

            IAsyncResult async = func.BeginInvoke(5, 4, callback, "MyAsyncState.");

            // Will work until end of secondary thread
            while (!async.IsCompleted)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Loop of primary thread.");
            }

            int res = func.EndInvoke(async); //Join() for primary thread

            Console.WriteLine("Result of method: " + res);
            Console.WriteLine("End of primary thread.");

            Console.ReadKey();            
        }

        private static void CallBack(IAsyncResult ar)
        {
            Console.WriteLine("CallBack method. Thred ID: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("IAsyncResult.AsyncState: " + ar.AsyncState);
        }

        private static int Method(int a, int b)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Secondary thread!: {0}", Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(300);
            }

            return a + b;
        }
    }
}
