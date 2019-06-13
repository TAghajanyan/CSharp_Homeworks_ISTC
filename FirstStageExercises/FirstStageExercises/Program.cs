using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStageExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exe_1

            ////Խնդիր_1: Ներմուծել քառանիշ թիվ և հաշվել նրա թվանշանների գումարը:

            //Console.WriteLine("Please input four-digit number");

            //int number = Convert.ToInt32(Console.ReadLine()); //Input

            //Console.WriteLine(new string('-', 9));

            //int num1 = number / 1000;
            //int num2 = number / 100 % 10;
            //int num3 = number / 10 % 10;
            //int num4 = number % 10;

            //int res = num1 + num2 + num3 + num4;

            //Console.WriteLine("Result=" + res);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_2

            ////Խնդիր_2: Տրված են K և N(N > 0) ամբողջ թվերը։ N անգամ արտածել K թիվը։

            //Console.Write("Input N & K\nN=");
            //int N = Convert.ToInt32(Console.ReadLine());

            //Console.Write("K=");
            //int K = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(new string('-',10));

            //for (int count = 1; count < N+1; count++)
            //    Console.WriteLine(count + ". " + K); //Numbers for numbers


            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_3

            ////Խնդիր_3: Ներմուծել n միանիշ թիվը։ Արտածել n-ին չգերազանցող թվանշանները։

            //Console.WriteLine("Please input one digit number");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("__");

            //for (int i = 0; i <= n; i++)
            //    Console.WriteLine(i);


            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_4

            ////Խնդիր_4: Ներածել n բնական թիվը։ Արտածել n–ի 1–ից մինչև 9 աստիճանների արժեքները։


            //Console.WriteLine("Please input number");
            //double n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("__");

            //for (double exponent = 1; exponent < 10; exponent++)
            //    Console.WriteLine($"{n}^{exponent} = {Math.Pow(n, exponent)}"); //Math.Pow-ը վերադարձնում է n–ի 1–ից մինչև 9 աստիճանների արժեքները։ 

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_5

            ////Խնդիր_5: Հաշվել տրված բնական թվին չգերազանցող զույգ թվերի գումարը՝ առանց զույգությունը ստուգելու։

            //Console.WriteLine("Please input number");
            //int number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("-------");

            //int sum = 0;
            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write(i + " | ");
            //    sum += i;
            //}
            //Console.WriteLine("\n-------\nResult=" + sum);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_6

            ////Խնդիր_6: Տրված են A և B(A < B) ամբողջ թվերը։ Արտածել աճման կարգով[A, B] հատվածին պատկանող ամբողջ թվերը, ապա նաև նրանց քանակը։

            //Console.WriteLine("Please input A & B\n---------");

            //Console.Write("A=");
            //int A = Convert.ToInt32(Console.ReadLine());

            //Console.Write("B=");
            //int B = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("---------");

            //for (int numbers = A, count = 1; numbers <= B; numbers++, count++)
            //    Console.WriteLine(count + ". " + numbers);

            //Console.Write("Min Number = ");
            //Console.WriteLine(minNum);

            #endregion

            #region Exe_7



            #endregion
            #region Exe_8



            #endregion
            #region Exe_9



            #endregion
            #region Exe_10



            #endregion
            #region Exe_11



            #endregion
            #region Exe_12



            #endregion
            #region Exe_13



            #endregion
            #region Exe_14



            #endregion
            #region Exe_15



            #endregion
            #region Exe_16



            #endregion
            #region Exe_17



            #endregion
            #region Exe_18



            #endregion
            #region Exe_19



            #endregion
            #region Exe_20



            #endregion
            #region Exe_21



            #endregion
            #region Exe_22



            #endregion
            #region Exe_23



            #endregion
            #region Exe_24



            #endregion
            #region Exe_25



            #endregion

            #region Exe_26

            ////Խնդիր_26: Գտնել տրված բնական թվից մեծ և 2 - ի աստիճան հանդիսացող ամենափոքր թիվը։

            //Console.WriteLine("Please input number");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int minNum = 1;

            //while (true)
            //{
            //    minNum *= 2;
            //    if (minNum > n)
            //        break;
            //}

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_27

            ////Խնդիր_27: Ներածել n բնական թիվը և տպել այդ թիվը՝ շրջելով և նրա ամեն մի թվանշանից հետո ավելացնելով 0 (օրինակ՝ 125 - 502010):

            //Console.WriteLine("Please input number");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[] nNunbers = new int[50];

            //for (int i = 0; n > 0; i++)
            //{
            //    nNunbers[i] = n % 10;
            //    n /= 10;
            //    Console.Write(nNunbers[i] + "0");
            //}
            //Console.WriteLine();

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_28

            ////Խնդիր_28:  Ներածել n թիվը։ Արտածել yes, եթե այն հավասար է իր թվանշանների գումարի կրկնապատիկին, no՝ հակառակ դեպքում։

            //Console.WriteLine("Please input number\n" + new string('-',15)); // for example 18-yes 
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(new string('-', 15));

            //int nClone = n;
            //int sum = 0;

            //for (int i = 0; nClone > 0; i++)
            //{
            //    sum += nClone % 10;
            //    nClone /= 10;
            //}

            //if(2*sum == n)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_29

            //Խնդիր_29: Եռանիշ թվի առաջին թվանշանը ջնջել։ Եթե ստացված թիվը բազմապատկվի 7 - ով, կստացվի սկզբնական թիվը։ Գտնել այդպիսի թվերը։

            //int num1;

            //for (int number = 100; number < 1000; number++) // number = abc = 100*a + 10*b + c
            //{
            //    num1 = 7*(number % 100); // num1 = 7*(10*b + c)

            //    if (num1 == number) 
            //        Console.WriteLine(number);
            //}

            ////for (int a = 1; a < 10; a++)
            ////{
            ////    for (int b = 0; b < 10; b++)
            ////    {
            ////        for (int c = 0; c < 10; c++)
            ////        {
            ////            if (30*b + 3*c == 50*a)
            ////            {
            ////                Console.WriteLine($"{a}{b}{c}");
            ////            }
            ////        }
            ////    }
            ////}

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_30

            ////Խնդիր_30: Գտնել բոլոր այն քառանիշ թվերը, որոնցում կրկնվող թվանշան չկա և որոնցում առաջին և վերջին երկու թվանշաններից կազմված թվերի տարբերությունը հավասար է այդ թվի թվանշանների գումարին։


            ////number = abcd = 1000a+100b+10c+d

            //int count = 1;

            //for (int a = 1; a < 9; a++)
            //{
            //    for (int b = 0; b < 9; b++)
            //    {
            //        for (int c = 0; c < 9; c++)
            //        {
            //            for (int d = 0; d < 9; d++)
            //            {
            //                if (a == b || a == c || a == d || b == c || b == d || c == d) //Թվի մեջ թվանշանների չկրկնվելու պայման։
            //                    continue;
            //                else
            //                    if (Math.Abs(10 * a + b - (10 * c + d)) == a + b + c + d)  // Math.Abs()-մոդուլ ստուգում է առաջին և վերջին երկու թվանշաններից կազմված թվերի տարբերությունը հավասա՞ր է այդ թվի թվանշանների գումարին։
            //                        Console.WriteLine($"Number{count++}: {a}{b}{c}{d}");
            //            }
            //        }
            //    }
            //}

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_31

            ////Խնդիր_31: Գրել ծրագիր, որը տրված n(2 < n < 100) բնական թվի համար արտածում է բնական թվերի հաջորդականություն հետևյալ կանոններով.
            ////          հաջորդականության առաջին թիվը n թիվն է։
            ////          հաջորդականության յուրաքանչյուր հերթական թիվ ստացվում է նախորդ p թվից և հավասար է 3 * p + 1, եթե p-ն կենտ է, և p / 2, եթե p-ն զույգ է:
            ////          Օրինակ, եթե n = 7, պետք է արտածվի հետևյալ հաջորդականությունը. 7 22 11 34 17 52 26 13 40 20 10 5 16 8 4 2 1 Ծրագիրը պետք է ավարտի իր աշխատանքը, եթե հաջորդականության հերթական տարրը “1”-ն է։

            //Console.WriteLine("Please input number in this range (2 < n < 100)");
            //int n;
            //do
            //{
            //    n = Int32.Parse(Console.ReadLine());

            //} while (n <= 2 || n >= 100);

            //Console.Write(new string('-',15) + "\n" + n + " ");

            //do
            //{
            //    if (n % 2 == 0)
            //    {
            //        n /= 2;
            //        Console.Write(n + " ");
            //    }
            //    else
            //    {
            //        n = 3 * n + 1;
            //        Console.Write(n + " ");
            //    }
            //} while (n != 1);

            //Console.WriteLine();

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_32

            ////Խնդիր_32: Տրված է N բնական թիվը։ Օգտագործելով մեկ ցիկլ հաշվել 1 + 1 / (1!) +1 / (2!) +1 / (3!) + … +1 / (N!) գումարը
            ////          (N!-ով նշանակված է 1 - ից N թվերի արտադրյալը։ Ստացված թիվը հանդիսանում է e հաստատունի մոտավոր արժեքը)։

            ////!!!

            //Console.WriteLine("Please input number");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double sum = 1;
            //double p = 1,t;

            //for (int nextNum = 1; nextNum <= n; nextNum++)
            //{
            //    t = nextNum * p;
            //    p = nextNum;
            //    sum = sum + (1 / t);
            //}

            //Console.WriteLine(sum);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_33

            ////Խնդիր_33: Տրված են X իրական և N բնական թվերը։ Գտնել 1 + X + X2 / (2!) + … +XN / (N!) արտահայտության արժեքը(N! = 1·2·…·N)։

            //double x = 2.1, n = 33, sum = 1;
            //int p = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    p *= i;
            //    sum += x*i / p;
            //}

            //Console.WriteLine(sum);

            ////delay
            //Console.ReadKey();

            #endregion
            #region Exe_34

            //Խնդիր_34: Տրված են X իրական և N բնական թվերը։ Գտնել X – X3 / (3!) +X5 / (5!) – … +(–1)N·X2·N + 1 / ((2·N + 1)!) արտահայտության արժեքը(N! = 1·2·…·N)։ Ստացված թիվը sin(X) - ի մոտավոր արժեքն է։

            double x = 2.1, n = 33, sum = 1;


            #endregion
            #region Exe_35



            #endregion
            #region Exe_36



            #endregion
        }
    }
}
