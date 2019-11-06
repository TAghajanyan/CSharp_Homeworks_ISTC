namespace BubbleSorting
{
    static class BubbleSorting
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Collection type</typeparam>
        /// <param name="param">Collection</param>
        /// <param name="n">Collection's length</param>
        public static void RecursiveSorting<T>(ref T[] param, int n) where T : struct
        {
            if (n == 1)
                return;

            for (int i = 0; i < n-1; i++)
            {
                if ((dynamic)param[i] > param[i+1])
                {
                    Swap(ref param[i], ref param[i + 1]);
                }
            }

            RecursiveSorting(ref param, n - 1);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Collection type</typeparam>
        /// <param name="param">Collection</param>
        public static void Sorting<T> (ref T[] param) where T : struct
        {
            for (int i = 0; i < param.Length; i++)
            {
                for (int j = 0; j < param.Length; j++)
                {
                    if ((dynamic)param[i]  < param[j])
                    {
                       Swap(ref param[i], ref param[j]);
                    }
                }
            }
        }

        private static void Swap<T>(ref T t1, ref T t2) where T : struct
        {
            t1 = (dynamic)t1 + t2;
            t2 = (dynamic)t1 - t2;
            t1 = (dynamic)t1 - t2;
        }
    }
}
