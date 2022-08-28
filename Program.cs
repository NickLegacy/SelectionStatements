using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number");
            var UserInput = int.Parse(Console.ReadLine());
            if (UserInput < favNumber)
                Console.WriteLine("Too low. Guess again");
            if (UserInput > favNumber)
                Console.WriteLine("Too high. Guess again");
            else if (UserInput == favNumber)
                Console.WriteLine("Nevermind");

            Console.WriteLine("What is your favorite school subject?");
            var answer = Console.ReadLine();
            switch (answer)
            {
                case "Math":
                    Console.WriteLine("Lots of numbers");
                    break;

                case "science":
                    Console.WriteLine("very interesting");
                    break;

                case "english":
                    Console.WriteLine("Lots of sentences");
                    break;

                case "physical Education":
                    Console.WriteLine("Gym class. Lots of running");
                    break;

                case "history":
                    Console.WriteLine("Boring");
                    break;

                default:
                    Console.WriteLine("Never herd of it");
                    break;
            }

        }
    }
}
