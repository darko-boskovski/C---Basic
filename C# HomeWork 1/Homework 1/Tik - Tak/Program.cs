using System;

namespace Tik_Tak
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i == 0)
            {
            
                Console.WriteLine("Please Enter Your Number");
                bool isUserNumberSueccess = int.TryParse(Console.ReadLine(), out int userNumber);

                if (isUserNumberSueccess)
                {
                    if (userNumber % 3 == 0 && userNumber % 5 == 0)
                    {
                        Console.WriteLine(" Tik - Tok " + " You've Guesd the number");
                        i++;
                    }
                    else if (userNumber % 3 == 0)
                    {
                        Console.WriteLine("Tok");
                    }
                    else if (userNumber % 5 == 0)
                    {
                        Console.WriteLine("Tik");
                      
                    }
                    else
                    {
                        Console.WriteLine("The number you have entered is not devisible by the numbers 3 and 5");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Number");
                }

            }



            Console.ReadLine();
        }
    }
}
