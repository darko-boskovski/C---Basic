using Academy_Menagment_Library.Enums;
using Academy_Menagment_Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Menagment_Services
{
    public static class StudentServices
    {
        public static void StudentUi(List<Person> personList, List<Subject> subjectList)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Enter Student Username");
            string username = Console.ReadLine();

            Console.WriteLine($"Enter Student Password");
            string password = Console.ReadLine();

            Student user = FindUser(personList, username, password);
            if(user == null)
            {
                Console.WriteLine("You are Not a Student! Please try Again.");
                return ;
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"\n1) See your Subjects \n2) Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PrintGrades(user);
                    Console.WriteLine("---------------------------------------------");
                    StudentUi(personList, subjectList);
                    return;
                case 2:
                    LogInServices.LogIn(personList, subjectList);
                    user.IsLogedIn = false;
                    return;
                default:
                    Console.WriteLine("Please Choose between 1 and 2");
                    break;
            }
        }
        public static Student FindUser(List<Person> personlist, string username, string password)
        {
            Student student;
            foreach (var item in personlist)
            {             
                if (item.UserName == username && item.PassWord == password && item.Role == Role.Student)
                {
                    item.IsLogedIn = true;
                    return student = (Student)item;
                }
            }
            Console.WriteLine("Wrong UserName or Password");
            return null;
        }

        public static void PrintGrades(Student user)
        { 
            Console.WriteLine($"{user.FisrtName}, these are the subjects you attend to and your grades:");
            Console.WriteLine("---------------------------------------------");
            foreach (var item in user.Subject)
            {
                Console.WriteLine($"Subject: '{item.Key.Name}', Grade: '{item.Value}' ");
            }

        }
    }
}
