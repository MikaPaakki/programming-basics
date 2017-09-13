using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Please add your age");

            float ticketPrice = 100.0f;
            float discount = 0.0f;
            // Read use input
            string userInput;
            userInput = Console.ReadLine();
            int age;
            int.TryParse(userInput, out age);
            // Evaluate user input

            // Prompt user
            Console.WriteLine("Please add your status [1-4]");
            Console.WriteLine("1. Eläkeläinen");
            Console.WriteLine("2. Varusmies");
            Console.WriteLine("3. Opiskelija");
            Console.WriteLine("4. joku muu");

            // Prompt user
            Console.WriteLine("Are you member of MTK, yes/no [1-2]");
            Console.WriteLine("5.Yes");
            Console.WriteLine("6.No");
        
            // Read use input
            userInput = Console.ReadLine();

            // Evaluate user input

           

            int status;
            int.TryParse(userInput, out status);

            //IF < 7
            if (age > 7)
            {
                Console.WriteLine("Number {0} is <7", age);
            }
            //IF >7
            else if (age > 7)
            {
                Console.WriteLine("Number {0} is <7", age);
            }
            //IF <15
            else if (age < 15)
            {
                Console.WriteLine("Number {0} is <15", age);
            }
            //IF ==65
            if (age == 65)
            {
                Console.WriteLine("Number {0} is ==65", age);
            }
            //IF >65
            else if (age > 65)
            {
                Console.WriteLine("Number {0} is >65", age);
            }

            if(status == 1)
            {
                discount = 0.5f;
            }
            else if(status == 2)
            {
                discount = 0.5f;
            }
            else if(status == 3)
            {
                discount = 0.45f;
            }
            else
            {
                discount = 1.0f;
            }
            
            float totPrice = ticketPrice - (ticketPrice * discount);

            Console.WriteLine("Your ticket price is {0} e", totPrice);
            Console.ReadKey();
        }

    }
}

