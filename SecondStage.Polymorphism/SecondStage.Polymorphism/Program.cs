using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.Polymorphism
{

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            user.SignUp("Tigran", "123456");
            user.SignUp("Tigran", "123gh56");
            user.SignUp("Vahram", "787979");
            user.SignUp("Erik", "224716");
            user.SignUp("Robert", "174865");
            user.SignUp("Karlen", "175462");

            Console.Write("\nLog in\nUsername: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            UsersBase userLogin = user.LogIn(username, password);

            if (userLogin != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully log in");
                Console.WriteLine("Your ID: " + userLogin.ID);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong username or password");
            }

            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(new string('-',15));

            UsersBase usersBase = user; // UpCast
            usersBase.Info();


            Console.WriteLine("Please input username and password for remove ");
            if (user.Remove()) // override method
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Successfully removed.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong username or password!!!");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n" + new string('-',15));

            user = (User)usersBase; // DownCast
            user.Info();


            user.InfoAUser("Vahram");
            Console.WriteLine(new string('-',15));
            user.InfoAUser(123546);

            Console.ReadKey();
        }
    }
}
