using MovieStoreLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MovieStoreLibrary.Models;
using MovieStoreLibrary.Enums;

namespace MovieStoreServices
{
    public static class MethodsServices
    {

        public static Member LogInMember(List<Member> memberList, string username, string password)
        {


            foreach (Member item in memberList)
            {
                if (item.UserName.ToLower() == username.ToLower() && item.Password == password) return item;
            }

            Console.WriteLine("Wrong UserName or Password!");
            Console.WriteLine("---------------------------------------------");
            return null;

        }
        public static void RoleAssing(Member member, List<Member> members, List<Movie> availableMovies, List<Movie> rentedMovies)
        {
            switch (member.Role.ToString())
            {
                case "Employee":
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"Welcome {member.Role}, {member.FirstName}");
                    while (EmployeeUI(members, availableMovies, rentedMovies)) ;
                    Console.WriteLine("---------------------------------------------");
                    break;
                case "User":
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine($"Welcome {member.Role}, {member.FirstName}");
                    while (UserInterface((User)member, availableMovies, rentedMovies)) ;
                    Console.WriteLine("---------------------------------------------");
                    break;
                default:
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("There is no such member");
                    Console.WriteLine("---------------------------------------------");
                    break;

            }
            Console.WriteLine("-------------------------");
        }


        public static void RentMovie(User user, List<Movie> movies, List<Movie> rentedMovies)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Please Enter the Movie Name you like Rent: ");
            Console.WriteLine("---------------------------------------------");
            SeeAvailableMovies(movies);
            string userInput = Console.ReadLine();

            Movie selected = movies.Where(item => item.Title.ToLower() == userInput.ToLower()).FirstOrDefault();

            if (selected == null) Console.WriteLine("There is no such movie in your renter Movie List");

            user.RentedMovies.Add(selected);
            rentedMovies.Add(selected);
            movies.Remove(selected);
            Console.WriteLine("-------------------------");
        }

        public static void ReturnMovie(User user, List<Movie> movies, List<Movie> rentedMovies)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Please Enter the Movie Name you would like to Return: ");
            SeeAvailableMovies(user.RentedMovies);
            string userInput = Console.ReadLine();

            Movie selected = user.RentedMovies.Where(item => item.Title.ToLower() == userInput.ToLower()).FirstOrDefault();

            if (selected == null) Console.WriteLine("There is no such movie");

            user.RentedMovies.Remove(selected);
            movies.Add(selected);
            rentedMovies.Remove(selected);
            Console.WriteLine("-------------------------");

        }


        public static void SeeRegisteredMembers(List<Member> members)
        {
            Console.WriteLine("---------------------------------------------");

            if (members == null) Console.WriteLine("There are no registered Users");
            int i = 1;
            members.ForEach(x =>
            {
                Console.Write($"{i}.");
                x.DisplayInfo();
                //Console.Write($"The Member is: {x.Role}, ");
                //Console.Write($" Date of registration: {x.DateOfRegistration}");
                Console.Write("\n");
                i++;
            });

            Console.WriteLine("---------------------------------------------");
        }

        public static void SeeAvailableMovies(List<Movie> movies)
        {
            Console.WriteLine("---------------------------------------------");
            int i = 1;
            movies.ForEach((x) =>
            {
                Console.WriteLine($"{i}. {x.Title}");
                i++;
            });
            Console.WriteLine("---------------------------------------------");
        }

        public static void SeeRentedMovies(List<Movie> movies)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("This is the list of your rented Movies");
            int i = 1;
            movies.ForEach((x) =>
            {

                Console.WriteLine($"{i}. {x.Title}");
                i++;
            });
            Console.WriteLine("---------------------------------------------");
        }
        public static void Register(List<Member> users)
        {

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Fill in the Required fielsd of the Register Form:\n");
            Console.Write("Enter The FirstName:");
            string firstname = Console.ReadLine();
            if (!TryParseError(firstname))
            {
                return;
            };
            Console.Write("Enter The LastName: ");
            string lastname = Console.ReadLine();
            if (!TryParseError(lastname))
            {
                return;
            };
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter UserName: ");
            string newUsername = Console.ReadLine();
            if (!TryParseError(newUsername))
            {
                return;
            };
            Console.Write("Enter Password: ");
            string newPassword = Console.ReadLine();
            Console.Write("Enter PhoneNumber: ");
            int phonenumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Todays Date in Format Year, Month, Day: ");

            DateTime dateOfRegistration = new DateTime();
            try
            {
                dateOfRegistration = DateTime.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please Enter Date in Format Year, Month, Day only: ");
                return;
            }

            Console.Write("Enter Role (User or Employee): ");
            string roleChoice = Console.ReadLine();
            if (!TryParseError(roleChoice))
            {
                return;
            };
            Role role = new Role();
            if (roleChoice.ToLower() == "user")
            {
                role = Role.User;
            }
            else if (roleChoice.ToLower() == "employee")
            {
                role = Role.Employee;
            }
            else
            {
                Console.WriteLine("Please Choese between 'User' and 'Employee' only.");
                return;
            }

            Console.Write("Enter MemberNumber: ");
            int memberNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Type of Subscription(Monthly or Anual): ");
            string typOfSubscription = Console.ReadLine();
            if (!TryParseError(typOfSubscription))
            {
                return;
            };
            TypeOfSubscription subscription = new TypeOfSubscription();
            if (typOfSubscription.ToLower() == "anual")
            {
                subscription = TypeOfSubscription.Anual;
            }
            else if (typOfSubscription.ToLower() == "monthly")
            {
                subscription = TypeOfSubscription.Monthly;
            }
            else
            {
                Console.WriteLine("Please Choese between 'Monthly' and 'Anual' only!");
                return;
            }

            Member user = LogInMember(users, newUsername, newPassword);
            if (user != null)
            {
                Console.WriteLine("Member already exists!");
                return;
            }


            users.Add(new User(firstname, lastname, age, newUsername, newPassword, phonenumber, dateOfRegistration, role, memberNumber, subscription));

            Console.WriteLine("Successfully registered!");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Users registered so far:");
            Console.WriteLine("---------------------------------------------");
            foreach (Member member in users)
            {
                Console.WriteLine($"Id: {member.DateOfRegistration}, Username: {member.UserName}");
            }
            Console.WriteLine("---------------------------------------------");
        }

        public static void RemoveMember(List<Member> members)
        {
            Console.WriteLine("-------------------------------------------------------------");
            if (members.Count == 1)
            {
                Console.WriteLine("There are no Users to Remove!!!");
                return;
            }
            Console.WriteLine("Please Enter Number of the Member you would like to remove: ");
            Console.WriteLine("-------------------------------------------------------------");
            List<Member> memberList = members
                                 .Where(x => x.Role.ToString() == "User")
                                 .ToList();

            List<User> userlist = memberList
                .Select(x => (User)x)
                .ToList();

            userlist.ForEach(x =>
            {
                Console.Write($"{x.MemberNumber}. ");
                x.DisplayInfo();
                Console.Write($" User Date of registration: {x.DateOfRegistration}");
                Console.Write("\n");
                Console.WriteLine("-------------------------------------------------------------");
            });

            int selectedMember;

            bool isNumber = int.TryParse(Console.ReadLine(), out selectedMember);
            if (userlist.Count == 0)
            {
                Console.WriteLine("There are no Users to Remove");
                return;
            }

            if (!isNumber)
            {
                Console.WriteLine("That was not a number! Try again.");
                Console.WriteLine("---------------------------------------------");
                return;
            }
            else

            {

                Console.WriteLine("---------------------------------------------");
                bool flag = false;
                foreach (User member in userlist)
                {
                    User user = member;

                    if (user.Role.ToString() == "Employee")
                    {
                        Console.WriteLine("Cannot Delete an Employee!!!");
                        return;
                    }
                    if (user.MemberNumber == selectedMember)
                    {
                        members.Remove(user);
                        Console.WriteLine("Succsessfully removed the member");
                        flag = true;
                        return;
                    }

                }
                if (!flag)
                {
                    Console.WriteLine($"There is no User with such MemberNumber.");
                }
                Console.WriteLine("---------------------------------------------");
            }

        }

        public static bool EmployeeUI(List<Member> users, List<Movie> availableMovies, List<Movie> rentedMovies)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Choose:\n1)See All Movies Available \n2)See All Rented Movies \n3)See All Registered Members  \n4)Remove Member \n5)Register Member \n6)Exit to Main Menu");
            int choice;
            bool isNumber = int.TryParse(Console.ReadLine(), out choice);
            if (!isNumber)
            {
                Console.WriteLine("That was not a number! Try again.");
                Console.WriteLine("---------------------------------------------");
                return true;
            }
            switch (choice)
            {
                case 1:
                    SeeAvailableMovies(availableMovies);
                    return true;
                case 2:
                    SeeRentedMovies(rentedMovies);
                    return true;
                case 3:
                    SeeRegisteredMembers(users);
                    return true;
                case 4:
                    RemoveMember(users);
                    return true;
                case 5:

                    try
                    {
                        Register(users);
                    }
                    catch (Exception ex)
                    {

                        if (ex.ToString().Contains("Input string was not in a correct format."))
                        {
                            Console.WriteLine($"Please Enter Numbers Only Information");
                            EmployeeUI(users, availableMovies, rentedMovies);
                        }

                    }

                    return true;
                case 6:
                    return false;
                default:
                    Console.WriteLine("Please number between 1 and 5");
                    Console.WriteLine("---------------------------------------------");
                    return true;

            }
        }



        public static bool UserInterface(User member, List<Movie> availableMovies, List<Movie> rentedMovies)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Choose:\n1)See Your Info \n2)See Available Movies \n3)Rent A Movie \n4)See Movies You've rented \n5) Return A Movie \n6)Exit to Main Menu");
            int choice;
            bool isNumber = int.TryParse(Console.ReadLine(), out choice);
            if (!isNumber)
            {
                Console.WriteLine("That was not a number! Try again.");
                Console.WriteLine("---------------------------------------------");
            }
            switch (choice)
            {
                case 1:
                    member.DisplayInfo();
                    return true;
                case 2:
                    SeeAvailableMovies(availableMovies);
                    return true;
                case 3:
                    RentMovie(member, availableMovies, rentedMovies);
                    return true;
                case 4:
                    Console.WriteLine("---------------------------------------------");
                    member.RentedMovies.ForEach(x => Console.WriteLine(x.Title));
                    return true;
                case 5:
                    ReturnMovie(member, availableMovies, rentedMovies);
                    return true;
                case 6:
                    return false;
                default:
                    Console.WriteLine("Please enter 1 or 2");
                    Console.WriteLine("---------------------------------------------");
                    return true;

            }

        }

        public static bool TryParseError(string userInput)
        {

            bool tryParse = int.TryParse(userInput, out int newNumber);
            if (tryParse)
            {
                Console.WriteLine("Please Enter Letters Only");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool MainInterface(List<Member> allMembers, List<Movie> availableMovies, List<Movie> rentedMovies)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------Welcome to the Movie Store----------");
            Console.WriteLine("Please Enter Your Username or Press X to Exit");
            Console.WriteLine("---------------------------------------------");
            string username = Console.ReadLine();


            if (TryParseError(username))
            {

                if (username.ToLower() == "x")
                {
                    Console.WriteLine("You Have Exited the Store, Have a Nice Day.");
                    Console.WriteLine("---------------------------------------------");
                    return false;
                }
                else
                {
                    Console.WriteLine("Please Enter Your Password:");
                    string password = Console.ReadLine();

                    Member loggedUser = LogInMember(allMembers, username, password);
                    if (loggedUser == null) return true;

                    RoleAssing(loggedUser, allMembers, availableMovies, rentedMovies);
                    Console.WriteLine("---------------------------------------------");
                    return true;
                }
            }
            return true;
        }
    }
}
