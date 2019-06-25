using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1._5_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exe_1

            //Խնդիր 1։ Մուտք անել 2 թիվ և ՝
            //         1․Հաշվել առջին թվի արմատը
            //         2․Հաշվել այդ թվերի տարբերության մոդուլը
            //         3․Գտնել այդ թվերից մեծագույնի խորանարդը
            //         4․տպել առաջին թվի փոստֆիքսային ինկրեմենտը հավասար է արդյոք երկրորդ թվի պռեֆիքսային դեկրեմենտին

            //Console.WriteLine("Please input two numbers");

            //Console.Write("First number = ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Second number = ");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(new string('-', 20));

            ////1

            //double sqrtNum1 = Math.Sqrt(firstNumber);
            //Console.WriteLine("First number's root: " + sqrtNum1);
            //Console.WriteLine(new string('-', 20));

            ////--------------------------------------------------------

            ////2

            //int difNumbers = firstNumber - secondNumber;
            //int difAbs = Math.Abs(difNumbers);

            //Console.WriteLine("ABS of difference numbers: " + difAbs);
            //Console.WriteLine(new string('-', 20));

            ////--------------------------------------------------------

            ////3

            //int maxNum = Math.Max(firstNumber, secondNumber);
            //double cube = Math.Pow(maxNum, 3);

            //Console.WriteLine($"{maxNum}^3 = {cube}");
            //Console.WriteLine(new string('-', 20));

            ////--------------------------------------------------------

            ////4

            //Console.WriteLine("\nIf true => ++firstNumber = secondNumber--, else false");
            //Console.WriteLine((++firstNumber).Equals(secondNumber--));

            //Console.WriteLine($"PostFix of first number: {firstNumber}");
            //Console.WriteLine($"PreFix of second number: {++secondNumber}");

            ////delay
            //Console.ReadKey();

            #endregion

            #region Exe_2

            //Խնդիր 2: Մուտք անել 1 թիվ և հաշվել այդ թվի
            //          1.Մոդուլը,
            //          2.Արմատը
            //          3.Թվի և այդ թվի կեսի խորանարդների գումարը

            //Console.WriteLine("Please input a number");
            //double number = Convert.ToInt32(Console.ReadLine());

            ////1

            //double numberAbs = Math.Abs(number);
            //Console.WriteLine($"Abs of number: {numberAbs}");

            ////2

            //double root = Math.Sqrt(number);
            //Console.WriteLine($"Root of number: {root}");

            ////3

            //double halfNumber = number / 2;
            //double cubeNum = Math.Pow(number, 3);
            //double cubeHalfNum = Math.Pow(halfNumber, 3);
            //double sum = cubeNum + cubeHalfNum;

            //Console.WriteLine($"Summation : {sum}");

            ////delay
            //Console.ReadKey();

            #endregion 

        }
    }
}
