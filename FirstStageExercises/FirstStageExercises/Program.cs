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

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_7

            ////Խնդիր_7: Տրված են A և B(A < B) ամբողջ թվերը։ Գտնել[A, B] հատվածին պատկանող բոլոր ամբողջ թվերի գումարը։

            //part1:
            //Console.Write("Please input A & B (A < B)\nA=");
            //int A = Convert.ToInt32(Console.ReadLine());

            //Console.Write("B=");
            //int B = Convert.ToInt32(Console.ReadLine());

            //if (A >= B)
            //    goto part1;

            //int sumNumbers = 0;
            //for (int i = A; i <= B; i++)
            //    sumNumbers += i;

            //Console.WriteLine("Sum of numbers = " + sumNumbers);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_8

            ////Խնդիր_8: Տրված են A և B(A < B) ամբողջ թվերը։ Գտնել[A, B] հատվածին պատկանող 3 - ին պատիկ առաջին թիվը։

            //part1:
            //Console.Write("Please input A & B (A < B)\nA=");
            //int A = Convert.ToInt32(Console.ReadLine());

            //Console.Write("B=");
            //int B = Convert.ToInt32(Console.ReadLine());

            //if (A >= B)
            //    goto part1;

            //int firstNun = 0;

            //for (int i = A; i <= B; i++)
            //{
            //    if (i%3 == 0)
            //    {
            //        firstNun = i;
            //        break;
            //    }
            //}

            //Console.WriteLine(firstNun);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_9

            ////Խնդիր_9: Տրված է N բնական թիվը։ Հաշվել 1 + 1 / 2 + 1 / 3 + … +1 / N գումարը(այն իրական թիվ է)։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());
            //double sum = 0;

            //for (double i = 1; i <= N; i++)
            //{
            //    sum += 1 / i;
            //}

            //Console.Write("The expression value = {0}", sum);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_10

            ////Խնդիր_10: Տրված է N բնական թիվը։ Հաշվել N2 +(N + 1)2 + (N + 2)2 + … +(2·N)2 գումարը։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;

            //for (int i = 0; i <= N; i++)
            //{
            //    sum += (N + i) * 2;
            //}

            //Console.Write("The expression value = {0}", sum);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_11

            ////Խնդիր_11: Տրված է N բնական թիվը։ Հաշվել 1.1 · 1.2 · 1.3 · … արտադրյալը(արտադրիչների քանակը N է)։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //double value = 1.1;
            //double nextVlaue = 1.1;
            //for (int i = 1; i <= N; i++)
            //{
            //    nextVlaue += 0.1;
            //    value *= nextVlaue;
            //}

            //Console.Write("The expression value = {0}", value);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_12

            ////Խնդիր_12: Տրված է N բնական թիվը։ Հաշվել 1.1 – 1.2 + 1.3 – … արտահայտության արժեքը։ Նշանափոխ գումարելիների քանակը N է։ Պայմանական(if) օպերատոր չօգտագործել։

            //Console.WriteLine("Please input any number");
            //double N = Convert.ToDouble(Console.ReadLine());

            //double elem = 0.1;
            //double sum = 1.1;
            //double nextValue = 1.1;
            //for (int i = 1; i < N; i++)
            //{
            //    elem *= -1;
            //    nextValue = -1 * nextValue + elem;
            //    sum += nextValue;
            //}

            //Console.Write("The expression value = {0}", sum);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_13

            //Խնդիր_13: Տրված է N բնական թիվը։ Հաշվել այդ թվի քառակուսին՝ օգտագործելով հետևյալ բանաձևը.N2 = 1 + 3 + 5 + … +(2 * N – 1). 
            //          Հերթական գումարելին ավելացնելիս արտածել գումարի ընթացիկ արժեքը(արդյունքում կարտածվեն 1 - ից մինչև N բոլոր թվերի քառակուսիները)։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int N2 = 1;
            //int nextValue;
            //Console.Write(N2);
            //for (int i = 2; i <= N; i++)
            //{
            //    nextValue = i * 2 - 1;
            //    N2 += nextValue;
            //    Console.Write(" + " + nextValue); 
            //}

            //Console.WriteLine(" = " + N2);

            ////delay
            //Console.ReadKey();


            #endregion

            #region Exe_14

            //Խնդիր_14: Ներածել n թիվը։ Արտածել yes, եթե այն հավասար է իր թվանշանների գումարի կրկնապատիկին, no՝ հակառակ դեպքում։

            //GoTo Exe_28;

            #endregion

            #region Exe_15

            //Խնդիր_15: Եռանիշ թվի առաջին թվանշանը ջնջել։ Եթե ստացված թիվը բազմապատկվի 7-ով, կստացվի սկզբնական թիվը։ Գտնել այդպիսի թվերը։

            //GoTo Exe_29;

            #endregion

            #region Exe_16

            ////Խնդիր_16: Հաշվել տրված բնական թվի թվանշանների գումարը, քանակը, արտադրյալը։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int sumNumbers = 0, count = 0, productNumbers = 1,nextNum;

            //do
            //{
            //    nextNum = N % 10;
            //    sumNumbers += nextNum;
            //    productNumbers *= nextNum;
            //    count++;
            //    N /= 10;

            //} while (N % 10 != 0);

            //Console.WriteLine(new string('-',20) + "\nSum of numbers = {0}\nProduct of numbers = {1}\nCount = {2}", sumNumbers, productNumbers, count);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_17

            //Խնդիր_17:Գտնել տրված թվի կենտ թվանշաններից ամենափոքրը։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int minValue;
            //int nextValue;
            //do
            //{
            //    do
            //    {
            //        minValue = N % 10;
            //        N /= 10;

            //    } while (minValue % 2 == 0);

            //    nextValue = N % 10;

            //    if (nextValue % 2 != 0) 
            //    {
            //        if (nextValue < minValue)
            //        {
            //            minValue = nextValue;
            //        }
            //    }

            //    N /= 10;

            //} while (N % 10 != 0);

            //Console.WriteLine("The smallest odd digit is " + minValue);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_18

            ////Խնդիր_18: Հաշվել տրված թվի 4 - ից մեծ կենտ թվանշանների գումարը։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int nextNumner;
            //do
            //{
            //    nextNumner = N % 10;
            //    if (nextNumner % 2 != 0 && nextNumner > 4)
            //        sum += nextNumner;
            //    N /= 10;

            //} while (N % 10 != 0);

            //Console.WriteLine("Sum = " + sum);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_19

            ////Խնդիր_19: Հաշվել տրված թվի 7 - ից փոքր զույգ թվանշանների արտադրյալը։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());
            //int product = 1;
            //int nextNumner;
            //do
            //{
            //    nextNumner = N % 10;
            //    if (nextNumner % 2 == 0 && nextNumner < 7)
            //        product *= nextNumner;
            //    N /= 10;

            //} while (N % 10 != 0);

            //Console.WriteLine("Sum = " + product);


            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_20

            //Խնդիր_20: Գտնել տրված թվի ամենամեծ և ամենափոքր թվանշանների տարբերության քառակուսին։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int maxNumber = N % 10;
            //N /= 10;
            //int minNumber = N % 10;

            //int nextNumber;
            //int result;

            //if (maxNumber < minNumber)
            //{
            //    int a = maxNumber;
            //    maxNumber = minNumber;
            //    minNumber = a;
            //}

            //do
            //{
            //    N /= 10;
            //    nextNumber = N % 10;
            //    if (nextNumber > maxNumber)
            //    {
            //        maxNumber = nextNumber;
            //    }
            //    else
            //    {
            //        if (nextNumber < minNumber)
            //        {
            //            minNumber = nextNumber;
            //        }
            //    }

            //    result = (maxNumber - minNumber) * (maxNumber - minNumber);

            //} while (N / 10 != 0);

            //Console.WriteLine("Result = " + result);

            //////delay
            //Console.ReadKey();

            #endregion

            #region Exe_21

            ////Խնդիր_21: Արտածել տրված թվի բոլոր բաժանարարները։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    if (N % i == 0) 
            //    {
            //        Console.Write(i + "  ");
            //    }
            //}

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_22

            ////Խնդիր_22: Հաշվել տրված թվի բոլոր բաժանարարների գումարը։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= N; i++)
            //{
            //    if (N % i == 0)
            //    {
            //        sum += i;
            //        Console.Write(i + "  ");
            //    }
            //}

            //Console.WriteLine("Sum = " + sum);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_23

            //Խնդիր_23: Հաշվել տրված թվի բոլոր բաժանարարների գումարի և դրանց քանակի քանորդը։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //double sum = 0;
            //double count = 0;

            //for (int i = 1; i <= N; i++)
            //{
            //    if (N % i == 0)
            //    {
            //        sum += i;
            //        count++;
            //        Console.Write(i + "  ");
            //    }
            //}
            //Console.WriteLine("\nCount = " + count);
            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("Result = " + sum / count);

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_24

            //Խնդիր_24: Պարզել, հանդիսանում է, արդյոք, տրված թիվը 3 - ի աստիճան։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());

            //int count = 0;

            //do
            //{
            //    count++;
            //    N /= 3;
            //} while (N / 3 != 0 && N % 3 == 0);


            //if (N == 1)
            //{
            //    Console.WriteLine("N = 3^" + count);
            //}
            //else
            //{
            //    Console.WriteLine("This number is not three degrees");
            //}

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_25

            ////Խնդիր_25: Տրված n > 0 ամբողջ թվի համար հաշվել 2 - ի ամենամեծ աստիճանը, որը չի գերազանցում n - ը։

            //Console.WriteLine("Please input any number");
            //int N = Convert.ToInt32(Console.ReadLine());
            //double result = 0 ;
            //int count = 0;
            //for (int i = 0; i < N/2; i++)
            //{
            //    if (Math.Pow(2,i) <= N)
            //    {
            //        result = Math.Pow(2, i);
            //        count = i;
            //    }
            //}

            //Console.WriteLine("Result: " + result + " = 2^" + count);

            //////delay
            //Console.ReadKey();

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

        }
    }
}
