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
                int result = 0;

                switch (userOperator)
                {
                    case '+':
                        result = firstNumber + secondNumber;
                        Console.WriteLine("The Result is:" + result);
                        break;
                    case '-':
                        result = firstNumber - secondNumber;
                        Console.WriteLine("The Result is:" + result);
                        break;
                    case '*':
                        result = firstNumber * secondNumber;
                        Console.WriteLine("The Result is:" + result);
                        break;
                    case '/':
                        result = firstNumber / secondNumber;
                        Console.WriteLine("The Result is:" + result);
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
