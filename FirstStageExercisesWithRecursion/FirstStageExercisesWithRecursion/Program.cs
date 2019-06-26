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


        static int ProdOfDigits(int number) // For Exe_16 
        {
            if (number / 10 == 0) return number;
            return number % 10 * ProdOfDigits(number / 10);
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

        //Exe_11: Տրված է N բնական թիվը։ Հաշվել 1.1 · 1.2 · 1.3 · … արտադրյալը (արտադրիչների քանակը N է)։
        static double ProductFloat(int n)
        {
            string s = n.ToString();

            if (n == 1)
            {
                return 1.1;
            }
            return (1.0 + n / Math.Pow(10,s.Length)) * ProductFloat(--n);
        }

        //Exe_12: 


        //Exe_13: Տրված է N բնական թիվը։ Հաշվել այդ թվի քառակուսին՝ օգտագործելով հետևյալ բանաձևը. N2 = 1 + 3 + 5 + … + (2*N – 1). (N^2)
        static int NPow(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return (2 * n - 1) + NPow(--n);
        }

        //Exe_14: Ներածել n թիվը։ Արտածել yes, եթե այն հավասար է իր թվանշանների գումարի կրկնապատիկին, no՝ հակառակ դեպքում։
        static string YesOrNo(int n)
        {
            if (SumOfDigits(n) * 2 == n) return "Yes";
            else return "No";
        }

        //Exe_15: Եռանիշ թվի առաջին թվանշանը ջնջել։ Եթե ստացված թիվը բազմապատկվի 7-ով, կստացվի սկզբնական թիվը։ Գտնել այդպիսի թվերը։
        static void Function(int n = 100)
        {
            //if (n < 100 || n > 999)
            //{
            //    Writeln("N < 100 or N > 999");
            //    return;
            //}
            if (n > 999) return;
            if ((n % 100) * 7 == n)
            {
                Writeln(n);
            }
            Function(++n);
            
        }

        //Exe_16: Հաշվել տրված բնական թվի թվանշանների գումարը, քանակը, արտադրյալը։
        static void SumProdCount(int n)
        {
            string count = n.ToString();
            Console.WriteLine("Sum of digits: " + SumOfDigits(n));
            Console.WriteLine("Digits count: " + count.Length);
            Console.WriteLine("Product of digits: " + ProdOfDigits(n));
        }

        //Exe_17: Գտնել տրված թվի կենտ թվանշաններից ամենափոքրը։
        static int MinValue(char[] num, int i = 0)
        {
            char t;

            if (i == num.Length - 1 && num[i] % 2 != 0) return int.Parse(num[i].ToString());
            else if (i == num.Length - 1 && num[i] % 2 == 0) return 0;

            if (num[i] % 2 == 0)
                return MinValue(num, ++i);

            if (num[i] < num[i + 1])
            {
                t = num[i];
                num[i] = num[i + 1];
                num[i + 1] = t;
                return MinValue(num, ++i);
            }
            else return MinValue(num, ++i);
        }

        //Exe_18: Հաշվել տրված թվի 4-ից մեծ կենտ թվանշանների գումարը։
        static int SumDigitsBig4(int n)
        {
            if (n == 0) return 0;
            if (n % 10 > 4 && n % 2 != 0) 
            {
                return (n % 10) + SumDigitsBig4(n / 10);
            }
            else
            {
                return SumDigitsBig4(n / 10);
            }
        }

        //Exe_19: Հաշվել տրված թվի 7-ից փոքր զույգ թվանշանների արտադրյալը։
        static int ProdDigitsSmall7(int n)
        {
            if (n == 0) return 1;
            if (n % 10 < 7 && n % 2 == 0)
            {
                return (n % 10) * ProdDigitsSmall7(n / 10);
            }
            else
            {
                return ProdDigitsSmall7(n / 10);
            }
        }


        //Exe_20: Գտնել տրված թվի ամենամեծ և ամենափոքր թվանշանների տարբերության քառակուսին։
        static int MinDigit(int number)
        {
            if (number / 10 == 0) return number;
            return Math.Min(number % 10, MinDigit(number / 10));
        }

        static int MaxDigit(int number)
        {
            if (number / 10 == 0) return number;
            return Math.Max(number % 10, MaxDigit(number / 10));
        }

        static double DifferenceBigAndSmall(int n)
        {
            return Math.Pow((MaxDigit(n) - MinDigit(n)), 2);
        }
        //Exe_20: End.



        static void Main(string[] args)
        {
            // Exe_1
            Writeln(SumOfDigits(InputInt32()));
            
            //Exe_2
            Writeln("Please input k & n");
            PrintNK(InputInt32(), InputInt32());
            
            //Exe_3
            PrintTillN(InputInt32() - 1);
            
            //Exe_4
            PrintPow1To9(InputInt32());
            
            //Exe_5
            Writeln(CoupleNumbersSum(InputInt32()));
            
            //Exe_6
            Writeln("Count of [A, B]");
            Writeln(CountOfA_B(InputInt32(), InputInt32()));
            
            //Exe_7
            Writeln("Sum of [A, B]");
            Writeln(SumOfA_B(InputInt32(), InputInt32()));
            
            //Exe_8
            Writeln(FirstMultipleOf3(InputInt32(), InputInt32()));
            
            //Exe_9
            Writeln(SequanceValue(InputInt32()));
            
            //Exe_10
            Writeln(SequanceValue2(InputInt32()));

            //Exe_11
            Writeln(ProductFloat(InputInt32()));

            //Exe_12


            //Exe_13
            Writeln(NPow(InputInt32()));

            //Exe_14
            Console.WriteLine(YesOrNo(InputInt32()));

            //Exe_15
            Function(100);

            //Exe_16
            SumProdCount(InputInt32());

            //Exe_17
            string str = InputInt32().ToString();
            Writeln(MinValue(str.ToCharArray()));

            //Exe_18
            Writeln(SumDigitsBig4(InputInt32()));

            //Exe_19
            Writeln(ProdDigitsSmall7(InputInt32()));

            //Exe_20
            Writeln(DifferenceBigAndSmall(InputInt32()));




            /////////////////////////////////////////////////////////
            ////    init();

            ////    push('a');
            ////    push('b');
            ////    push('c');

            ////    Console.WriteLine(stack[0]);
            ////    Console.WriteLine(stack[1]);
            ////    Console.WriteLine(stack[2]);

            ////    Console.WriteLine(new string('-', 15));

            ////    for (int i = 1; i <= 3; i++)
            ////    {
            ////        Console.WriteLine(pop());
            ////    }

            ////    Console.ReadKey();


        }

        ////static char[] stack = new char[10];
        ////static int index = 10; //For example tos = 10;

        ////static void init()
        ////{
        ////    index = 0;
        ////}

        ////static void push(char ch)
        ////{
        ////    if (index == 10)
        ////    {
        ////        return;
        ////    }
        ////    stack[index] = ch;
        ////    index++;
        ////}
        ////static char pop()
        ////{
        ////    if (index == 0)
        ////    {
        ////        return '0';
        ////    }
        ////    index--;
        ////    return stack[index];
        ////}
    }
}
