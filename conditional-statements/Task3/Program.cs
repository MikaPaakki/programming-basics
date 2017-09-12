using System;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Please enter a number:");

            // Read use input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

            //IF > 0
            if (evaluatedNumber > 0)
            {
                Console.WriteLine("Number {0} is positive", evaluatedNumber);
            }
            // IF < 0

            else if (evaluatedNumber < 0)
            {
                Console.WriteLine("Number {0} is negative", evaluatedNumber);
            }
            if (evaluatedNumber % 2 == 0)

            // Number 0 is considered to be even
            {
                Console.WriteLine("Number {0} is even", evaluatedNumber);
            }

            else
            {
                Console.WriteLine("Number {0} is odd", evaluatedNumber);
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
