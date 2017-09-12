using System;

namespace Task1
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

            // Console.WriteLine("User input was: {0} : integer: {1}", userInput, evaluatedNumber);

            //IF > 0
            if(evaluatedNumber > 0)
            {
                Console.WriteLine("Number {0} is greater than 0", evaluatedNumber);
            }

            // IF < 0

            else if(evaluatedNumber < 0)
            {
                Console.WriteLine("Number {0} is less than 0", evaluatedNumber);
            }

            // IF == 0

            {
                Console.WriteLine("Number {0} equals 0" , evaluatedNumber);
            }

            // Wait for user input
            Console.ReadKey();
        }
    }
}
