using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcme to number guesser game");
            bool playAgain = true;

            Random random = new Random();
            int numberToguess = random.Next(1, 11);
            int attempts = 3;
            int guess;

            while (playAgain == true)
            {
                Console.WriteLine("guess the number between 1 and 10, you have " + attempts + " attempts");



                while (attempts > 0)
                {
                    Console.WriteLine("enter your guess");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > numberToguess)
                    {
                        Console.WriteLine("Too high");
                    }
                    else if (guess < numberToguess)
                    {
                        Console.WriteLine("too low");

                    }
                    else
                    {
                        Console.WriteLine("COnfgratulations you guessed ethe number correctly in" + attempts + "attempts");
                        break;
                    }
                    attempts -= 1;
                }

                if (attempts == 0)
                {
                    Console.WriteLine("you lose, try again and the correct no. was " + numberToguess);

                }

                Console.WriteLine("do you want to play again (1 for Yes, 2 for No)");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 2)
                    playAgain = false;




            }

        }


    }
}
