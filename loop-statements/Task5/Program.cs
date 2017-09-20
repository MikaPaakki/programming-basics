using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate summs of first two even and odd number, also negative numbers");
            int sumEven = 0;
            int sumOdd = 0;
            // Read use input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);
            for (int i = 1; i <= evaluatedNumber; i++)
            {
                if (i % 2 == 0)

                // Number 0 is considered to be even
                {
                    Console.WriteLine("Number {0} is even", i);
                    sumEven += i; //sumEven = sumEven+i;
                }

                else
                {
                    Console.WriteLine("Number {0} is odd", i);
                    sumOdd += i;
                }
            }
            Console.WriteLine($"Parillisten lukujen summa on {sumEven}");
            Console.WriteLine($"Parittomien lukujen summa on {sumOdd}");
            Console.ReadKey();
        }
    }
}
