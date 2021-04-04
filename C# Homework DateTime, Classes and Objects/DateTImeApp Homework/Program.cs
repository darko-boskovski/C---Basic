using System;

namespace DateTimeApp_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DateTime Homework
            Console.WriteLine("--------------- Homework DateTime Object -------------------");
            Console.WriteLine("--------------------------------------------------");

            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine($"The current date with time is {currentDateAndTime}");
            Console.WriteLine("--------------------------------------------------");

            DateTime tenYearsFromNow = DateTime.Today.AddYears(10);
            Console.WriteLine($"The date 10 years from now is: {tenYearsFromNow}");
            Console.WriteLine("--------------------------------------------------");

            DateTime twoAndHalfMonthtsAgo = DateTime.Today.AddMonths(-2).AddDays(-15);
            Console.WriteLine($"The date two months and 15 days ago was : {twoAndHalfMonthtsAgo}");
            Console.WriteLine("--------------------------------------------------");

            DateTime nextEightMarch = new DateTime(2022, 03, 08);
            string eigthMarchDayOfTheWeek =  nextEightMarch.ToString("dddd, dd MM yyyy");
            Console.WriteLine($"Next year the 8th of March is on : {eigthMarchDayOfTheWeek}");
            Console.WriteLine("--------------------------------------------------");

            DateTime lastValentineDate = new DateTime(2020, 02, 14);
            string lastValentineDayOfTheWeek = string.Format("{0:dddd}, {0:MM/dd/yyyy}", lastValentineDate);
            Console.WriteLine($"Next year the 8th of March is on : {lastValentineDayOfTheWeek}");
            Console.WriteLine("--------------------------------------------------");
            #endregion


            Console.ReadLine();


        }
    }
}
