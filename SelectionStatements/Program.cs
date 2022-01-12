using System;

namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //if else statement exercise 

            bool correct = false;   
            while (!correct)
            {
                var r = new Random();
                var favNumber = r.Next(10);
                
                Console.WriteLine("\nGuess my favorite number:");
                var userInput = int.Parse(Console.ReadLine());

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



            }


            
        }
    }
}
