using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("laske myos negat. luvuilla, syota luku");
            int sum = 0;
            
            int k = 1;
            //int sumPositive = 0;
            string parseMsg = String.Empty;
            // Read use input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);
            bool isPositive = evaluatedNumber > 0;
            if (!isPositive)
            {
                k = -1;
            }
            //Console.WriteLine(isPositive);

            for (int i = 1; i <= Math.Abs(evaluatedNumber); i++)
            {
                if (i != Math.Abs(evaluatedNumber))
                {
                    if(isPositive)
                        parseMsg += i * k + "+";
                    else
                        parseMsg += i * k;


                }
                else
                {
                    //Console.WriteLine("Number {0} is negative", i);
                    parseMsg += i * k + "=";
                }

                sum = sum + i * k;

            }

            Console.WriteLine($"N={evaluatedNumber} : {parseMsg} {sum}");

            //Console.WriteLine($"lukujen summa on {sum}");
            Console.ReadKey();
        }
    }
}