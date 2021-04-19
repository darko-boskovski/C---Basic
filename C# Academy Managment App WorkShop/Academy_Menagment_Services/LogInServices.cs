using Academy_Menagment_Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Academy_Menagment_Services;
using System.Collections;
using System.Linq;
using Academy_Menagment_Library.Enums;

namespace Academy_Menagment_Services
{
    public static class LogInServices
    {
        public static bool LogIn(List<Person> personList, List<Subject> subjectList)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"\n1) Login as Admin \n2) Login as Trainer \n3) Login as Student \n4) Exit");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    AdminServices.AdminUi(personList,subjectList);
                    return true;
                case 2:
                    TrainerServices.TrainerUi(personList, subjectList);
                    return true;
                case 3:
                    StudentServices.StudentUi(personList,subjectList);           
                    return true;
                case 4:
                    return false;
                default:
                    Console.WriteLine("Please Choose between 1 and 4!");
                    return true;
            }             

        }





    }
}
