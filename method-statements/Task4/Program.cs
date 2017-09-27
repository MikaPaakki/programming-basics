using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
            //type ten numbers
            //if not positive, number is invalid, enter new number
            //return value of the greatest number
        {

            NumberOrder();
            Console.ReadKey();
            
        }

        static void NumberOrder()
        {
            Console.WriteLine("Write ten numbers");

            List<int> numbers = new List<int>();

            int counter = 1;
            while (counter <= 10)
            {
                //Console.Write("Write numberA?");
                Console.Write($"Write number {counter}: ");
                /*int number;
                string userInput = Console.ReadLine();
                number = int.Parse(userInput);*/
                int numberA;
                string userInput = Console.ReadLine();
                numberA = int.Parse(userInput);
                if (numberA > 0)
                {
                    //Console.WriteLine($"{counter}. {(numberA)}");
                    numbers.Add(numberA);
                    counter = counter + 1;


                }
                else
                {
                    Console.WriteLine($"Number {numberA} is invalid, please enter a positive number");
                }
            }

            Console.WriteLine("You added these numbers");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            int maxNumber = numbers.Max();
            int maxNumberIndex = numbers.IndexOf(maxNumber) + 1;

            Console.WriteLine();
            Console.WriteLine($"Maximum number was {maxNumber}, {maxNumberIndex}. number");
        }
    }
}
