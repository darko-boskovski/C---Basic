using MovieStoreLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary.Models

//    ### Task 3
//Create class `Movie` that will have the following properties
//* `Title`
//* `Description`
//* `Year`
//* `Genre` => enum
//* `Price` => private property
//* `SetPrice` => method that should set the price based on the Year property:
// If the Year is below 2000 the price should be a random number between 100-200
// If the Year is between 2000 and 2010 the price should be random number between 200-300
// If the Year is above 2010 the price should be random number between 300-500

{
    public class Movie
    {
  
        public Movie()
        {

        }

        public Movie(string title,string description, DateTime year, Genre genre)
        {
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
        public Genre Genre { get; set; }
        private int Price { get; set; }

        public void SetPrice()
        {
           Random random = new Random();
            if (Year.Year < 2000)
            {
                Price = random.Next(100, 200);
            }
            if (Year.Year >= 2000 && Year.Year <= 2010)
            {
                Price = random.Next(200, 300);
            }
            if (Year.Year > 2010)
            {
                Price = random.Next(300, 500);
            }
        }



    }
}
