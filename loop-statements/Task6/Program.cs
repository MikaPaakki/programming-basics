using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Squareroots");
            int number = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                double SqrtNumber = Math.Sqrt(i);
                Console.WriteLine("Square root of {0} is: {1}", i, SqrtNumber);
            }
            Console.ReadLine();
            //Console.WriteLine("Squareroots");

            //for (int i = 1; i <= 10; i++) ;

            //var a = Math.Round(MathSqrt(i), 2);

        }
    }
}