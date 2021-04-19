using System;
using System.Collections.Generic;
using System.Linq;

namespace Class_08_Exercice
{

    public class Song
    {
        public string Title { get; set; }
        public int Length { get; set; }
        public Genre Genre { get; set; }

    }
    public enum Genre
    {

        Rock,
        Hip_Hop,
        Tehno,
        Classical

    }
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavouriteMusic { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person()
        {

        }
        public Person(int id, string firstName, string lastName, int age, Genre favouriteMusic)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavouriteMusic = favouriteMusic;
            FavouriteSongs = new List<Song>();
        }
        public void GetFavSongs()
        {
            if (FavouriteSongs.Count == 0)
            {
                Console.WriteLine($"{FirstName} Hates Muisc");
            }
            else
            {
                Console.WriteLine($"This is the list of {FirstName} favourite songs: ");
                foreach (var song in FavouriteSongs)
                {
                    Console.WriteLine(song.Title);
                }
                Console.WriteLine("--------------------------------------");
            }
        }

    }


    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hello Colection Exercise!");

            Dictionary<long, string> phoneBook = new Dictionary<long, string>
            {
                {70123456, "Pero"},
                {70654321, "Blazo" },
                {71123456, "Risto" },
                {75123456, "Trajce" },
                {76654321, "Petko" }
            };

            while (true)
            {

                Console.WriteLine("Please Enter the Name you are looking for:");

                string userInput = Console.ReadLine();

                if (!phoneBook.ContainsValue(userInput))
                {
                    Console.WriteLine("There is no such Person");
                    Console.WriteLine("--------------------------------------");
                }
                else
                {
                    foreach (var item in phoneBook)
                    {
                        if (item.Value == userInput)
                        {
                            Console.WriteLine($"{item.Value}: {item.Key}");
                        }
                    }
                    Console.WriteLine("--------------------------------------");
                }

                if (userInput == "x") break;

            }


            Song song01 = new Song() { Title = "Makarena", Genre = Genre.Classical, Length = 6 };
            Song song02 = new Song() { Title = "Barabarabrabra", Genre = Genre.Classical, Length = 4 };
            Song song03 = new Song() { Title = "SeciPero", Genre = Genre.Hip_Hop, Length = 3 };
            Song song04 = new Song() { Title = "Gangam Style", Genre = Genre.Classical, Length = 4 };
            Song song05 = new Song() { Title = "Lambada", Genre = Genre.Rock, Length = 3 };
            Song song07 = new Song() { Title = "Macho Man", Genre = Genre.Classical, Length = 6 };
            Song song08 = new Song() { Title = "Bad Bad Thing", Genre = Genre.Classical, Length = 4 };
            Song song09 = new Song() { Title = "Shout", Genre = Genre.Hip_Hop, Length = 3 };
            Song song10 = new Song() { Title = "Gone with the sin", Genre = Genre.Classical, Length = 4 };
            Song song11 = new Song() { Title = "La Grudge", Genre = Genre.Rock, Length = 3 };


            List<Song> songlist01 = new List<Song>() { song01, song02, song03, song04, song05, song07, song08, song09, song10, song11 };


            Person person01 = new Person(01, "Risto", "Ristovski", 25, Genre.Hip_Hop);
            Person person02 = new Person(02, "Blazo", "Blazovski", 26, Genre.Classical);
            Person person03 = new Person(01, "Jerry", "Jerrison", 27, Genre.Hip_Hop);
            Person person04 = new Person(02, "Marija", "Marovska", 28, Genre.Tehno);
            Person person05 = new Person(01, "Jane", "Janevski", 29, Genre.Hip_Hop);
            Person person06 = new Person(02, "Stefan", "Stefkovski", 30, Genre.Rock);

            List<Person> personList = new List<Person>() { person01, person02, person03, person04, person05, person06 };



            person01.FavouriteSongs.Add(song05);


            foreach (var item in personList)
            {
                if (item.FirstName == "Jerry")
                {
                    item.FavouriteSongs = songlist01
                                          .Where(x => x.Title.StartsWith('B'))
                                          .ToList();
                    item.GetFavSongs();
                }


            };

            foreach (var item in personList)
            {
                if (item.FirstName == "Marija")
                {
                    item.FavouriteSongs = songlist01
                                          .Where(x => x.Length < 6)
                                          .ToList();
                    item.GetFavSongs();
                }

            };

            foreach (var item in personList)
            {
                if (item.FirstName == "Jane")
                {
                    item.FavouriteSongs = songlist01
                                          .Where(x => x.Genre == Genre.Rock)
                                          .ToList();
                    item.GetFavSongs();
                }

            };

            foreach (var item in personList)
            {
                if (item.FirstName == "Jane")
                {
                    item.FavouriteSongs = songlist01
                                          .Where(x => x.Genre == Genre.Hip_Hop && x.Length <= 3)
                                          .ToList();
                    item.GetFavSongs();
                }

            };

            List<Person> personWithMostSongs = personList
                                        .Where(x => x.FavouriteSongs.Count > 4)
                                        .ToList();

         Console.WriteLine("These are all the person that have more than 4 favourite songs");

            personWithMostSongs.ForEach(x =>
            {      
                Console.WriteLine(x.FirstName);
            });










            Console.ReadLine();
        }
    }
}
