using System;

namespace SecondStage.Polymorphism
{
    class User : UsersBase
    {
        public void SignUp(string username, string password)
        {
            if (ChackUsername(username))
            {
                UsersBase client = new UsersBase();

                if (head == null)
                {
                    head = client;
                    tail = client;
                }
                else
                {
                    tail.NextUser = client;
                    tail = client;
                }

                SetUsrname_Password(client, username, password);
                CountUsers++;
                Console.WriteLine("Account successfully created: Username: " + username);
            }
            else
            {
                Console.WriteLine("An account with that username already exists: Username: " + username);
            }
        }

        public UsersBase LogIn(string username, string password)
        {
            UsersBase current = head;

            while (current != null)
            {
                if (username == current.Username && current.ChackPassword(password))
                {
                    return current;
                }
                current = current.NextUser;
            }
            return null;
        }

        public override bool Remove()
        {
            UsersBase pre = null;
            UsersBase cur = head;

            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            while (cur != null)
            {
                if (username == cur.Username && cur.ChackPassword(password))
                {
                    if (pre != null)
                    {
                        pre.NextUser = cur.NextUser;

                        if (cur.NextUser == null)
                        {
                            tail = pre;
                        }
                    }
                    else
                    {
                        head = head.NextUser;
                        if (head.NextUser == null)
                        {
                            tail = null;
                        }
                    }
                    CountUsers--;
                    return true;
                }
                pre = cur;
                cur = cur.NextUser;
            }
            return false;
        }

        private bool ChackUsername(string username)
        {
            UsersBase current = head;

            while (current != null)
            {
                if (username == current.Username)
                {
                    return false;
                }
                current = current.NextUser;
            }

            return true;
        }

        public void InfoAUser(string username) // overloading
        {
            UsersBase currnet = head;

            while (currnet != null)
            {
                if (currnet.Username == username)
                {
                    InfoAUser(currnet, username);
                    return;
                }
                currnet = currnet.NextUser;
            }
            Console.WriteLine("Wrong username");
        }

        public void InfoAUser(int id) // overloading
        {
            UsersBase currnet = head;

            while (currnet != null)
            {
                if (currnet.ID == id)
                {
                    InfoAUser(currnet, id);
                    return;
                }
                currnet = currnet.NextUser;
            }
            Console.WriteLine("Wrong ID");
        }

        public void Info()
        {
            UsersBase users = head;

            Console.WriteLine($"Users' count: {CountUsers}\n");
            for (int i = 0; i < CountUsers; i++)
            {
                Console.WriteLine($"User ID: {users.ID}");
                Console.WriteLine($"Username: {users.Username}");
                Console.WriteLine("Password: ******");
                Console.WriteLine(new string('-', 15));

                users = users.NextUser;
            }
        }
    }
}


