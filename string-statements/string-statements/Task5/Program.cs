using System;

namespace Task5
{
    class Program
    {
        public static void Main()
        {
            //string str = "Hello World!".ToUpper();
            Console.WriteLine("Write word or sentence");

            string userInput = Console.ReadLine();
            userInput = userInput.ToUpper();

            int sum = 0;

            int iCounter = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'A')
                {
                    iCounter++;
                }
            }
            int jCounter = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'E')
                {
                    jCounter++;
                }
            }
            int kCounter = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'I')
                {
                    kCounter++;
                }
            }
            int lCounter = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'O')
                {
                    lCounter++;
                }
            }
            int mCounter = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'U')
                {
                    mCounter++;
                }
            }
            int nCounter = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'Y')
                {
                    nCounter++;
                }
                sum = iCounter + jCounter + kCounter + lCounter + mCounter + nCounter;

            }
            //Console.WriteLine($"Vowels contained in a word or sentence={sum}");
            Console.WriteLine("Output: '{0}'", userInput);
            Console.WriteLine($"Input: Vowels contained in a String={sum}");

            System.Console.ReadKey();
        }
    }
}
