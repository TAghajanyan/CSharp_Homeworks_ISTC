using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._6_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Exe_1

            //Input two numbers and check that, is square of the first number larger, smaller or equal to the square of the second number.
            //In 2 ways(is-else, switch-case)

            //Console.WriteLine("Please input two numbers");
            //Console.Write("First number: ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Second number: ");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());

            //double firstPow = Math.Pow(firstNumber, 2);

            ////First variant (if-else)

            //if (firstPow > secondNumber)
            //{
            //    Console.WriteLine($"{firstNumber}^2 > {secondNumber}");
            //}
            //else if (firstPow < secondNumber)
            //{
            //    Console.WriteLine($"{firstNumber}^2 < {secondNumber}");
            //}
            //else
            //{
            //    Console.WriteLine($"{firstNumber}^2 == {secondNumber}");
            //}


            ////Second variant (switch-case)

            //int check = firstPow > secondNumber ? 1 : (firstPow < secondNumber ? 2 : 0);

            //switch (check)
            //{
            //    case 0:
            //        Console.WriteLine($"{firstNumber}^2 == {secondNumber}");
            //        break;

            //    case 1:
            //        Console.WriteLine($"{firstNumber}^2 > {secondNumber}");
            //        break;

            //    case 2:
            //        Console.WriteLine($"{firstNumber}^2 < {secondNumber}");
            //        break;
            //}

            //Console.ReadKey();

            #endregion

            #region Exe_2

            //Please input four numbers and check, is the first number pow to second number equals the third number pow to forth number?
            //For example number = abcd, check    Math.Pow(a, b) == Math.Pow(c, d).

            //Console.WriteLine("Please input two numbers");
            //Console.Write("First number: ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Second number: ");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Third number: ");
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Forth number: ");
            //int forthNumber = Convert.ToInt32(Console.ReadLine());

            //double firstPow = Math.Pow(firstNumber, secondNumber);
            //double secondPow = Math.Pow(thirdNumber, forthNumber);

            //if (firstPow == secondPow)
            //{
            //    Console.WriteLine($"{firstNumber}^{secondNumber} == {thirdNumber}^{forthNumber}");
            //}
            //else if (firstPow < secondPow)
            //{
            //    Console.WriteLine($"{firstNumber}^{secondNumber} < {thirdNumber}^{forthNumber}");
            //}
            //else
            //{
            //    Console.WriteLine($"{firstNumber}^{secondNumber} > {thirdNumber}^{forthNumber}");
            //}

            //Console.ReadKey();

            #endregion

            #region Exe_3


            //Task of the solar system

            Console.WriteLine("Please input number of 1 to 8");
            do
            {
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.WriteLine("First planet of the solar system is Mercury");
                        break;
                    case 2:
                        Console.WriteLine("Second planet of the solar system is Venus");
                        break;
                    case 3:
                        Console.WriteLine("Third planet of the solar system is Earth");
                        break;
                    case 4:
                        Console.WriteLine("Forth planet of the solar system is Mars");
                        break;
                    case 5:
                        Console.WriteLine("Fifth planet of the solar system is Jupiter");
                        break;
                    case 6:
                        Console.WriteLine("Sixth planet of the solar system is Saturn");
                        break;
                    case 7:
                        Console.WriteLine("Seventh planet of the solar system is Uranus");
                        break;
                    case 8:
                        Console.WriteLine("Eighth planet of the solar system is Neptune");
                        break;
                    default:
                        Console.WriteLine("Wrong number please input number of 1 to 8");
                        break;
                }

            } while (true);

            #endregion 

        }
    }
}
