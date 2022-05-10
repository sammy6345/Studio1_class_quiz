using System;

namespace Studio1ClassQuiz
{
    internal class Program
    {
        static void Main()
        {
            // intro
            Console.WriteLine("Hello World!");
            // Question 1
            task1();
            Q3();
            // Question 2

            // Question 3
        }

        public static void task1()
        {


        }

        public static void Q3()
        {
            string userInput;
            Console.WriteLine();
            Console.WriteLine("What is the hottest planet in the solar system?");
            userInput = Console.ReadLine();
            userInput.ToLower();

            if (userInput == "venus" || userInput == "Venus")
            {
                Console.WriteLine();
                Console.WriteLine("That is correct :^)");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("That is incorrect");
                Console.ReadKey();
            }
        }
    }
}
