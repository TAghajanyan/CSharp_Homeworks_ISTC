using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1_Exercises_SecondPart
{

    class Human
    {
        private string firstName;
        private string lastName;
        private int age;
        private int weight;
        private string gender;

        public Human(string firstName, string lastName, int age, int weight, string gender)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.weight = weight;
            this.gender = gender;
        }

        public void PrintName()
        {
            Console.WriteLine($"Name is {firstName} {lastName}");
        }

        public void PrintAge()
        {
            Console.WriteLine($"Age is {age}");
        }

        public void PrintWeight()
        {
            Console.WriteLine($"Weight is {weight}");
        }

        public void PrintGender()
        {
            Console.WriteLine($"Gender is {gender}");
        }

        public void PrintAllInfo()
        {
            Console.WriteLine($"Name is {firstName} {lastName}");
            Console.WriteLine($"Age is {age}");
            Console.WriteLine($"Weight is {weight}");
            Console.WriteLine($"Gender is {gender}");
        }

        public void ChangeFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public void ChangeLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public void ChangeAge(int newAge)
        {
            age = newAge;
        }

        public void ChangeWeight(int newWeight)
        {
            weight = newWeight;
        }

        public void ChangeGender(string newGender)
        {
            gender = newGender;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Tigran", "Aghajanyan", 19, 60, "Male");
            human1.PrintName();
            human1.PrintAge();
            human1.PrintWeight();
            human1.PrintGender();
            Console.WriteLine(new string('-', 20));

            human1.PrintAllInfo();
            Console.WriteLine(new string('-', 20));

            Console.Write("Input new first name: ");
            human1.ChangeFirstName(Console.ReadLine());

            Console.Write("Input new last name: ");
            human1.ChangeLastName(Console.ReadLine());

            Console.Write("Input new age: ");
            human1.ChangeAge(int.Parse(Console.ReadLine()));

            Console.Write("Input new weight: ");
            human1.ChangeWeight(int.Parse(Console.ReadLine()));

            Console.Write("Input new Gender: ");
            human1.ChangeGender(Console.ReadLine());

            Console.WriteLine(new string('-', 20));

            Console.WriteLine("All info after changes.");
            Console.WriteLine(new string('-', 20));

            human1.PrintAllInfo();

            Console.ReadKey();
        }
    }
}
