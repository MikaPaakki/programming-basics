using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("laske myos negat. luvuilla, syota luku");
            int sumNegative = 0;
            int sumPositive = 0;
            string parseMsg = String.Empty;
            // Read use input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);
            bool isPositive = evaluatedNumber > 0;
            Console.WriteLine(isPositive);
            for (int i = 1; i <= Math.Abs(evaluatedNumber); i++)
            {
                if (i != evaluatedNumber)
                {
                    Console.WriteLine("Number {0} is positive", i);
                    parseMsg += i + "+";
                }
                else
                {
                    Console.WriteLine("Number {0} is negative", i);
                    parseMsg += i + "=";
                }

                sumNegative = sumNegative + i;

                sumPositive = sumPositive + 1;
            }
            Console.WriteLine($"N={evaluatedNumber} : {parseMsg} {sumNegative}");
            Console.WriteLine($"N={evaluatedNumber} : {parseMsg} {sumPositive}");
            //Console.WriteLine($"lukujen summa on {sum}");
            Console.ReadKey();
        }
    }
}