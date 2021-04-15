using System;
using MovieStoreLibrary.Models;
using MovieStoreLibrary.Enums;
using System.Collections.Generic;
using MovieStoreServices;
using MovieStoreLibrary;

namespace MovieStoreApp
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Movie Objects and Lists
            Movie movie01 = new Movie("Memento", "A man with short-term memory loss attempts to track down his wife's murderer.", new DateTime(2000, 05, 25), Genre.Mystery);

            Movie movie02 = new Movie("Identity", "Stranded at a desolate Nevada motel during a nasty rain storm, ten strangers become acquainted with each other when they realize that they're being killed off one by one.", new DateTime(2003, 04, 25), Genre.Thriller);

            Movie movie03 = new Movie("Eyes Wide Shut", "A New York City doctor embarks on a harrowing, night-long odyssey of sexual and moral discovery after his wife reveals a painful secret to him.", new DateTime(1999, 07, 16), Genre.Mystery);

            Movie movie04 = new Movie("Mr.Nobody", "A boy stands on a station platform as a train is about to leave. Should he go with his mother or stay with his father? Infinite possibilities arise from this decision. As long as he doesn't choose, anything is possible.", new DateTime(2013, 09, 26), Genre.Science_Fiction);

            Movie movie05 = new Movie("Grandma's Boy", "A thirty-five-year-old video game tester has to move in with his grandma and her two old lady roommates.", new DateTime(2006, 01, 06), Genre.Comedy);


            List<Movie> moviesList = new List<Movie>() { movie01, movie02, movie03 };

            List<Movie> rentedMovies = new List<Movie>() { movie05, movie04 };
            #endregion

            #region Member Objects and Lists
            Employee employee01 = new Employee("Pero", "Perovski", 31, "pero", "pero123", 077111222, new DateTime(2021, 1, 1), Role.Employee, 10);

            User user01 = new User("Blazo", "Blazovski", 25, "blazo", "blazo123", 077222333, new DateTime(2021, 03, 20), Role.User, 15, TypeOfSubscription.Monthly);
            user01.RentedMovies.Add(movie05);
            User user02 = new User("Bob", "Bobski", 24, "bob", "bob123", 077333444, new DateTime(2021, 02, 10), Role.User, 64, TypeOfSubscription.Anual);
            user02.RentedMovies.Add(movie04);


            List<Member> memberList = new List<Member>() { user01, user02, employee01 };
            #endregion






            while (MethodsServices.MainInterface(memberList, moviesList, rentedMovies)) ;



            Console.ReadLine();
        }
    }
}
