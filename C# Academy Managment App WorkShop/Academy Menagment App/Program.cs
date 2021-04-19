using Academy_Menagment_Library.Enums;
using Academy_Menagment_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Academy_Menagment_Services;

namespace Academy_Menagment_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy Menagment App!");
            Console.WriteLine("----------------------------------------------");

            #region Declaring and Initializing Objects and Lists
            Admin admin01 = new Admin("Pero", "Perovski", "pero", "pero123", Role.Admin);

            Trainer trainer01 = new Trainer("Tase", "Tasevski", "tase", "tase123", Role.Trainer);
            Trainer trainer02 = new Trainer("Vase", "Vasevski", "vase", "vase123", Role.Trainer);


            Subject english = new Subject("English", 7);
            Subject mathematics = new Subject("Mathematics", 7);
            Subject history = new Subject("History", 8);
            Subject geography = new Subject("Georaphy", 7);
            Subject arts = new Subject("Arts", 8);
            Subject sports = new Subject("Sports", 8);
            Subject biology = new Subject("Biology", 8);
            Subject chemistry = new Subject("Chemistry", 6);

            List<Subject> subjectList = new List<Subject>() { english, mathematics, history, geography, arts, sports, biology, chemistry };

            Student student01 = new Student("Blazo", "Blazovski", "blazo", "blazo123", Role.Student);
            Student student02 = new Student("Risto", "Ristovski", "risto", "risto123", Role.Student);
            Student student03 = new Student("Stanko", "Stankovski", "stanko", "stanko123", Role.Student);
            Student student04 = new Student("Petko", "Petkovski", "petko", "petko123", Role.Student);
            Student student05 = new Student("Ace", "Acevski", "ace", "ace123", Role.Student);
            Student student06 = new Student("Trpana", "Trpevska", "trpa", "trpa123", Role.Student);
            Student student07 = new Student("Mimoza", "Mimozovska", "mimi", "mimi123", Role.Student);
            Student student08 = new Student("Petra", "Petrovska", "petra", "petra123", Role.Student);

            student01.AddSubject(english, Grade.nine);
            student01.AddSubject(mathematics, Grade.seven);
            student01.AddSubject(history, Grade.seven);
            student01.AddSubject(geography, Grade.eight);
            student01.AddSubject(arts, Grade.nine);
            student01.AddSubject(sports, Grade.ten);
            student01.AddSubject(biology, Grade.seven);
            student01.AddSubject(chemistry, Grade.six);

            student02.AddSubject(english, Grade.six);
            student02.AddSubject(mathematics, Grade.nine);
            student02.AddSubject(history, Grade.six);
            student02.AddSubject(geography, Grade.seven);
            student02.AddSubject(arts, Grade.five);
            student02.AddSubject(sports, Grade.nine);
            student02.AddSubject(biology, Grade.six);


            student03.AddSubject(english, Grade.nine);
            student03.AddSubject(mathematics, Grade.seven);
            student03.AddSubject(history, Grade.seven);
            student03.AddSubject(geography, Grade.eight);
            student03.AddSubject(arts, Grade.five);
            student03.AddSubject(sports, Grade.nine);
            student03.AddSubject(biology, Grade.six);


            student04.AddSubject(arts, Grade.five);
            student04.AddSubject(sports, Grade.nine);
            student04.AddSubject(biology, Grade.six);
            student04.AddSubject(chemistry, Grade.seven);
            student04.AddSubject(english, Grade.nine);
            student04.AddSubject(mathematics, Grade.seven);
            student04.AddSubject(history, Grade.seven);
            student04.AddSubject(geography, Grade.eight);


            student05.AddSubject(english, Grade.six);
            student05.AddSubject(mathematics, Grade.eight);
            student05.AddSubject(history, Grade.seven);
            student05.AddSubject(geography, Grade.eight);
            student05.AddSubject(arts, Grade.nine);
            student05.AddSubject(sports, Grade.ten);
            student05.AddSubject(biology, Grade.seven);
            student05.AddSubject(chemistry, Grade.seven);

            student06.AddSubject(english, Grade.six);
            student06.AddSubject(mathematics, Grade.nine);
            student06.AddSubject(history, Grade.six);
            student06.AddSubject(geography, Grade.seven);
            student06.AddSubject(arts, Grade.ten);
            student06.AddSubject(sports, Grade.nine);
            student06.AddSubject(biology, Grade.six);
            student06.AddSubject(chemistry, Grade.seven);


            student07.AddSubject(history, Grade.six);
            student07.AddSubject(geography, Grade.eight);
            student07.AddSubject(arts, Grade.five);
            student07.AddSubject(sports, Grade.nine);
            student07.AddSubject(biology, Grade.six);
            student07.AddSubject(chemistry, Grade.seven);

            student08.AddSubject(arts, Grade.five);
            student08.AddSubject(sports, Grade.nine);
            student08.AddSubject(biology, Grade.six);
            student08.AddSubject(chemistry, Grade.seven);
            student08.AddSubject(english, Grade.nine);
            student08.AddSubject(mathematics, Grade.seven);
            student08.AddSubject(history, Grade.seven);


            List<Person> personList = new List<Person>() { admin01, trainer01, trainer02, student01, student02, student03, student04, student05, student06, student07, student08 };

            var studentList = personList
                                            .Where(x => x.Role == Role.Student)
                                            .Select(x => (Student)x)
                                            .ToList();



            #endregion

            while (true)
            {
                try
                {
                    while (LogInServices.LogIn(personList, subjectList)) ;
                }
                catch
                {
                    Console.WriteLine("You Did Something Wrong, The Application works Great ;) !!!");
                }
            }




            Console.ReadLine();

        }
    }
}
