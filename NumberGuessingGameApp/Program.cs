using System;


namespace NumberGuessingGameApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string authorName = "Sanidh";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, authorName);

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Let's play a game {0}!", inputName);

            while (true)

            {

                Random random = new Random();

                int correctNumber = random.Next(1, 20);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 20");

                while (guess != correctNumber)
                {

                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {

                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Please enter an actual number to continue");

                        Console.ResetColor();

                        continue;

                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Wrong number, please try again");

                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Correct!");

                Console.ResetColor();

                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") {
                    continue;
                
                }
                else if (answer == "N") {
                    return;

                }
                 else
                {
                    return;
                }

            }

        }
    }

}

