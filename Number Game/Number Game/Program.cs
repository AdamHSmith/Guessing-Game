using System;


namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // App info
            GetAppInfo();

            // Get players name and greeting
            GreetUser();

            while (true)
            {

                // Generate random correct number

                Random random = new Random();
                int correctNumber = random.Next(1, 100);

                //initialise guess and get players guess
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 100.");

                // Incorrect/correct guess Loop
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColor(ConsoleColor.Red, "Please enter a number.");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        if (guess > correctNumber)
                        {
                            PrintColor(ConsoleColor.Red, "Wrong number, too high! Please try again.");
                        }
                        else
                        {
                            PrintColor(ConsoleColor.Red, "Wrong number, too low! Please try again.");
                        }

                    }
                }

                PrintColor(ConsoleColor.Green, "You are correct! Well done!");

                // Ask to play again

                Console.WriteLine("Do you want to play again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {

                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    PrintColor(ConsoleColor.Red, "Invalid option");
                }

            }

        }

        static void GetAppInfo()
        {
            // App info
            String appName = "Number Guesing Game";
            string appAuthor = "Adam Smith";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("{0} by {1}", appName, appAuthor);

            Console.ResetColor();
        }
        // Greeting
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string playersName = Console.ReadLine();

            Console.WriteLine("Hello {0} lets play a game", playersName);
        }
        // Print Colour message
        static void PrintColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}