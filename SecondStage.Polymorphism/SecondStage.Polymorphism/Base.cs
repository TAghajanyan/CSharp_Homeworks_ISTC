using System;

namespace SecondStage.Polymorphism
{
    class UsersBase : HeadAndTail
    {
        public int ID { get; } = 100000;
        public string Username { get; private set; }
        private string password;
        public UsersBase NextUser { get; set; }  // protected UsersBase NextUser { get; set; } /// chi erevum User class-i 44 toxum //// xi? 
        public int CountUsers { get; protected set; }

        public bool ChackPassword(string password)
        {
            return password == this.password;
        }

        static Random random = new Random();

        public UsersBase()
        {
            ID = random.Next(111111, 999999);
        }

        public void SetUsrname_Password(UsersBase client, string username, string password)
        {
            client.Username = username;
            client.password = password;
        }

        protected void InfoAUser(UsersBase position, string username)
        {
            Console.WriteLine("{0}'s info", username);
            Console.WriteLine($"{username} ID: {position.ID}");
            Console.WriteLine($"{username} Password: {position.password}");
        }

        protected void InfoAUser(UsersBase position, int id)
        {
            Console.WriteLine("{0}, info with this ID", id);
            Console.WriteLine($"{id} Username: {position.Username}");
            Console.WriteLine($"{id} Password: {position.password}");
        }


        public void Info()
        {
            UsersBase users = head;

            Console.WriteLine("\nUsers all info!");
            Console.WriteLine($"\nUsers' count: {CountUsers}\n");

            while (users != null)
            {
                Console.WriteLine($"User ID: {users.ID}");
                Console.WriteLine($"Username: {users.Username}");
                Console.WriteLine($"Password: {users.password}");
                Console.WriteLine(new string('-', 15));
                users = users.NextUser;
            }
        }

        public virtual bool Remove()
        {
            head = null;
            tail = null;
            CountUsers = 0;

            return true;
        }
    }
}
