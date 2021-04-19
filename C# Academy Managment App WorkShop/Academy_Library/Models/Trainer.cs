using Academy_Menagment_Library.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Menagment_Library.Models
{
    public class Trainer : Person
    {
        public Trainer()
        {

        }
        public Trainer(string firstname, string lastname, string username, string password, Role role) : base(firstname, lastname, username, password, role)
        {

        }

       
    }
}
