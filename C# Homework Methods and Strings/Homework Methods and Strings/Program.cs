using System;

namespace Homework_Methods_and_Strings
{
    class Program
    {
        #region Exercise Substrings Method
        static void SubString(int number)
        {
            string hello = "Hello from SEDC Codecademy 2021";

            if (number > hello.Length) Console.WriteLine($"Please enter number between 0 and {hello.Length}\n------------------------------------");

            else
            {
                string newString = hello.Substring(number);
                string firstLeters = newString.Substring(0, number);
                int stringLength = newString.Length;

                Console.WriteLine($" The new string is: '{newString}',\n the first {number} characters are '{firstLeters}'\n and the new string length is: '{stringLength}' characters long");
                Console.WriteLine("-------------------------");

            }

        }
        #endregion


        #region Homework FunWithStrings Method
        static void FunWithStrings(string userInput)
        {
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            string reverseStrign = String.Join("", charArray);

            int vovels = 0;
            bool isPalindrom = false;

            string isPalindromMessage = "";

            foreach (char character in userInput.ToLower())
            {
                if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
                {
                    vovels++;
                }
            }

            if (userInput.ToLower() == reverseStrign.ToLower())
            {
                isPalindrom = true;
                isPalindromMessage = "the string also is a Palindrom, ";

            }
            else
            {
                isPalindrom = false;
                isPalindromMessage = "the string is NOT a Palindrom";
            }

            string[] userInputArray = userInput.Split(" ");

            int minNumber = 300;
            int maxNumber = -1;
            string largestWord = "";
            string smallestWord = "";

            foreach (string element in userInputArray)
            {
                if (element.Length > maxNumber)
                {
                    largestWord = element;
                    maxNumber = element.Length;
                }

            }

            foreach (string element in userInputArray)
            {

                if (element.Length < minNumber)
                {
                    smallestWord = element;
                    minNumber = element.Length;
                }

            }



            int[] count = new int[256];


            int len = userInput.Length;
            for (int i = 0; i < len; i++)
                count[userInput[i]]++;

            int max = -1;
            char result = ' ';


            for (int i = 0; i < len; i++)
            {
                if (max < count[userInput[i]])
                {
                    max = count[userInput[i]];
                    result = userInput[i];
                }
            }



            Console.WriteLine($" The string read reverse is: '{reverseStrign}',\n it has total number of: '{vovels}' vovels,\n {isPalindromMessage}\n its lagest word is: '{largestWord}',\n the smallest word is '{smallestWord}',\n The sentence has: {userInputArray.Length} number of words,\n most used character is: '{result}',\n it was used {max} number of times");


        }
        #endregion

        #region RemoveExtraSpace Method


        static void RemoveExtraSpace(string userInput)
        {



            string result = "";

            char[] textCharArr = userInput.ToCharArray();

            char prevChar = ' ';
            for (int i = 0; i < textCharArr.Length; i++)
            {
                char current = textCharArr[i];
                if ((prevChar != ' ' || current != prevChar)) { 


                result += current;
                prevChar = current;
            }

            }

            string spaceCleared = result.Replace("&nbsp;", "").Trim();

            Console.WriteLine(spaceCleared);


        }
        #endregion

        static void Main(string[] args)
        {

            #region Calling Substrings Method
            while (true)
            {

                Console.WriteLine("Please enter a number!");

                bool tryParse = int.TryParse(Console.ReadLine(), out int userNumber);


                if (tryParse)
                {
                    if (userNumber == 333) break;
                    SubString(userNumber);
                }
                else
                {
                    Console.WriteLine("Please enter numbers only");
                    Console.WriteLine("-------------------------");
                }

            }
            #endregion

            #region Calling FunWithStrings Method
            while (true)
            {
                Console.WriteLine("Please enter a sentence");
                Console.WriteLine("-------------------------");

                string newString = Console.ReadLine();

                bool tryParseNewString = int.TryParse(newString, out int newStringParsed);


                if (String.IsNullOrEmpty(newString))
                {
                    Console.WriteLine("Please enter somthing!");
                    Console.WriteLine("-------------------------");
                }
                else if (tryParseNewString)
                {

                    Console.WriteLine("Please enter letters only!");
                    Console.WriteLine("-------------------------");

                }
                else
                {
                    if (newString.ToLower() == "x") break;
                    FunWithStrings(newString);
                    Console.WriteLine("-------------------------");
                }


            }
            #endregion

            #region Calling RemoveExtraSpace

            string userInput1 = " The    best  Lorem  Ipsum        Generator in all the  sea!   Heave this   scurvy copyfiller fer yar         next   adventure  and cajol yar clients   into walking the plank with ev'ry layout!    Configure       above, then get yer pirate ipsum...own the high seas,    argh!    " +
                "" +
                "The&nbsp;&nbsp;&nbsp; best &nbsp;Lorem&nbsp; Ipsum&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Generator in all the&nbsp; sea!&nbsp;&nbsp; Heave this &nbsp; scurvy copyfiller fer yar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; next&nbsp;&nbsp; adventure&nbsp; and cajol yar clients&nbsp;&nbsp; into walking  the plank with  ev'ry layout!&nbsp;&nbsp;&nbsp; Configure&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  above, then get yer pirate ipsum...own the high seas,&nbsp;&nbsp;&nbsp; argh!";

            RemoveExtraSpace(userInput1);

            #endregion

            Console.ReadLine();
        }
    }
}
