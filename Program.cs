using System;

//Give credit where credit is due
//Written by Mitchell Borchers 12/2019
//Link to tutorial is here:
//https://www.youtube.com/watch?v=GcFJjpMFJvI

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            /*Demo - Getting started stuff
            string name = "Mitchell";
            int age = 104;
            Console.WriteLine("Hello " + name + " is " + age);
            Console.WriteLine("{0} is {1}", name, age);
            */

            //Run getappinfo
            GetAppInfo();

            //Greet user and ask for user info
            Greetings();

            while (true)
            {

                //Init set correct number (new random num)
                //int correctNumber = 7;
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10.");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user input
                    string input = Console.ReadLine();

                    //Make sure entered value is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number!");

                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please try again!");
                    }
                }

                //Output success message
                //Change text color
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                //Ask to play again
                Console.WriteLine("Play again [Y or N]??");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.ReadLine();
                    return;
                }
                else 
                {
                    Console.ReadLine();
                    return;
                }
            }
        }
        //Get and display app info
        static void GetAppInfo()
        {
            //Set App Vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mitchell";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color to white
            Console.ResetColor();
        }
        //Ask user name and greet
        static void Greetings() 
        {
            //Ask users name
            Console.WriteLine("What is you name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Lets play a game!", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message) 
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Reset text color to white
            Console.ResetColor();

        }
    }
}
