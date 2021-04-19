using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Menagment_Library.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public int NumberOfStudents { get; set; }

        public Subject()
        {

        }
        public Subject(string name, int numberOfStudents = 0)
        {
            Name = name;
            NumberOfStudents = numberOfStudents;
        }
    }
}
