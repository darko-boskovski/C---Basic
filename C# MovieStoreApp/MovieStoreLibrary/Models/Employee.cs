using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Models
{

    //### Task 2

    //    Create the classes `Employee` and `User` which will inherit from the `Member` class and will have its own properties and methods.Make sure they have `constructors` with all the properties from the parent constructor plus their own, if they are not private (use base)
    //##### *Employee*
    //* `Salary` => not accessible property from outside, which should have default value when instantiating an object from Employee class of 300 eur
    //* `HoursPerMonth`
    //* `Bonus`
    //* `SetBonus` => method that will dynamically set Bonus to the Employee by checking: 
    //if the employee has HoursPerMonth > 160 hours it should be 30% (0.3)
    //If the employee has HoursPerMonth< 160 then it should be set to null (check nullable integer)
    //* `SetSalary` => method that should set the value to the Salary property by doing the multiplication of HoursPerMonth * Bonus
    //##### *User*
    //* `MemberNumber` (something like an ID) 
    //* `TypeOfSubscription` (Monthly, Annually) => enum or class (it’s up to you)
    //* `Movies` => array of Movie type

    public class Employee : Member
    {
        public Employee() 
        {

        }
        public Employee(string firstname, string lastname, int age, string username, string password, int phonenumber, DateTime dateOfRegistration, Role role, int hoursPerMonht)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            UserName = username;
            Password = password;
            PhoneNumber = phonenumber;
            DateOfRegistration = dateOfRegistration;
            Role = role;
            HoursPerMonth = hoursPerMonht;

            if (Bonus != 0)
            {
                Salary = Salary * Bonus;
            }
            else { Salary = 300; }

        }

        private double Salary { get; set; }
        public int HoursPerMonth { get; set; }
        public double Bonus { get; set; }


        public double SetBonus()
        {
            if (HoursPerMonth > 160)
            {
                Bonus += 0.3;
            }
            if (HoursPerMonth < 160)
            {
                Bonus = 0;
            }
            return Bonus;
        }

        public void SetSalary()
        {
            Salary = HoursPerMonth * Bonus;
        }
        
    }


}
