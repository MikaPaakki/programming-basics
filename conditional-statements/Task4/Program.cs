using System;

namespace Task4
{
    class Program
    {

        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Please enter numbers:");

            // Read use input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);

          

            //IF > 0
            if (evaluatedNumber > 0)
            {
                Console.WriteLine("Number {0} is greater than 0", evaluatedNumber);
            }
            //IF > 1
            else if (evaluatedNumber > 1)
            {
                Console.WriteLine("Number {0} is greater than 1", evaluatedNumber);
            }
            //IF > 2
            else if (evaluatedNumber > 2)

            {
                Console.WriteLine("Number {0} is greater than 2", evaluatedNumber);
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
