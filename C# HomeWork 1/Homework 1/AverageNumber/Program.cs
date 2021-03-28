using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please Enter Your First Number");
            bool isUserNumberSueccess = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please Enter Your Second Number");
            bool isUserNumberSueccess2 = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Please Enter Your Third Number");
            bool isUserNumberSueccess3 = int.TryParse(Console.ReadLine(), out int thirdNumber);
            Console.WriteLine("Please Enter Your Fourth Number");
            bool isUserNumberSueccess4 = int.TryParse(Console.ReadLine(), out int fourthNumber);

            int avarageResult = 0;

            if (isUserNumberSueccess && isUserNumberSueccess2 && isUserNumberSueccess3 && isUserNumberSueccess4)
            {
                avarageResult = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;
                Console.WriteLine("The Avarage of " + firstNumber + ", " + secondNumber + ", " + thirdNumber + " and " + fourthNumber + " is: " + avarageResult);
            }
            else
            {
                Console.WriteLine("Please Enter Valid Numbers!");
            }





            Console.ReadLine();
        }
    }
}
