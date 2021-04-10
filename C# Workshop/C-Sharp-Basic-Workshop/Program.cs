using System;

namespace C_Sharp_Basic_Workshop
{
    //          Creata a program that will represent User Login and Register functionality
    //        - The User should have two options : 
    //            1) Log in 
    //            2)Register
    //        - If a user is successfully logged in, it should show his messages
    //            e.g.Your messages: "his message here"
    //        - Note: Provide basic Login and Register validation
    //        */


    public class User
    {
        public User()
        {

        }
        public User(string username, string password, int userId, string userText)
        {
            UserName = username;
            Password = password;
            Id = userId;
            TextMessage = userText;
        }
        public string UserName;
        public string Password;
        public string TextMessage;
        public int Id;
    }

    class Program
    {
        static bool Login(string username, string password, Array arrUsers)
        {
            foreach (User user in arrUsers)
            {
                if (username.ToLower() == user.UserName.ToLower() && password == user.Password.ToLower())
                {
                    Console.WriteLine($"Hello {user.UserName} have successfully logged in !!! Your message is '{user.TextMessage}'");

                    return true;
                }

            }
            Console.WriteLine("There is no such student");
            return false;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            User[] arrUsers = new User[]
        {
            new User("Pero","pero123",10,"C# is Awsome"),
            new User("Blazo","blazo123",17, "Workshop's are hard"),
            new User("Risto","risto123",20, "Risto is Samardziev"),
        };


            while (true)
            {
                Console.WriteLine("Enter 1 to Login or enter 2 to Register");

                bool isSuccesfull = int.TryParse(Console.ReadLine(), out int input);

                if (!isSuccesfull)
                {
                    Console.WriteLine("Plsease enter numbers only");
                    continue;
                }
                if (input != 1 && input != 2)
                {
                    Console.WriteLine("Please choose between 1 or 2!");
                }
                if (input == 1)
                {
                    Console.WriteLine("Write your username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Enter your password:");
                    string password = Console.ReadLine();

                    if (Login(username, password, arrUsers))
                    {
                        Console.WriteLine($"Here is the list of all Loged in User:");

                        foreach (User user in arrUsers)
                        {

                            Console.WriteLine($"{ user.UserName}");
                        }
                    }

                }

                else if (input == 2)
                {
                    Console.WriteLine("Enter your username:");
                    string username = Console.ReadLine();

                    Console.WriteLine("Enter your password:");
                    string password = Console.ReadLine();

                    Console.WriteLine("Enter your id:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter your message:");
                    string userMessage = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(username) && username.Length < 3 || String.IsNullOrWhiteSpace(password) && password.Length < 3)
                    {
                        Console.WriteLine("The Username or Password are too short");
                    }

                    Array.Resize(ref arrUsers, arrUsers.Length + 1);
                    arrUsers[arrUsers.Length - 1] = new User(username, password, id, userMessage);
                }
                else
                {
                    Console.WriteLine("Try again !!!");
                    continue;
                }

                if (input == 333) break;
            }

            Console.ReadLine();
        }
    }
}
