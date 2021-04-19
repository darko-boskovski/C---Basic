using Academy_Menagment_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Menagment_Library.Models
{


    public class Person
    {
     

        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool  IsLogedIn { get; set; }

        public Role Role { get; set; }

        public Person()
        {

        }
        public Person(string firstname, string lastname, string username, string password, Role role = 0)
        {
            FisrtName = firstname;
            LastName = lastname;
            UserName = username;
            PassWord = password;
            IsLogedIn = false;
            Role = role;

        }
    }
}