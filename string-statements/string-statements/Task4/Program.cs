using System;

namespace Task4
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Kirjoita sana tai lause");

            string userInput = Console.ReadLine();
            userInput = userInput.ToUpper(); // "Tulossolut"
            string str = "";
            foreach(Char c in userInput)
            {
                //Console.WriteLine(c);
                if (!Char.IsWhiteSpace(c))
                {
                    str = str + c;
                }
            }
            //Console.WriteLine(str);
            bool isPalindome = true;
           
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != str[str.Length - 1 - i]) // verrataan merkki merkiltä alusta yksi-merkki ja lopusta yksi merkki
                {
                    isPalindome = false;
                    break;
                }
                if (i >= str.Length - 1 - i)
                    break;
            }

            if (isPalindome == true)
                Console.WriteLine("Sana/lause {0} on Palindromi", userInput);
            else
                Console.WriteLine("Sana/lause {0} EI OLE Palindromi", userInput);

            System.Console.ReadKey();
        }
    }
}
