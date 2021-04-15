using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreLibrary.Enums;

namespace MovieStoreLibrary.Models
{
    public class User : Member
    {

        public User(string firstname, string lastname, int age, string username, string password, int phonenumber, DateTime dateOfRegistration, Role role,int memberNumber, TypeOfSubscription subscription, int v = 0, List<Movie> rentedMovies = null) : base(firstname, lastname, age, username, password, phonenumber, dateOfRegistration, role)
        {
            MemberNumber = memberNumber;
            Subscription = subscription;
            if(rentedMovies != null)
            {
               RentedMovies = rentedMovies;
            }else
            {
                RentedMovies = new List<Movie>();
            }
            
        }

      

        public int MemberNumber { get; set; }
        public TypeOfSubscription Subscription { get; set; }
        public List<Movie> RentedMovies { get; set; }

        public override void DisplayInfo()
        {
            DateTime endRegistration;
            base.DisplayInfo();

            if (Subscription.ToString() == "Monthly")
            {
                endRegistration =  DateOfRegistration.AddMonths(1);
                Console.Write($"Type of Subscription: {Subscription}, The Subscription ends on: {endRegistration}\n");
            }
            if (Subscription.ToString() == "Anual")
            {   
                endRegistration = DateOfRegistration.AddYears(1);
                Console.Write($"Type of Subscription: {Subscription}, The Subscription ends on: {endRegistration}\n");
            }    
        }
    }
}
