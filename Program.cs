using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //run GetAppInfo function
            GetAppInfo();

            //get user information
            String name = GetUserInfo();

            //greet user
            PrintColorMessage(ConsoleColor.Yellow, $"Hello {name},");
            

            while (true) {

                Console.WriteLine("Guess the correct number from 1 to 10");

                //get random number to guess
                Random random = new Random();
                int answer = random.Next(1, 11);

                int guess = 0;

                while (guess != answer)
                {
                    //get user guess
                    string inputAnswer = Console.ReadLine();
                    //convert string to integar
                    guess = Int32.Parse(inputAnswer);
                    if (guess != answer)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please guess again");
                    }

                }
                //Output success message
                PrintColorMessage(ConsoleColor.Green, $"Correct guess!, the number was {guess}");

                Console.WriteLine("Play again? [Y or N] or any key to close");
                string again = Console.ReadLine().ToUpper();

                if (again == "Y") 
                {
                    continue;
                }
                else if (again == "N")
                {
                    return;
                } 
                else
                {
                    return;
                }
            }
        }

        //function for App Information
        static void GetAppInfo()
        {
            //set application variables 
            string appName = "Koko's Number Guesser Game";
            string appVersion = "1.0";
            string appAuthor = "Bosi";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app information
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            // Reset text color
            Console.ResetColor();
        }

        //function to change console text colour
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }

        //function to get user information
        static string GetUserInfo()
        {
            PrintColorMessage(ConsoleColor.Yellow, "What is your name?");
            string input = Console.ReadLine();
            return input;
        }
    }
}
