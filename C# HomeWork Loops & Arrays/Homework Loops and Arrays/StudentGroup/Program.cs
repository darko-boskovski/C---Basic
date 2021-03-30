using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] arrayG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] arrayG2 = { "Pero", "Blazo", "Igor", "Trpe", "Stanko" };

            Console.WriteLine("Enter student group: (there are 1 and 2)");

            bool ifParsingInputSuccessful = int.TryParse(Console.ReadLine(), out int userNumber);

            if (ifParsingInputSuccessful)
            {
                if(userNumber == 1)
                {
                    Console.WriteLine("The Students in G1 are: ");

                    foreach (var name in arrayG1)
                    {
                        Console.WriteLine(name);
                    }
                }else if (userNumber == 2)
                {
                    Console.WriteLine("The Students in G1 are: ");

                    foreach (var name in arrayG2)
                    {
                        Console.WriteLine(name);
                    }

                }
                else
                {
                    Console.WriteLine("Please enter number between 1 and 2 only!");
                }
               
            }else
            {
                Console.WriteLine("Please enter numbers only!");
            }


            Console.ReadLine();
        }
    }
}
