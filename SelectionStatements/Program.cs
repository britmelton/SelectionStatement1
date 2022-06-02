using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class Exercise Instructions
            //In class exercise
            /*The point of this exercise is to allow a user to play a game where they must guess what your favorite number is.
             * Initialize an integer to represent a favorite number and assign a value with a number of your choosing 
             * or you can assign a random number to this variable
             * Create an if-statement that if the guessed number is below the initial value, print out “too low”.
             * Create an else-if statement that if the number is higher than the initial value, print out “too high”.
             * Create an else statement that prints out “Nevermind”. */
            #endregion
            var r = new Random();
            var favNumber = r.Next(1,10);
            var counter = 0;

            bool correct = false;
            while (!correct)
            {
                Console.WriteLine("\nGuess my favorite number:");
                var userInput = int.Parse(Console.ReadLine());
                counter++;
                if (userInput < favNumber)
                {
                    Console.WriteLine("\ntoo low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("\ntoo high");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("\nyou got it!");                   
                }

                if (!correct)
                {
                    Console.WriteLine($"You've guessed {counter} time{(counter == 1 ? "" : "s")}");
                }
                else
                {
                    Console.WriteLine($"\nyou got the correct answer in {counter} guess{(counter == 1 ? "" : "es")}");
                }

            }
            
        }
    }
}
