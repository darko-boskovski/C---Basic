using Academy_Menagment_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Menagment_Library.Models
{
    public class Admin : Person
    {
        public Admin()
        {

        }
        public Admin(string firstname, string lastname, string username, string password, Role role) : base(firstname, lastname, username, password, role)
        {

        }

        public void AddPerson(List<Person> listOfPerson, Person person)
        {
            if (UserName == person.UserName)
            {
                Console.WriteLine("The UserName Allready exist");
                return;
            }
            else
            {
                listOfPerson.Add(person);
            }
        }
        public void RemovePerson(List<Person> listOfPerson, Person person)
        {
            foreach (Person item in listOfPerson)
            {
                if (UserName == person.UserName)
                {
                    Console.WriteLine("You can not delete yourself!");
                    return;
                }
            }
            listOfPerson.Remove(person);
        }

    }
}
