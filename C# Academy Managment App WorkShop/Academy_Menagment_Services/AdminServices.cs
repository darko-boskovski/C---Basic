using Academy_Menagment_Library.Enums;
using Academy_Menagment_Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Menagment_Services
{
    public class AdminServices
    {

        public static void AdminUi(List<Person> personList, List<Subject> subjects)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Enter Your Admin Username");
            string username = Console.ReadLine();

            Console.WriteLine($"Enter Your Admin Password");
            string password = Console.ReadLine();

            Admin user = FindUser(personList, username, password);
            if (user == null)
            {
                Console.WriteLine("You are not an Admin! Please Try Again");
                return;
            }

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"\n1)Add Admin/Trainer/Student \n2)Remove Admin/Trainer/Student \n3)Exit");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    CreateUser(personList);
                    return;
                case 2:
                    Console.WriteLine($"Enter The Username of the person you would like to remove.");
                    personList.ForEach(x => Console.WriteLine($"Person Name {x.FisrtName}, UserName {x.UserName}, Person Role: {x.Role}"));
                    string personName = Console.ReadLine();
                    RemoveUser(personList, user, personName);
                    return;
                case 3:
                    user.IsLogedIn = false;
                    LogInServices.LogIn(personList, subjects);
                    return;
                default:
                    Console.WriteLine("Please Choose between 1 and 4!");
                    return;
            }

        }


        public static Admin FindUser(List<Person> personlist, string username, string password)
        {
            Admin admin;
            foreach (Person item in personlist)
            {
                if (item.UserName == username && item.PassWord == password && item.Role == Role.Admin)
                {
                    item.IsLogedIn = true;
                    return admin = (Admin)item;
                }
            }

            Console.WriteLine("Wrong UserName or Password");
            return null;
        }

        public static void CreateUser(List<Person> personList)
        {

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Enter the Person Name");
            string firstname = Console.ReadLine();

            Console.WriteLine($"Enter the Person LastName");
            string lastname = Console.ReadLine();

            Console.WriteLine($"Enter the Person Username");
            string username = Console.ReadLine();

            Console.WriteLine($"Enter the Person Password");
            string password = Console.ReadLine();

            Console.WriteLine($"Enter the Person Role");
            string roleChoice = Console.ReadLine();
            Role role;
            if (roleChoice.ToLower() == "student")
            {
                role = Role.Student;
            }
            else if (roleChoice.ToLower() == "trainer")
            {
                role = Role.Trainer;
            }
            else if (roleChoice.ToLower() == "admin")
            {
                role = Role.Admin;
            }
            else
            {
                Console.WriteLine("There is no such role");
                return;
            }

            personList.Add(new Student(firstname, lastname, username, password, role));

        }

        public static void RemoveUser(List<Person> personList, Admin currentUser, string username)
        {
            if (currentUser.UserName.ToLower() == username.ToLower())
            {
                Console.WriteLine("You cannot delete yourself");
                return;
            }
            else
            {
                foreach (var item in personList)
                {
                    if(item.UserName.ToLower() == username.ToLower())
                    {
                        personList.Remove(item);
                        return;
                    }
                }
            }


        }

        public static void Menu()
        {
           
        }

    }
}
