using Academy_Menagment_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Menagment_Library.Models
{
    public class Student : Person
    {
        public Dictionary<Subject, Grade> Subject { get; set; }
        public Student()
        {

        }
        public Student(string firstname, string lastname, string username, string password, Role role) : base(firstname, lastname, username, password, role)

        {

            Subject = new Dictionary<Subject, Grade>() { };
        }

        public void AddSubject(Subject subject, Grade grade)
        {
            if (subject != null && grade != 0)
            {
                Subject.Add(subject, grade);
            }
            else
            {
                Subject = new Dictionary<Subject, Grade>() { };
            }


        }
    }
}
