using Academy_Menagment_Library.Enums;
using Academy_Menagment_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academy_Menagment_Services
{
    public static class TrainerServices
    {
        public static void TrainerUi(List<Person> personList, List<Subject> subjects)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Enter Trainer Username");
            string username = Console.ReadLine();

            Console.WriteLine($"Enter Trainer Password");
            string password = Console.ReadLine();

            Trainer user = FindUser(personList, username, password);

            if(user == null)
            {
                Console.WriteLine("You are not a Trainer! Try Again");
                return;
            }
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"\n1)See all Students \n2)See Subjects \n3)Exit");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    PrintStudens(personList);
                    StudendSubject(personList);
                    return;
                case 2:
                    PrintSubjects(subjects);
                    return;
                case 3:
                    user.IsLogedIn = false;
                    LogInServices.LogIn(personList,subjects);
                    return;
                default:
                    Console.WriteLine("Please Choose between 1 and 4!");
                    return;
            }
        }


        public static Trainer FindUser(List<Person> personlist, string username, string password)
        {
            Trainer trainer;
            foreach (var item in personlist)
            {  
                if (item.UserName == username && item.PassWord == password && item.Role == Role.Trainer)
                {
                    item.IsLogedIn = true;
                    return trainer = (Trainer)item;
                }
            }
            Console.WriteLine("Wrong UserName or Password");
            return null;
        }

        public static List<Person> PrintStudens(List<Person> personList)
        {
            List<Person> studentList = personList
                                .Where(x => x.Role == Role.Student)
                                .ToList();
            Console.WriteLine("These are all the students in the University");
            studentList.ForEach(x => Console.WriteLine(x.FisrtName));
            return studentList;
        }

        public static void PrintSubjects(List<Subject> subjects)
        {
            Console.WriteLine("These are the Subjects and the number of Students atendig");
            subjects.ForEach(x => Console.WriteLine($"Subject: {x.Name}, number of studends atendig: {x.NumberOfStudents}"));
        }

        public static void StudendSubject(List<Person> personList)
        {
            List<Student> studentList = personList
                              .Where(x => x.Role == Role.Student)
                              .Select(x => (Student)x)
                              .ToList();

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Write Students Name to see his Subjects:");
            string studentName = Console.ReadLine();

            foreach (Student item in studentList)
            {
                if (studentName.ToLower() == item.FisrtName.ToLower())
                {
                    foreach (var keyValue in item.Subject)
                    {
                        Console.WriteLine($"Subject: {keyValue.Key.Name}, Grade: {keyValue.Value}");
                    }
                }
            }

        }
    }
}
