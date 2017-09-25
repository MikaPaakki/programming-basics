using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write one number");

            int number;
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number > 0)
            {
                Console.WriteLine($"{amountOfStars(number)}");
            }
            else
            {
                Console.WriteLine($"Number {number} is invalid");
            }
            Console.ReadKey();
        }

        static string amountOfStars(int numberOfStars)
        {
            string stars=String.Empty;
            for(int i=0;i<numberOfStars;i++)
            {
                stars = stars + "*";
            }
            return stars;
        }
    }
}
