using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numberArray = new int[6];

            int sumOfEven = 0;
            int counter = 0;

            while (true)
            {
                
                for (int i = 0; i < numberArray.Length; i++)
                {
                    Console.WriteLine("Enter integer no: " + (i + 1));

                    bool ifParsingInputSuccessful = int.TryParse(Console.ReadLine(), out int inputNumber);

                    if (ifParsingInputSuccessful)
                    {
                        numberArray[i] = inputNumber;
                        if (numberArray[i] % 2 == 0)
                        {
                            sumOfEven += numberArray[i];
                            counter++;
                        }
                        if (i == numberArray.Length -1)
                        {
                            Console.WriteLine("The sum of all the even numbers in the array is: " + sumOfEven);
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Please entere valid Numbers!");
                        break;
                    }

                }

                if (counter == 6) break;

            }










            Console.ReadLine();
        }
    }
}
