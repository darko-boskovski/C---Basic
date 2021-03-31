using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] namesArray = { "Petko", "Stanko", "Blazo", "Pero", "Trpana" };

            do
            {
                Console.WriteLine("Do you want to enter a name? (Y / N)");
                string whileUserInput = Console.ReadLine();

                if (whileUserInput != "" && whileUserInput == "Y" || whileUserInput == "y")
                {

                    Console.WriteLine("Please enter a name");
                    string newName = Console.ReadLine();
                    if (newName.Length < 3 || newName == "")
                    {
                        Console.WriteLine("Please Enter more than 3 letters");
                        continue;
                    } else
                    { 
                        Array.Resize(ref namesArray, namesArray.Length + 1);
                        namesArray[namesArray.Length - 1] = newName;
                        Console.WriteLine("---------------------");
                        Console.WriteLine("The names in the array are:");
                        Console.WriteLine("---------------------");

                    }
                        foreach (string element in namesArray)
                        {
                            Console.WriteLine(element);
                        }
                        Console.WriteLine("---------------------");
             
                 
                }else if (whileUserInput == "N" || whileUserInput == "n")
                {
                    Console.WriteLine("You have exited the program");
                    break;
                }
                else
                {
                    Console.WriteLine("Please Enter only Y or N");
                }
            } while (true);

            Console.ReadLine();
        }

    }
}
