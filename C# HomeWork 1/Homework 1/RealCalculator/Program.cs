using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your First Number");
            bool isUserNumberSueccess = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.WriteLine("Please Enter Your Second Number");
            bool isUserNumberSueccess2 = int.TryParse(Console.ReadLine(), out int secondNumber);
            Console.WriteLine("Please Enter Your Operator");
            bool isUserCharSueccess = char.TryParse(Console.ReadLine(), out char userOperator);

            if (isUserNumberSueccess && isUserNumberSueccess2 && isUserCharSueccess)
            {
                switch (userOperator)
                {
                    case '+':
                        int sumNumbers = firstNumber + secondNumber;
                        Console.WriteLine("The Result is:" + sumNumbers);
                        break;
                    case '-':
                        int substractNumbers = firstNumber - secondNumber;
                        Console.WriteLine("The Result is:" + substractNumbers);
                        break;
                    case '*':
                        int multiplyNumbers = firstNumber * secondNumber;
                        Console.WriteLine("The Result is:" + multiplyNumbers);
                        break;
                    case '/':
                        int devideNumbers = firstNumber / secondNumber;
                        Console.WriteLine("The Result is:" + devideNumbers);
                        break;
                    default:
                        Console.WriteLine("Please enter valid operator");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter valid numbers");
            };
            Console.ReadLine();
        }
    }
}
