using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Inheritance.Homework
{
    class Man : Omnivore
    {
        private static int maxAge = 150;
        public string FirstName { get; private set; } = "John";
        public string LastName { get; private set; } = "Smith";
        public string Gender { get; private set; } = Animal.Gender;
        public int Age { get; private set; } = 18;

        public Man() : base(maxAge, "Hair and hide.")
        {
        }

        public Man(string firstName, string lastName, string gender, int age) : base(maxAge, "Hair and hide.")
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;

        }

        public void AboutMan()
        {
            Console.WriteLine("A man is a male human. The term man is usually reserved for an adult male, with the term boy being the usual term for a male child or adolescent.\n"+
                              "However, the term man is also sometimes used to identify a male human, regardless of age, as in phrases such as 'men's basketball'.");
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public void ChangeFirstName(string newFirstName)
        {
            FirstName = newFirstName;
        }

        public void ChangeLastName(string newLastName)
        {
            LastName = newLastName;
        }

        public void ChangeAge(int newAge)
        {
            Age = newAge;
        }
        
        public void ChangeGender(string newGender)
        {
            Gender = newGender;
        }

    }
}
