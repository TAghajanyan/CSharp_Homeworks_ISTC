using System;
using System.Threading;

namespace ThirdStage.Threads
{
    class MyClass
    {
        int[] array = new int[45];
        int a = 0, b = 1, counter = 0;

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                //Thread.Sleep(50);
                Console.Write(array[i] + "   ");
            }
        }

        public void Method()
        {
            while (counter < array.Length)
            {
                object obj = new object();

                lock (obj) // Comment line
                {
                    array[counter] = a + b;
                    a = b;
                    b = array[counter];

                    counter++;

                    Thread thread = new Thread(Method);
                    thread.Start();
                    Thread.Sleep(50);
                }
            }
        }
    }
}
