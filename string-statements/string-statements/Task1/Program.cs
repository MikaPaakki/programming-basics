using System;

namespace Task1
{
    class Program
    {
        public static void Main()
        {
            /*String s = "Hello World!";
            Char charRange = ' ';
            int startIndex = s.IndexOf(charRange);
            int endIndex = s.LastIndexOf(charRange);
            int length = endIndex - startIndex + 1;
            Console.WriteLine("{0}.Substring({1}, {2}) = {3}",
            s, startIndex, length,
            s.Substring(startIndex, length));*/

            string str = "Hello World!";
            Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);

            int length = str.Length;
            Console.WriteLine("1) The length of '{0}' is {1}", str, length);

            Console.ReadKey();
        }
    }
}
