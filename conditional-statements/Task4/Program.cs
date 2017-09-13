using System;

namespace Task4
{
    class Program
    {

        static void Main(string[] args)
        {
            // Prompt user
            Console.Write("Please enter first number:");

            // Read use input
            string userInput;
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber_A;
            int.TryParse(userInput, out evaluatedNumber_A);

            // Prompt user
            Console.Write("Please second number:");

            // Read use inptu
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber_B;
            int.TryParse(userInput, out evaluatedNumber_B);

            // Prompt user
            Console.Write("Please third number:");

            // Read use input
            userInput = Console.ReadLine();

            // Evaluate user input

            int evaluatedNumber_C;
            int.TryParse(userInput, out evaluatedNumber_C);

            Console.WriteLine("1. number {0}\n2. number {1}\n3. number {2}", evaluatedNumber_A, evaluatedNumber_B, evaluatedNumber_C);

            if (evaluatedNumber_A < evaluatedNumber_B)
            {
                if(evaluatedNumber_A<evaluatedNumber_C)
                {
                    if(evaluatedNumber_B<evaluatedNumber_C)
                    {
                        Console.WriteLine("{0} - {1} - {2}", evaluatedNumber_A, evaluatedNumber_B, evaluatedNumber_C);
                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} - {2}", evaluatedNumber_A, evaluatedNumber_C, evaluatedNumber_B);
                    }
                }
                else
                {
                    Console.WriteLine("{0} - {1} - {2}", evaluatedNumber_C, evaluatedNumber_A, evaluatedNumber_B);

                }
            }
            else
            {
                if (evaluatedNumber_A < evaluatedNumber_C)
                {
                    Console.WriteLine("{0} - {1} - {2}", evaluatedNumber_B, evaluatedNumber_A, evaluatedNumber_C);

                }
                else
                {
                    if (evaluatedNumber_B < evaluatedNumber_C)
                    {
                        Console.WriteLine("{0} - {1} - {2}", evaluatedNumber_B, evaluatedNumber_C, evaluatedNumber_A);

                    }
                    else
                    {
                        Console.WriteLine("{0} - {1} - {2}", evaluatedNumber_C, evaluatedNumber_B, evaluatedNumber_A);

                    }
                }
            }
            // Wait for user input
            Console.ReadKey();
        }
    }
}
