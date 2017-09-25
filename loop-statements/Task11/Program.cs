using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rolling the dice");

            int one = 0;
            int two = 0;
            int three = 0;
            int four = 0;
            int five = 0;
            int six = 0;

            // Main Program Logic
            Console.WriteLine("Press enter to begin");
            Console.ReadLine();
            Random rnd = new Random();
            for (int x = 1; x <= 1000; x++)
            {
                int flip = rnd.Next(1, 7);
                if (flip == 1)
                {
                    Console.WriteLine("Number one");
                    one++;
                }
                else if (flip == 2)
                {
                    Console.WriteLine("Number two");
                    two++;
                }
                else if (flip == 3)
                {
                    Console.WriteLine("Number three");
                    three++;
                }
                else if (flip == 4)
                {
                    Console.WriteLine("Number four");
                    four++;
                }
                else if (flip == 5)
                {
                    Console.WriteLine("Number five");
                    five++;
                }
                else if (flip == 6)
                {
                    Console.WriteLine("Number six");
                    six++;
                }
            }
            Console.WriteLine("one came up {0} times.", one);
            Console.WriteLine("two came up {0} times.", two);
            Console.WriteLine("three came up {0} times.", three);
            Console.WriteLine("four came up {0} times.", four);
            Console.WriteLine("five came up {0} times.", five);
            Console.WriteLine("six came up {0} times.", six);

            Console.ReadLine();
        }
    }
}
