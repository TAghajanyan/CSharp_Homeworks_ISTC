using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._4_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exe_1

            //Խնդիր 1: կոնսոլից մուտք անել եռանիշ թիվ և հաշվել այդ թվի թվանշանների միջին թվաբանականը


            //Console.WriteLine("Please input three digit number");
            //int number = Convert.ToInt32(Console.ReadLine()); //For example 123
            //int sum, result;

            //int firstNum = number / 100; // 123 / 100 = 1;
            //int secondNum = number / 10 % 10; // 123/10 = 12, 12 % 10 = 2;
            //int thirdNum = number % 10; // 123 % 10 = 3;

            //sum = firstNum + secondNum + thirdNum; //1 + 2 + 3 = 6;
            //result = sum / 3; //  6 / 3 = 2;

            //Console.WriteLine($"Result = {result}"); // Result = 2;

            ////delay
            //Console.ReadKey();

            #endregion

            //----------------------------            

            #region Exe_2

            //Խնդիր 2: կոնսոլից մուտք անել հինգ բացասական թիվ և հաշվել այդ թվերի արտադրյալի մոդուլը


            //Console.WriteLine("Please enter 5 negative numbers");

            //Console.Write("First number = ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Second number = ");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("third number = ");
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("forth number = ");
            //int forthNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("fifth number = ");
            //int fifthNumber = Convert.ToInt32(Console.ReadLine());

            //int product = firstNumber * secondNumber * thirdNumber * forthNumber * fifthNumber;

            //int result = Math.Abs(product);

            //Console.WriteLine($"ABS Value = {result}");

            ////delay
            //Console.ReadKey();

            #endregion

            //----------------------------

            #region Exe_3

            //Խնդիր 3: Ավանդ եք ներդնում ամսական 1.3 % շահութաբերությամբ ։ Հաշվել ինչքան ընդհանուր գումար կստացվի 3 տարի հետո։ Կոնսոլից մուտք եք անում գումարի չափը և տոկոսադրույքը:

            Console.WriteLine("Please input amount:");
            int amount = Convert.ToInt32(Console.ReadLine());

            float percent = 1.3f;
            float lastAmount = amount * percent / 100 * 36; 

            Console.WriteLine(lastAmount);

            #endregion

        }
    }
}
