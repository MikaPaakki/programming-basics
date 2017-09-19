using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate factorial, please type a number");
            int factorial = 1;
            // Read use input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);
            for (int i = 1; i <= evaluatedNumber; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("{0}!={1}", evaluatedNumber, factorial);
            Console.ReadKey();
        }
    }
}
