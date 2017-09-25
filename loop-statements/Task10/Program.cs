using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vakioveikkaus");
            Random rnd = new Random();


            for(int i = 0; i <= 13; i++)
            {
                var randomNumber = rnd.NextDouble();

                Console.WriteLine(randomNumber);
                Console.ReadLine();
            }

        }
    }
}
