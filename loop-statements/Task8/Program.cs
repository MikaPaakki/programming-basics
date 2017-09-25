using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random numbers");
            Random rnd = new Random();

            for (int r = 0; r < 4; r++)
            {
                Console.Write($"Rivi {r + 1}: ");
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 5)
                    {
                        Console.Write($"{rnd.Next(0, 51),2}\n");
                    }
                    else
                    {
                        Console.Write($"{rnd.Next(0, 51),2}, ");
                    }
                }
            }
            Console.ReadKey();
        }
        //rnd.NextDouble(); "0...1"
        //rnd.Next(100); "0-100"}
    }
}