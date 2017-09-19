using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("laske N ensimmaista lukua yhteen, syota luku");
            int sum = 0;
            string parseMsg = String.Empty;             
            // Read use input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);
            for (int i = 1; i <= evaluatedNumber; i++)
            {
                if (i != evaluatedNumber)
                {
                    parseMsg += i + "+";
                }
                else
                {
                    parseMsg += i + "=";
                }
                sum = sum + i;
            }
            Console.WriteLine($"N={evaluatedNumber} : {parseMsg} {sum}");
            //Console.WriteLine($"lukujen summa on {sum}");
            Console.ReadKey();
        }
    }
}