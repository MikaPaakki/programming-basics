using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Times table");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    //Console.Write((i == 0 ? j : (j == 0 ? i : i * j)) + "\t");
                    Console.Write($"{i} x {j} = {i*j}\t");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }

            //for (int i = 1; i <= 10; i++)
            //for (int j = 1; j < 10; j++)
            //var = i * j;
        }
    }

