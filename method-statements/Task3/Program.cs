using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
            //type number between "x-xx"
            //if not between "x-xx", number is invalid
            //if type is not a number, type is invalid
            //method returns typed number
        {
            /*
            Console.WriteLine("Return value, please type number between x-xx");
            Console.Write("Type number: ");
            int number;
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number > 0)
            {
                Console.WriteLine($"{(number)}");
            }
            else
            {
                Console.WriteLine($"Number {number} is invalid");
            }
            
            Console.WriteLine($"Text)");
            */
            int MinimNumber = 1;
            int MaximNumber = 50;
            int result = NumberChecker(MinimNumber, MaximNumber);

            Console.ReadKey();
        }

        static int NumberChecker(int LowerLimit, int UpperLimit)
        {

            bool isNumberAcceptable = false;

            //DO

            // Prompt user

            // Read and parse userinput (remember int.TryParse(...) returns parse result, this could be useful)
            int.TryParse(...)
            // IF ! parse success
            // Console.Clear();
            // Check keyword "continue" functionality
            continue;
            // Check user input

            // IF acceptable number

            // isNumberAcceptable = true;

            // ELSE

            // isNumberAcceptable = false;
            // Console.Clear();

            //WHILE(!isNumberAcceptable)

            //Return acceptable number

        }
    }
}
