using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPL_04_ParallelForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1_000_000];

            //Parallel.For(0, array.Length, (int i) => { array[i] = i * i * i; });

            Stopwatch timer = new Stopwatch();
            ParallelOptions options = new ParallelOptions();

            Action<int, ParallelLoopState> action = (int x, ParallelLoopState state) =>
            {
                if (array[x] < 0)
                {
                    state.Break();
                }

                array[x] = x * x * x;
            };

            options.MaxDegreeOfParallelism = 1;

            timer.Start();
            Parallel.ForEach(array, options, action);
            timer.Stop();

            Console.WriteLine("Parallel.Foreach [Logical processors]: {0} || {1} Seconds.", options.MaxDegreeOfParallelism, timer.Elapsed.TotalSeconds); //0.0782973 Seconds

            //----------------------------------

            options.MaxDegreeOfParallelism = 2;

            timer.Reset();
            timer.Start();
            Parallel.ForEach(array, options, action);
            timer.Stop();

            Console.WriteLine("Parallel.Foreach [Logical processors]: {0} || {1} Seconds.", options.MaxDegreeOfParallelism, timer.Elapsed.TotalSeconds);// 0.0632718 Seconds

            //----------------------------------

            options.MaxDegreeOfParallelism = 4;

            timer.Reset();
            timer.Start();
            Parallel.ForEach(array, options, action);
            timer.Stop();

            Console.WriteLine("Parallel.Foreach [Logical processors]: {0} || {1} Seconds.", options.MaxDegreeOfParallelism, timer.Elapsed.TotalSeconds); // 0.0625622 Seconds

            Console.ReadKey();
        }
    }
}
