using System;

namespace Task3
{
    class Program
    {
        public static void Main()
        {
            string str = "Hello World!".ToUpper();

            int iCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'L')
                {
                    iCounter++;
                }
                    
            }
            int jCounter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'W')
                {
                    jCounter++;
                }
            }
            Console.WriteLine("String '{0}' contain {1} 'L' letters", str, iCounter ); //str //index
            Console.WriteLine("String '{0}' contain {1} 'W' letters", str, jCounter );
            System.Console.ReadKey();


            /*sum = sum + i;
            System.Console.ReadKey();

            /*string str = "Hello World!".ToUpper();

            String toFind = "e";

            int index = str.IndexOf("n");
            Console.WriteLine("Found '{0}' in '{1}' at position {2}",
                              toFind, str, index);*/
       }
    }
}
