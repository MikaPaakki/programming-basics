using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coin flipping");

            int headCount = 0;
            int tailCount = 0;

            // Main Program Logic
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            Random rnd = new Random();
            for (int x = 1; x <= 20; x++)
            {
                int flip = rnd.Next(1, 3);
                if (flip == 1)
                {
                    Console.WriteLine("Heads");
                    headCount++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tailCount++;
                }
            }
            Console.WriteLine("Heads came up {0} times.", headCount);
            Console.WriteLine("Tails came up {0} times.", tailCount);
            if (headCount > tailCount)
            {
                Console.WriteLine("Heads wins.");
            }
            else
            {
                Console.WriteLine("Tails wins.");
            }

            // END OF DOCUMENT
            Console.ReadLine();
        }
    }
    
}