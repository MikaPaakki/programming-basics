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
            int MinimNumber = 1;
            int MaximNumber = 50;
            int result = NumberChecker(MinimNumber, MaximNumber);
            Console.WriteLine("You did input number{0}", result);
            Console.ReadKey();
        }

        static int NumberChecker(int LowerLimit, int UpperLimit)
        {
            
            int number;
            Console.WriteLine("Please enter a number between {0} and {1}.", LowerLimit, UpperLimit);
            string userInput = Console.ReadLine();
            while(!int.TryParse(userInput, out number) || number < LowerLimit || number >UpperLimit)
            {
                Console.WriteLine("number is invalid, please enter a number between {0} and {1}.", LowerLimit, UpperLimit);
                userInput = Console.ReadLine();
            }
            return number;
        }
    }
}
