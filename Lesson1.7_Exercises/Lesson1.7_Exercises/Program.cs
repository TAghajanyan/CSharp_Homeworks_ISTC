using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._7_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exe_1

            //Տրված են A և B բնական թվերը: Արտածել YES, եթե ա) նրանք երկուսն էլ կենտ են, բ) նրանցից գոնե մեկը կենտ է, գ) նրանցից ճիշտ մեկը կենտ է, դ) նրանք երկուսն էլ կենտ են կամ երկուսն էլ զույգ: Հակառալ դեպքում արտածել NO:

            //Console.WriteLine("Please input two numbers");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            ////a)
            //if (a % 2 != 0 && b % 2 != 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            /////b)
            //if (a % 2 != 0 || b % 2 != 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            ////c)

            //if (a % 2 != 0 && b % 2 == 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else if(a % 2 == 0 && b % 2 != 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////d)
            //if (a % 2 != 0 && b % 2 != 0 || a % 2 == 0 && b % 2 == 0) 
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Exe_2

            //Տրված են A, B և C ամբողջ թվերը: Արտածել YES, եթե  ա) երեքն էլ դրական են, 
            //                                                  բ) նրանցից գոնե մեկը դրական է,
            //                                                  գ) նրանցից ճիշտ մեկը դրական է,
            //                                                  դ) նրանցից ճիշտ երկուսը դրական են,
            //                                                  ե) նրանցից գոնե երկուսն իրար հավասար են,
            //                                                  զ) նրանցից գոնե երկուսն իրարից միայն նշանով են տարբերվում: 
            //                                                     Հակառակ դեպքում արտածել NO:

            //Console.WriteLine("Please input three numbers");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            ////a)
            //if (a > 0 & b > 0 & c > 0) 
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////b)
            //if (a > 0 || b > 0 || c > 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////c)
            //if (a > 0 && b <= 0 && c <= 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else if (b > 0 && a <= 0 && c <= 0)

            //{
            //    Console.WriteLine("YES");
            //}
            //else if (c > 0 && a <= 0 && b <= 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////d)

            //if (a > 0 && b > 0 && c <= 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else if (a > 0 && c > 0 && b <= 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else if (b > 0 && c > 0 && a <= 0) 
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////e)

            //if (a == b || a == c || b == c)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////f)
            //if (a == -1*b || a == -1*c || b == -1*c)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Exe_3

            //Տրված է A դրական ամբողջ թիվը: Արտածել YES, եթե այն ա) երկնիշ և զույգ թիվ է, բ) եռանիշ և կենտ թիվ է: Հակառալ դեպքում արտածել NO:
            //Console.WriteLine("Please input number");
            //int A = Convert.ToInt32(Console.ReadLine());

            ////a)
            //if (A > 9 && A < 100 && A % 2 == 0 || A > 100 && A < 1000 && A % 2 != 0)  
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}


            #endregion

            #region Exe_4

            //Տրված է A եռանիշ թիվը: Արտածել YES, եթե ա) նրա բոլոր թվանշանները տարբեր են, բ) նրա թվանշանները կազմում են աճող հաջորդականություն, գ) այն սիմետրիկ (պոլինդրոմ) է, այսինքն աջից ձախ և ձախից աջ նույն կերպ է կարդացվում: Հակառալ դեպքում արտածել NO:

            //int A = int.Parse(Console.ReadLine()); 
            //int firstDigit = A / 10;
            //int secondDigit = A / 100 % 10;
            //int thirdDigit = A % 10;               

            ////a)
            //if (firstDigit != secondDigit && firstDigit != thirdDigit && secondDigit != thirdDigit)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////b)
            //if (firstDigit < secondDigit && secondDigit < thirdDigit)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////c)
            //if (firstDigit < secondDigit && secondDigit < thirdDigit)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////d)
            //if (firstDigit == thirdDigit)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Exe_5

            //Տրված են x,y թվերը: Արտածել YES, եթե (x,y) կոորդինատներով կետն ընկած է կոորդինատային հարթության ա) երկրորդ քառորդում, բ) չորրորդ քառորդում, գ) երկրորդ կամ երրորդ քառորդում, դ) առաջին կամ երրորդ քառորդում: Հակառալ դեպքում արտածել NO:

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());


            ////a)
            //if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////b)
            //if (x > 0 && y < 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////c)
            //if (x < 0 && y != 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            ////d)
            //if (x > 0 && y > 0 || x < 0 && y < 0)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Exe_6

            //Տրված են x,y,x1,y1,x2,y2 ոչ բացասական ամբողջ թվերը: 
            //Արտածել YES, եթե (x,y) կոորդինատներով կետն ընկած է այն ուղղանկյան ներսում, 
            //որի ձախ վերևի անկյան կոորդինատներն են (x1,y1), իսկ աջ ներքևի անկյանը՝ (x2,y2), 
            //և որի կողմերը զուգահեռ են կոորդինատների առանցքներին: Հակառակ դեպքում արտածել NO:

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //if (x1 < x && y1 > y && x2 > x && y2 < y)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Exe_7

            //Տրված են a,b,c բնական թվերը: Արտածել YES, եթե a,b,c կողմերով եռանկյուն գոյություն ունի, NO`հակառակ դեպքում:

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a + b > c || a + c > b || b + c > a)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Exe_8

            //Տրված են a,b,c բնական թվերը, որոնք հանդիսանում են եռանկյան կողմերի երկարություններ: 
            //Արտածել YES, եթե a,b,c կողմերով եռանկյունը 
            //          ա) հավասարակողմ է, 
            //          բ) հավասարասրուն է,
            //          գ) ուղղանկյուն է: 
            //          Հակառալ դեպքում արտածել NO:

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            ////a)
            //if (a == b && a == c)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            ////b)
            //if (a == b && a != c || c == b && c != a || a == c && c != b)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}
            ////c)
            //if ((a*a + b*b == c*c) || (a * a + c * c == b * b) || (b * b + c * c == a * a))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Exe_9

            //Տրված են x,y ամբողջ թվերը, որոնք շախմատի տախտակի մի վանդակի կոորդինատներն են (այսինքն այդ թվերն ընկած են [1,8] հատվածում): 
            //Հաշվի առնելով, որ (1,1) վանդակը սև է, արտածել white, եթե (x,y) վանդակը սպիտակ է: Հակառակ դեպքում արտածել black:

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //if (x == 1 && y == 1 || x % 2 == 1 && y % 2 == 1 || x % 2 == 0 && y % 2 == 0)
            //{
            //    Console.WriteLine("Black");
            //}
            //else
            //{
            //    Console.WriteLine("White");
            //}

            #endregion

            #region Exe_10

            //Տրված են x1,y1 և x2,y2 թվազույգերը, որոնք շախմատի տախտակի երկու տարբեր վանդակների կոորդինատներ են(այսինքն այդ թվերն ընկած են[1, 8] հատվածում):
            //Արտածել YES, եթե այդ վանդակները նույն գույնի են, NO`հակառակ դեպքում:

            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());

            //if ((x1 + y1 % 2 == 0 && x2 + y2 % 2 == 0) || (x1 + y1 % 2 != 0 && x2 + y2 % 2 != 0))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Exe_11

            //Տրված են երեք ամբողջ թվեր: Արտածել ա) նրանցից փոքրագույնի արժեքը, բ) մեծությամբ երկրորդ թվի արժեքը, գ) մեծությամբ առաջին երկուսի գումարը:

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            ////a)
            //if (a <= b && a <= c)
            //{
            //    Console.WriteLine(a);
            //}
            //else if (b <= a && b <= c)
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //}

            ////b)
            //if (a <= b && a >= c || a >= b && a <= c)
            //{
            //    Console.WriteLine(a);
            //}
            //else if (b <= a && b >= c || b >= a && b <= c)
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //}

            ////C)
            //if (a <= b && a >= c || a >= b && a <= c)
            //{
            //    Console.WriteLine(a + c);
            //}
            //else if (b <= a && b >= c || b >= a && b <= c)
            //{
            //    Console.WriteLine(b + a);
            //}
            //else
            //{
            //    Console.WriteLine(c + b);
            //}

            #endregion

            #region Exe_12

            //Տրված են A,B,C իրական թվերը: Եթե նրանք դասավորված են աճման կամ նվազման կարգով, նրանց արժեքները կրկնապատկել,
            //հակառակ դեպքում յուրաքանչյուրի նշանը փոխել: Արտածել ստացված թվերը:

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (a < b && b < c || a > b && b > c)
            //{
            //    Console.WriteLine("New a: {0}\n New b: {1}\n New c is {2}", a * 2, b * 2, c * 2);
            //}
            //else
            //{
            //    Console.WriteLine("New a: {0}\n New b: {1}\n New c is {2}", a * (-1), b * (-1), c * (-1));
            //}
              
            #endregion

            #region Exe_13

            //Թվային առանցքի վրա տրված են A, B, C կետերը: Պարզել, թե B և C կետերից որն է ավելի մոտ A-ին, արտածել նրա արժեքը և հեռավորությունը A կետից:

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //if (Math.Abs(b - a) > Math.Abs(c - a))
            //{
            //    Console.WriteLine($"c >> a, c:{c}, distance:{ Math.Abs(c - a)}");
            //}
            //else
            //{
            //    Console.WriteLine($"b >> a, b:{b}, distance:{Math.Abs(b - a)}");
            //}

            #endregion

            #region Exe_14

            //Տրված են կետի կոորդինատները կոորդինատային հարթությունում: 
            //Եթե կետը համընկնում է կոորդինատների սկզբնակետի հետ արտածել 0: 
            //Եթե չի համընկնում կոորդինատների սկզբնակետի հետ, բայց ընկած է Ox կամ Oy առանցքներից որևէ մեկի վրա արտածել համապատասխանաբար, 1 կամ 2:
            //Եթե կետը ընկած չէ կոորդինատների առանցքների վրա` արտածել 3:

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //if (x == 0 && y == 0)
            //{
            //    Console.WriteLine(0);
            //}
            //else if (x != 0 && y == 0)
            //{
            //    Console.WriteLine(1);
            //}
            //else if (y != 0 && x == 0)
            //{
            //    Console.WriteLine(2);
            //}
            //else
            //{
            //    Console.WriteLine(3);
            //}

            #endregion

            #region Exe_15

            //Տրված է կետ, որն ընկած չէ կոորդինատների առանցքների վրա: Արտածել կոորդինատային քառորդի համարը, որում ընկած է այդ կետը:

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //if (x > 0 && y > 0)
            //{
            //    Console.WriteLine("First quadrant");
            //}
            //else if (x < 0 && y > 0)
            //{
            //    Console.WriteLine("Second quadrant");
            //}
            //else if (x < 0 && y < 0)
            //{
            //    Console.WriteLine("Third quadrant");
            //}
            //else
            //{
            //    Console.WriteLine("Fourth quadrant");
            //}

            #endregion

            #region Exe_16

            //Արտածել YES, եթե տրված(x, y) կետը պատկանում է(0, 0),(0, -1),(-1, 0) կետերով կառուցված եռանկյանը, NO` հակառակ դեպքում:

            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());

            //if (x < 0 && x > -1 && y < 0 && y > -1)
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //{
            //    Console.WriteLine("NO");
            //}

            #endregion

            #region Exe_17

            //Տրված են ուղղանկյան երեք գագաթների կոորդինատները: Ուղղանկյան կողմերը զուգահեռ են կոորդինատների առանցքներին: Արտածել չորրորդ կետի կոորդինատները:

            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //int x4 = x3;
            //int y4 = y1;

            //Console.WriteLine($"x4 is {x4}, y4 is {y4}");

            #endregion

            #region Exe_18

            //Ներածել n թիվը: Արտածել 1, եթե դրա միավորների թվանշանը 3 - ով մեծ է հարյուրավորների թվանշանից, հակառակ դեպքում՝ այդ թվի քառակուսին:

            //int n = int.Parse(Console.ReadLine());

            //int firstDigit = n / 100;
            //int thirdDigit = n % 10;

            //if (thirdDigit == firstDigit + 3) 
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine("The n to the power of 2 is: " + Math.Pow(n, 2));
            //}

            #endregion

            #region Exe_19

            //Տրված n> 7 բնական թվի համար գտնել այնպիսի a և b ամբողջ թվեր, որ 3a + 5b = n:  

            //int n = int.Parse(Console.ReadLine());
            //int a, b;

            //if (n % 5 == 0)
            //{
            //    Console.WriteLine("a = {0}, b = {1}", 0, b = n / 5);
            //}

            //else if (n % 5 == 1)
            //{
            //    Console.WriteLine("a = {0}, b = {1}", 2, b = (n - 6) / 5);
            //}

            //else if (n % 5 == 2)
            //{
            //    Console.WriteLine("a = {0}, b = {1}", 4, b = (n - 12) / 5);
            //}
            //else if (n % 5 == 3)
            //{
            //    Console.WriteLine("a = {0}, b = {1}", 1, b = (n - 3) / 5);
            //}
            //else
            //{
            //    Console.WriteLine("a = {0}, b = {1}", 3, b = (n - 9) / 5);
            //}

            #endregion

        }
    }
}
