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

        }
    }
}
