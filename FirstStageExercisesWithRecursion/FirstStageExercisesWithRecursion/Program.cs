using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStageExercisesWithRecursion
{
    class Program
    {

        // Global Methods :D
        static int InputInt32()
        {
            Console.WriteLine("Please input number type of Int32");
            return int.Parse(Console.ReadLine());
        }
        static double InputDouble()
        {
            Console.WriteLine("Please input number type of Double");
            return double.Parse(Console.ReadLine());
        }
        static void Writeln(int value)
        {
            Console.WriteLine(value);
        }
        static void Writeln(double value)
        {
            Console.WriteLine(value);
        }
        static void Writeln(string str)
        {
            Console.WriteLine(str);
        }


        //Exe_1: Ներմուծել քառանիշ թիվ և հաշվել նրա թվանշանների գումարը:
        static int SumOfDigits(int number)
        {
            if (number / 10 == 0) return number;
            return number % 10 + SumOfDigits(number / 10);
        }


        //Exe_2: Տրված են K և N (N > 0) ամբողջ թվերը։ N անգամ արտածել K թիվը։
        static void PrintNK(int k, int n)
        {
            Writeln(k);
            if (n - 1 != 0)
                PrintNK(k, n - 1);
        }


        //Exe_3: Ներածել n միանիշ թիվը։ Արտածել n-ին չգերազանցող թվանշանները։
        static void PrintTillN(int n)
        {
            Writeln(n);
            if (n != 0) PrintTillN(n - 1);
        }

        //Exe_4: Ներածել n բնական թիվը։ Արտածել n–ի 1–ից մինչև 9 աստիճանների արժեքները։
        static void PrintPow1To9(int n, int count = 9)
        {
            Writeln(Math.Pow(n,count));

            if (count != 1)
                PrintPow1To9(n, --count);           
        }

        //Exe_5: Հաշվել տրված բնական թվին չգերազանցող զույգ թվերի գումարը՝ առանց զույգությունը ստուգելու։
        static int CoupleNumbersSum(int n)
        {
            if (n % 2 != 0)
            {
                return CoupleNumbersSum(n - 1);
            }
            else if(n >= 0)
            {
                return n + CoupleNumbersSum(n - 2);
            }
            else
                return 0;
        }

        //Exe_6: Տրված են A և B (A < B) ամբողջ թվերը։ 
        //       Արտածել աճման կարգով [A, B] հատվածին պատկանող ամբողջ թվերը, ապա նաև նրանց քանակը։
        static int CountOfA_B(int a, int b)
        {
            if (a <= b) Writeln(a);

            if (a == b) return 1;

            return CountOfA_B(++a, b) + 1;
        }

        //Exe_7: Տրված են A և B (A < B) ամբողջ թվերը։ Գտնել [A, B] հատվածին պատկանող բոլոր ամբողջ թվերի գումարը։
        static int SumOfA_B(int a, int b)
        {
            if (a == b) return b;

            return a + SumOfA_B(++a, b);
        }

        //Exe_8: Տրված են A և B (A < B) ամբողջ թվերը։ Գտնել [A, B] հատվածին պատկանող 3-ին պատիկ առաջին թիվը։
        static int FirstMultipleOf3(int a, int b)
        {
            if (a % 3 == 0) return a;
            else if (a < b) return FirstMultipleOf3(++a, b);
            else return 0;
        }

        //Exe_9: Տրված է N բնական թիվը։ Հաշվել 1 + 1/2 + 1/3 + … + 1/N գումարը (այն իրական թիվ է)։
        static double SequanceValue(int n)
        {
            if (n == 1)
            {
                return 1.0;
            }
            return 1.0 / n + SequanceValue(--n);
        }

        //Exe_10: Տրված է N բնական թիվը։ Հաշվել N2 + (N + 1)2 + (N + 2)2 + … + (2·N)2 գումարը։
        static double SequanceValue2(int n, int i = 0)
        {
            if (n + i == 2 * n) 
            {
                return 4 * n;
            }
            return 2 * (n + i) + SequanceValue2(n, ++i);
        }


        static void Main(string[] args)
        {
            //// Exe_1
            //Writeln(SumOfDigits(InputInt32()));

            ////Exe_2
            //Writeln("Please input k & n");
            //PrintNK(InputInt32(), InputInt32());

            ////Exe_3
            //PrintTillN(InputInt32() - 1);

            ////Exe_4
            //PrintPow1To9(InputInt32());

            //Exe_5
            //Writeln(CoupleNumbersSum(InputInt32()));

            ////Exe_6
            //Writeln("Count of [A, B]");
            //Writeln(CountOfA_B(InputInt32(), InputInt32()));

            ////Exe_7
            //Writeln("Sum of [A, B]");
            //Writeln(SumOfA_B(InputInt32(), InputInt32()));

            ////Exe_8
            //Writeln(FirstMultipleOf3(InputInt32(), InputInt32()));

            ////Exe_9
            //Writeln(SequanceValue(InputInt32()));

            ////Exe_10
            //Writeln(SequanceValue2(InputInt32()));

        }
    }
}
