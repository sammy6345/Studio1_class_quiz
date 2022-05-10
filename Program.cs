using System;
using System.Threading;

namespace Studio1ClassQuiz
{
    internal class Program
    {
        static void Main()
        {
            // intro
            intro();
            // Question 1
            Q1();
            // Question 2

            // Question 3
        }

        public static void intro()
        {
            Console.WriteLine("Welcome to our simple quiz.");
            Console.WriteLine("There will be three questions for you to answer in a fixed order.");
            Console.WriteLine("Good luck.");
        }

        public static void Q1()
        {
            Console.Clear();
            Console.WriteLine("Q1. What's 1+1?");
            Console.WriteLine("1. 2");
            Console.WriteLine("2. 5");
            Console.WriteLine("3. 1");
            string answer = Console.ReadLine();

            if (answer != "1" && answer != "2" && answer != "3")
            {
                Console.WriteLine("That was an Invalid response");
                Console.WriteLine("The choices are 1, 2 and 3");
                Thread.Sleep(3000);
                Q1();
            }

            switch (answer)
            {
                case "1":
                    Console.WriteLine("EHHHHH WRONG!");
                    break;
                case "2":
                    Console.WriteLine("EHHHHH WRONG! YOU SUCK");
                    break;
                case "3":
                    Console.WriteLine("Correct, thats good.... I suppose.");
                    break;
                default:
                    break;
            }
            Thread.Sleep(3000);
            Q2();

        }
    }
}
