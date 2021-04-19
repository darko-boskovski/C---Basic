using LINQ.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Homework
{
    class Program
    {
        public static List<Artist> Artists { get; set; }
        public static List<Album> Albums { get; set; }
        public static List<Song> Songs { get; set; }
        static void Main(string[] args)
        {
            Init();// this method fills the arrays above with data

            // - print the mass of the earth on July 1895 XD
            /*
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░████████░░░░░░░░░
                ░░███████░░░░░░░░░░███▒▒▒▒▒▒▒▒███░░░░░░
                ░░█▒▒▒▒▒▒█░░░░░░░███▒▒▒▒▒▒▒▒▒▒▒▒███░░░░
                ░░░█▒▒▒▒▒▒█░░░░██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░
                ░░░░█▒▒▒▒▒█░░░██▒▒▒▒▄██▄▒▒▒▒▄██▄▒▒▒███░
                ░░░░░█▒▒▒█░░░█▒▒▒▒▒▒████▒▒▒▒████▒▒▒▒▒██
                ░░░█████████████▒▒▒▒▀██▀▒▒▒▒▀██▀▒▒▒▒▒██
                ░░░█▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒██
                ░██▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒██▒▒▒▒▒▒▒▒▒██▒▒▒▒██
                ██▒▒▒███████████▒▒▒▒▒██▒▒▒▒▒▒▒██▒▒▒▒▒██
                █▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒███████▒▒▒▒▒▒▒██
                ██▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░
                ░█▒▒▒███████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██░░░
                ░██▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█░░░░░
                ░░████████████░░░████████████████░░░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░▄█████▄░▄███████▄░▄███████▄░██████▄░░
                ░░██▒▒▒▒█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░██▒▒▒▒▒░██▒▒▒▒▒██░██▒▒▒▒▒██░██▒▒▒██░░
                ░░██▒▒▒▀█░███▒▒▒███░███▒▒▒███░██▒▒▒██░░
                ░░▀█████▀░▀███████▀░▀███████▀░██████▀░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░▄█████░██▒▒▒▒██▀░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▀▒▒▒░██▒▒▒██░░░░░░
                ░░░░██▒▒▒▒░██▒▒▒██░██▒▒▒▒░█████▀░░░░░░░
                ░░░░██▒▒▒▒░██▄▒▄██░██▄▒▒▒░██▒▒▒██░░░░░░
                ░░░░▀█████░▀█████▀░▀█████░██▒▒▒▒██▄░░░░
                ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░
            */

            // QUERIES!
            Console.WriteLine("---------------------- LINQ Special Edition ----------------------\n");
            // - how many Songs start with the letter 'a' (case insensitive)
            int songsWithLetter_a = Songs
                                    .Where(x => x.Name.StartsWith('a')).Count();

            Console.WriteLine($"Number of Songs start with the letter 'a' (case insensitive): '{songsWithLetter_a}'");
            Console.WriteLine("----------------------------------------------------------------------------------------------");


            // - how many artists end with letter 'a' (case insensitive)

            int songsWithLetter_A = Songs
                                   .Where(x => x.Name.ToLower().StartsWith('a')).Count();

            Console.WriteLine($"Number of Songs start with the letter 'a' (case insensitive): '{songsWithLetter_A}'");
            Console.WriteLine("----------------------------------------------------------------------------------------------");


            // - whats the name of the song with longest duration

            Song songWithLongestDuration = Songs
                                             .FirstOrDefault(x => x.Duration == Songs.Select(X => X.Duration).Max());

            Console.WriteLine($"The name of the song with longest duration is '{songWithLongestDuration.Name}' duration: {songWithLongestDuration.Duration} seconds.");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // - whats the total Duration of all Songs

            int totalDurationOfAllSongs = Songs
                                             .Select(x => x.Duration)
                                             .Sum();


            Console.WriteLine($"The total Duration of all Songs: {totalDurationOfAllSongs} seconds. or {totalDurationOfAllSongs / 60} minutes and {totalDurationOfAllSongs % 60 } seconds");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // - how many albums have Songs longer than 300 seconds


            List<Album> albumsWithLongSongs = new List<Album>();

            foreach (Album item in Albums)
            {
                if (item.Songs.Where(x => x.Duration > 300) != null)
                {
                    albumsWithLongSongs.Add(item);
                }
            }

            Console.WriteLine($"Number of Albums that have Songs longer than 300 seconds is {albumsWithLongSongs.Count}");
            Console.WriteLine("----------------------------------------------------------------------------------------------");




            // - print the names of the artists(separated with "--"), that have more than one album of PopRock genre

            List<Artist> nameOfTheArtists = Artists
                                            .Where(x => x.Albums.Where(X => X.Genre == Genre.PopRock).Count() > 1)
                                            .ToList();

            Console.WriteLine($"The names of the artists that have more than one album of PopRock genre");
            nameOfTheArtists.ForEach(x => Console.Write($"{x.FullName} -- "));
            Console.WriteLine("\n----------------------------------------------------------------------------------------------");



            // - print the name of the album that has highest Average duration of a song


            Album albumHighestAvarage = Albums
                                       .OrderByDescending(x => x.Songs.Select(y => y.Duration)
                                       .Average())
                                       .FirstOrDefault();

            Console.WriteLine($"the name of the album that has highest Average duration of a song is: {albumHighestAvarage.Name}");
            Console.WriteLine("----------------------------------------------------------------------------------------------");





            // - how many characters has the song that has the shortest Duration

            Song shortestDuration = Songs
                                   .OrderBy(x => x.Duration)
                                   .FirstOrDefault();

            Console.WriteLine($"The song {shortestDuration.Name }is the shortest Duration has: {shortestDuration.Name.Length}characters  whit duration of : {shortestDuration.Duration}seconds");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // - print the name and the genre of the album that has most songs

            Album albumMostSongs = Albums
                                   .OrderByDescending(x => x.Songs.Count)
                                   .FirstOrDefault();

            Console.WriteLine($"The name of the album that has most songs is: {albumMostSongs.Name}, and its genre is: {albumMostSongs.Genre} ");
            Console.WriteLine("----------------------------------------------------------------------------------------------");

            // - print the name of the artist that has most songs

            //// PESKI PROBAV RESIV NESTO, MORA DA IMA NEKOE POPROSTO RESENIE ///////

            var mettalica = Artists
                            .Where(x => x.FullName == "Metallica")
                            .ToList();

            var ironMaiden = Artists
                           .Where(x => x.FullName == "Iron Maiden")
                           .ToList();
            var rammStein = Artists
                           .Where(x => x.FullName == "Rammstein")
                           .ToList();
            var coldPlay = Artists
                           .Where(x => x.FullName == "Coldplay")
                           .ToList();
            var beyonce = Artists
                           .Where(x => x.FullName == "Beyonce")
                           .ToList();


            var metalCounter = 0;
            foreach (var item in mettalica)
            {
                metalCounter = item.Albums.Select(x => x.Songs.Count).Sum();

            }
            var ironCounter = 0;
            foreach (var item in ironMaiden)
            {
                ironCounter = item.Albums.Select(x => x.Songs.Count).Sum();
            }
            var ramCounter = 0;
            foreach (var item in rammStein)
            {
                ramCounter = item.Albums.Select(x => x.Songs.Count).Sum();
            }
            var coldCounter = 0;
            foreach (var item in coldPlay)
            {
                coldCounter = item.Albums.Select(x => x.Songs.Count).Sum();
            }
            var beyonceCounter = 0;
            foreach (var item in beyonce)
            {
                beyonceCounter = item.Albums.Select(x => x.Songs.Count).Sum();
            }

            List<int> numOfSongs = new List<int>() { metalCounter, ironCounter, ramCounter, coldCounter, beyonceCounter };

            numOfSongs.Sort();
            int mostSongs = numOfSongs.Last();

            var artistMostSongs = Artists.FirstOrDefault(x => x.Albums.Select(X => X.Songs.Count).Sum() == mostSongs);

            Console.WriteLine($"The name of the artist that has the most songs is: {artistMostSongs.FullName} with {mostSongs}songs ");
            Console.WriteLine("----------------------------------------------------------------------------------------------");



            // - print the type of the artist(SoloArtist/Band) that has most albums published before year 2000

            ///// ZAGLAVIV TUKA !!! /////

            foreach (var item in Artists)
            {
                item.Albums.Select(x => x.Year);
            }


            // - print the average song duration, of the album that has most songs

            int averageSongDuration = (int)albumMostSongs.Songs.Select(x => x.Duration).Average();
            Console.WriteLine($"The average song duration, of the album that has most songs: {averageSongDuration}seconds. or {averageSongDuration / 60} minutes and {averageSongDuration % 60 } seconds");
            Console.WriteLine("----------------------------------------------------------------------------------------------");




            // Bonus:
            // - print the longest song duration of the album that has least songs

            Album shortAlbum = Albums
                                .FirstOrDefault(x => x.Songs.Count == Albums.Select(X => X.Songs.Count).Min());

            Song longSong = shortAlbum.Songs
                                .FirstOrDefault(x => x.Duration == shortAlbum.Songs.Select(X => X.Duration).Max());

            Console.WriteLine($"The longest song of the Album: {shortAlbum.Name}  with least songs: {shortAlbum.Songs.Count} is: {longSong.Name} with duration: {longSong.Duration} seconds ");
            Console.WriteLine("----------------------------------------------------------------------------------------------");



            // - print the name of the album that has most songs that contain letter 'a' in the name

            //////// NE ZNAM DALI E TOCNO - PECATI NESTO //////////

            char ch = 'a';

                foreach (var item in Albums)
            {
                if (item.Songs.Select(x => x.Name.Where(X => X == ch).Count()).FirstOrDefault() == item.Songs.Select(x => x.Name.Where(X => X == ch).Count()).Max()) 
                {
                    Console.WriteLine($"The name of the album that has most songs that contain letter 'a' is: {item.Name}");
                    Console.WriteLine("----------------------------------------------------------------------------------------------");

                    break;
                }
            }

            // - print the name of the artist that has most songs that end with letter 'd'

                //// NE NI PROBUVAM ////



            // ************ Don't mind the structure, focus on the lists declared on the beginning of Program.cs ****************

            // 3, 2, 1.... GO! :)







            Console.ReadLine();
        }



        #region Data Initialization
        private static void Init()
        {
            InitArtists();
            InitAlbums();
            InitSongs();
            FillAlbums();
            FillArtists();
        }
        private static void FillAlbums()
        {
            foreach (var album in Albums)
            {
                album.Songs = Songs.Where(x => x.AlbumId == album.Id).ToList();
            }
        }
        private static void FillArtists()
        {
            foreach (var artist in Artists)
            {
                artist.Albums = Albums.Where(album => album.ArtistId == artist.Id).ToList();
            }
        }
        private static void InitArtists()
        {
            Artists = new List<Artist>();
            Artists.Add(new Artist(1, "Metallica", ArtistType.Band));
            Artists.Add(new Artist(2, "Iron Maiden", ArtistType.Band));
            Artists.Add(new Artist(3, "Rammstein", ArtistType.Band));
            Artists.Add(new Artist(4, "Coldplay", ArtistType.Band));
            Artists.Add(new Artist(5, "Beyonce", ArtistType.SoloArtist));
        }
        private static void InitAlbums()
        {
            Albums = new List<Album>();
            Albums.Add(new Album(1, 1, "Metallica", Genre.PopRock, 1991));
            Albums.Add(new Album(2, 1, "Ride The Lightning", Genre.PopRock, 1984));
            Albums.Add(new Album(3, 2, "Brave New World", Genre.PopRock, 2000));
            Albums.Add(new Album(4, 2, "Seventh Son of a Seventh Son", Genre.PopRock, 1988));
            Albums.Add(new Album(5, 3, "MUTTER", Genre.PopRock, 2001));
            Albums.Add(new Album(6, 3, "RosenRot", Genre.PopRock, 2005));
            Albums.Add(new Album(7, 4, "Mylo Xyloto", Genre.PopRock, 2011));
            Albums.Add(new Album(8, 5, "Lemonade", Genre.RnB, 2016));
        }
        private static void InitSongs()
        {
            Songs = new List<Song>();

            #region Metallica - Metallica
            Songs.Add(new Song(1, 1, "Enter Sandman", 5 * 60 + 31));
            Songs.Add(new Song(2, 1, "Sad But True", 5 * 60 + 24));
            Songs.Add(new Song(3, 1, "Holier Than Thou", 3 * 60 + 47));
            Songs.Add(new Song(4, 1, "The Unforgiven", 6 * 60 + 27));
            Songs.Add(new Song(5, 1, "Wherever I May Roam", 6 * 60 + 44));
            Songs.Add(new Song(6, 1, "Don't Tread on Me", 4 * 60 + 0));
            Songs.Add(new Song(7, 1, "Through the Never", 4 * 60 + 4));
            Songs.Add(new Song(8, 1, "Nothing Else Matters", 6 * 60 + 28));
            Songs.Add(new Song(9, 1, "Of Wolf and Man", 4 * 60 + 16));
            Songs.Add(new Song(10, 1, "The God That Failed", 5 * 60 + 8));
            Songs.Add(new Song(11, 1, "My Friend of Misery", 6 * 60 + 49));
            Songs.Add(new Song(12, 1, "The Struggle Within", 3 * 60 + 53));
            #endregion

            #region Metallica - ride-the-lightning
            Songs.Add(new Song(13, 2, "Fight Fire with Fire", 4 * 60 + 44));
            Songs.Add(new Song(14, 2, "Ride the Lightning", 6 * 60 + 36));
            Songs.Add(new Song(15, 2, "For Whom the Bell Tolls", 5 * 60 + 9));
            Songs.Add(new Song(16, 2, "Fade to Black", 6 * 60 + 57));
            Songs.Add(new Song(17, 2, "Trapped Under Ice", 4 * 60 + 4));
            Songs.Add(new Song(18, 2, "Escape", 4 * 60 + 23));
            Songs.Add(new Song(19, 2, "Creeping Death", 6 * 60 + 36));
            Songs.Add(new Song(20, 2, "The Call of Ktulu", 8 * 60 + 53));
            #endregion

            #region Iron Maiden - Brave New World
            Songs.Add(new Song(21, 3, "The Wicker Man", 4 * 60 + 35));
            Songs.Add(new Song(22, 3, "Ghost of the Navigator", 6 * 60 + 50));
            Songs.Add(new Song(23, 3, "Brave New World", 6 * 60 + 18));
            Songs.Add(new Song(24, 3, "Blood Brothers", 7 * 60 + 14));
            Songs.Add(new Song(25, 3, "The Mercenary", 4 * 60 + 42));
            Songs.Add(new Song(26, 3, "Dream of Mirrors", 9 * 60 + 21));
            Songs.Add(new Song(27, 3, "The Fallen Angel", 4 * 60 + 0));
            Songs.Add(new Song(28, 3, "The Nomad", 9 * 60 + 5));
            Songs.Add(new Song(29, 3, "Out of the Silent Planet", 6 * 60 + 25));
            Songs.Add(new Song(30, 3, "The Thin Line Between Love and Hate", 8 * 60 + 27));

            #endregion

            #region Iron Maiden - Seventh Son of a Seventh Son
            Songs.Add(new Song(31, 4, "Moonchild", 5 * 60 + 41));
            Songs.Add(new Song(32, 4, "Infinite Dreams", 6 * 60 + 9));
            Songs.Add(new Song(33, 4, "Can I Play with Madness", 3 * 60 + 31));
            Songs.Add(new Song(34, 4, "The Evil That Men Do", 4 * 60 + 34));
            Songs.Add(new Song(35, 4, "Seventh Son of a Seventh Son", 9 * 60 + 53));
            Songs.Add(new Song(36, 4, "The Prophecy", 5 * 60 + 6));
            Songs.Add(new Song(37, 4, "The Clairvoyant", 4 * 60 + 27));
            Songs.Add(new Song(38, 4, "Only the Good Die Young", 4 * 60 + 42));
            #endregion

            #region Rammstein - MUTTER
            Songs.Add(new Song(39, 5, "Mein Herz Brennt", 4 * 60 + 39));
            Songs.Add(new Song(40, 5, "Mein Herz Brennt", 3 * 60 + 36));
            Songs.Add(new Song(41, 5, "Sonne", 4 * 60 + 32));
            Songs.Add(new Song(42, 5, "Ich Will", 3 * 60 + 37));
            Songs.Add(new Song(43, 5, "Feuer Frei!", 3 * 60 + 11));
            Songs.Add(new Song(44, 5, "Mutter", 4 * 60 + 32));
            Songs.Add(new Song(45, 5, "Spieluhr", 4 * 60 + 46));
            Songs.Add(new Song(46, 5, "Zwitter", 4 * 60 + 17));
            Songs.Add(new Song(47, 5, "Rein Raus", 3 * 60 + 9));
            Songs.Add(new Song(48, 5, "Adios", 3 * 60 + 49));
            Songs.Add(new Song(49, 5, "Nebel", 4 * 60 + 54));
            #endregion

            #region Rammstein - Rosenrot
            Songs.Add(new Song(50, 6, "Benzin", 3 * 60 + 46));
            Songs.Add(new Song(51, 6, "Mann Gegen Mann", 3 * 60 + 50));
            Songs.Add(new Song(52, 6, "Rosenrot", 3 * 60 + 54));
            Songs.Add(new Song(53, 6, "Spring", 5 * 60 + 24));
            Songs.Add(new Song(54, 6, "Wo Bist Du", 3 * 60 + 55));
            Songs.Add(new Song(55, 6, "Stirb Nicht Vor Mir(Don't Die Before I Do)", 4 * 60 + 5));
            Songs.Add(new Song(56, 6, "Zerstören", 5 * 60 + 28));
            Songs.Add(new Song(57, 6, "Hilf Mir", 4 * 60 + 43));
            Songs.Add(new Song(58, 6, "Te Quiero Puta!", 3 * 60 + 55));
            Songs.Add(new Song(59, 6, "Feuer und Wasser", 5 * 60 + 17));
            Songs.Add(new Song(60, 6, "Ein Lied", 3 * 60 + 43));
            #endregion

            #region Coldplay - Mylo Xyloto
            Songs.Add(new Song(61, 7, "Mylo Xyloto", 0 * 60 + 43));
            Songs.Add(new Song(62, 7, "Hurts Like Heaven", 4 * 60 + 2));
            Songs.Add(new Song(63, 7, "Paradise", 4 * 60 + 37));
            Songs.Add(new Song(64, 7, "Charlie Brown", 4 * 60 + 45));
            Songs.Add(new Song(65, 7, "Us Against the World", 3 * 60 + 59));
            Songs.Add(new Song(66, 7, "M.M.I.X.", 0 * 60 + 48));
            Songs.Add(new Song(67, 7, "Every Teardrop Is a Waterfall", 4 * 60 + 0));
            Songs.Add(new Song(68, 7, "Major Minus", 3 * 60 + 30));
            Songs.Add(new Song(69, 7, "U.F.O.", 2 * 60 + 17));
            Songs.Add(new Song(70, 7, "Princess of China", 3 * 60 + 59));
            Songs.Add(new Song(71, 7, "Up in Flames", 3 * 60 + 13));
            Songs.Add(new Song(72, 7, "A Hopeful Transmission", 0 * 60 + 33));
            Songs.Add(new Song(73, 7, "Don't Let It Break Your Heart", 3 * 60 + 53));
            Songs.Add(new Song(74, 7, "Up with the Birds", 3 * 60 + 47));
            #endregion

            #region Beyonce - Lemonade
            Songs.Add(new Song(75, 8, "", 3 * 60 + 15));
            Songs.Add(new Song(76, 8, "", 3 * 60 + 41));
            Songs.Add(new Song(77, 8, "", 3 * 60 + 53));
            Songs.Add(new Song(78, 8, "", 3 * 60 + 52));
            Songs.Add(new Song(79, 8, "", 4 * 60 + 20));
            Songs.Add(new Song(80, 8, "", 4 * 60 + 47));
            Songs.Add(new Song(81, 8, "", 3 * 60 + 57));
            Songs.Add(new Song(82, 8, "", 3 * 60 + 2));
            Songs.Add(new Song(83, 8, "", 1 * 60 + 19));
            Songs.Add(new Song(84, 8, "", 4 * 60 + 49));
            Songs.Add(new Song(85, 8, "", 5 * 60 + 21));
            Songs.Add(new Song(86, 8, "", 3 * 60 + 25));

            #endregion

        }
        #endregion

    }
}
