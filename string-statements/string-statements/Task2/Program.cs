using System;

namespace Task2
{
    class Program
    {
        public static void Main()
        {
            String s = "Hello World!";
            Console.WriteLine("Output: '{0}'", s);
            s = s.Replace("e", "@").Replace("o", "&"); //.Replace("c", "d");
            Console.WriteLine("Input: '{0}'", s);

            System.Console.ReadKey();
        }
    }
}
