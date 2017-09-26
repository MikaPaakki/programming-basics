using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Return minimum value, please type two numbers");
            Console.Write("type number 1/2: ");
            int numberA;
            string userInput = Console.ReadLine();
            numberA = int.Parse(userInput);

            Console.Write("type number 2/2: ");
            int numberB;
            userInput = Console.ReadLine();
            numberB = int.Parse(userInput);

           Console.WriteLine($"Syotetyistä luvuista pienempi on {Minimum(numberA,numberB)}");
            
            Console.ReadKey();
        }

        static int Minimum(int numberX, int numberY)
        {


            // ehto ? true_value : false_value;

            return (numberX < numberY) ? numberX : numberY; 

            /*if (numberX < numberY)
                return numberX;
            else
                return numberY;
                */
        }
    }

}
    
