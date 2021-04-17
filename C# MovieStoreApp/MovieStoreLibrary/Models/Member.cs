using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary
{

//**Create a `Member` class that will hold all the following properties, which are common for every user:**
//*	`FirstName`
//*	`LastName`
//*	`Age`
//*	`UserName`
//*	`Password`
//*	`PhoneNumber`
//*	`DateOfRegistration`
//*	`Role` => enum or class (it’s up to you)
//*	`DisplayInfo` => Method that will display info about every user, in format:
//`#firstName #lastName | Registered on: #dateOfRegistration`


    public class Member
    {
        public Member()
        {

        }

        public Member(string firstname, string lastname, int age, string username, string password, int phonenumber, DateTime dateOfRegistration, Role role)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            UserName = username;
            Password = password;
            PhoneNumber = phonenumber;
            DateOfRegistration = dateOfRegistration;
            Role = role;

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Role { get; set; }
        public string V { get; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("---------------------------------------------");
            Console.Write($"Firstname: {FirstName}, Lastname: {LastName}, The Member is: {Role}, Registered on: {DateOfRegistration}, ");
        }

    }
}
