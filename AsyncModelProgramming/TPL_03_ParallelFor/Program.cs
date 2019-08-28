using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_03_ParallelFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();

            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 1;

            int[] arr = new int[1_000_000];
            Action<int> action = (int x) => arr[x] = x * x * x;


            timer.Start();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = i;
            timer.Stop();

            Console.WriteLine("Simple For {0} second.", timer.Elapsed.TotalSeconds); // 0.0115162 second.


            timer.Reset();
            timer.Start();
            Parallel.For(0, arr.Length, options, action);
            timer.Stop();

            Console.WriteLine("ParallelFor [Logical processors]: {0} || {1} second.", options.MaxDegreeOfParallelism, timer.Elapsed.TotalSeconds);// 0.0316695 second.

            //------------------------------------------

            options.MaxDegreeOfParallelism = 2;

            timer.Reset();
            timer.Start();
            Parallel.For(0, arr.Length, options, action);
            timer.Stop();

            Console.WriteLine("ParallelFor [Logical processors]: {0} || {1} second.", options.MaxDegreeOfParallelism, timer.Elapsed.TotalSeconds); // 0.0097542 second.

            //------------------------------------------

            options.MaxDegreeOfParallelism = 4;

            timer.Reset();
            timer.Start();
            Parallel.For(0, arr.Length, options, action);
            timer.Stop();

            Console.WriteLine("ParallelFor [Logical processors]: {0} || {1} second.", options.MaxDegreeOfParallelism, timer.Elapsed.TotalSeconds); //0.0049872 second.

            //------------------------------------------


            int[] arr1 = new int[1_000_000];

            //arr1[200] = -1;

            Action<int, ParallelLoopState> action1 = (int i, ParallelLoopState state) =>
             {
                 if (arr1[i] < 0)
                 {
                     state.Break();
                 }

                 arr1[i] = i;
             };

            timer.Reset();
            timer.Start();
            var res = Parallel.For(0, arr1.Length, options, action1);
            timer.Stop();

            if (res.IsCompleted)
            {
                Console.WriteLine("\nParallelFor with ParallelLoopState [Logical processors]: {0} || {1} second.", options.MaxDegreeOfParallelism, timer.Elapsed.TotalSeconds); // 0.0190463 second.
            }
            else
            {
                Console.WriteLine($"Loop is stoped.\n Item index: {res.LowestBreakIteration}");
            }



        }
    }
}
