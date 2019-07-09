using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2._1_Exercises
{
    class Animal
    {
        private string name;
        private string gender;
        private int age;

        public Animal()
        {
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public Animal(string name, string gender) : this(name)
        {
            this.gender = gender;
        }

        public Animal(string name, string gender, int age) : this(name, gender)
        {
            this.age = age;
        }

        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                name = value;
            }
        }

        public string Gender
        {
            get
            {
                return this.gender;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public void ChangeName(string newName)
        {
            Name = newName;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal tiger = new Animal("Oscar", "Male", 5);
            Console.WriteLine($"Tiger's name is {tiger.Name} \nAge is {tiger.Age} \nGender is {tiger.Gender}");

            Console.WriteLine(new string('-', 25));

            Animal dog = new Animal("Daisy", "Female", 3);
            Console.WriteLine($"Dog's name is {dog.Name} \nAge is {dog.Age} \nGender is {dog.Gender}");

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("Change tiger name press '1'\nChange dog name press '2'\nFor nothing press any else key.");

            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    {
                        Console.WriteLine("Please input new name for tiger");
                        tiger.ChangeName(Console.ReadLine());
                        Console.WriteLine("Now tiger's name is " + tiger.Name);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Please input new name for dog");
                        dog.ChangeName(Console.ReadLine());
                        Console.WriteLine("Now dog's name is " + dog.Name);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Bye!");
                        break;
                    }
            }
        }
    }
}
