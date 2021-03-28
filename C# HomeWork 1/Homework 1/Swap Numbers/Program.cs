using System;

namespace Swap_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your First Number");
            bool isUserNumberSueccess = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please Enter Your Second Number");
            bool isUserNumberSueccess2 = int.TryParse(Console.ReadLine(), out int secondNumber);

            if(isUserNumberSueccess && isUserNumberSueccess2)
            {
                int temp = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temp;

                Console.WriteLine("The numbers swaped their values and now the First Number is: " + firstNumber + " And The Second number is " + secondNumber);

            }
            else
            {
                Console.WriteLine("Please enter valid numbers");
            }



            Console.ReadLine();
        }
    }
}
