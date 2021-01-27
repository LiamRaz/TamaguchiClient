using System;
using System.Collections.Generic;
using System.Text;

namespace Tamaguchi.UI.Screens
{
    class rpsScreen : Screen
    {
        static char GetChar()
        {
            Console.WriteLine("Please type a key from the options shown above:");
            string str = Console.ReadLine();
            while (str.Length != 1 || (str[0] != 'r' && str[0] != 'R' && str[0] != 'p' && str[0] != 'P' && str[0] != 's' && str[0] != 'S' && str[0] != 'b' && str[0] != 'B'))
            {
                Console.WriteLine("invalid input! please type again:");
                str = Console.ReadLine();
            }
            return str[0];
        }

        public rpsScreen() : base("Rock Paper Scissors")
        {

        }

        public override void Show()
        {
            base.Show();
            bool endOfGame = false;
            Random rnd = new Random();
            Console.WriteLine("type 'r' for Rock, 'p' for Paper, 's' for Scissors and 'b' to go back");
            while (!endOfGame)
            {
                char option = GetChar();
                int computerChoice = rnd.Next(1, 4);

                option = char.ToLower(option);
                if (option == 'b')
                    return;

                switch (option, computerChoice)
                {
                    case ('r', 1):
                        Console.WriteLine("Rock vs Rock");
                        Console.WriteLine("tied");
                        break;

                    case ('r', 2):
                        Console.WriteLine("Rock vs Paper");
                        Console.WriteLine("lose");
                        endOfGame = true;
                        break;

                    case ('r', 3):
                        Console.WriteLine("Rock vs Scissors");
                        Console.WriteLine("win");
                        endOfGame = true;
                        break;

                    case ('p', 1):
                        Console.WriteLine("Paper vs Rock");
                        Console.WriteLine("win");
                        endOfGame = true;
                        break;

                    case ('p', 2):
                        Console.WriteLine("Paper vs Paper");
                        Console.WriteLine("tied");
                        break;

                    case ('p', 3):
                        Console.WriteLine("Paper vs Scissors");
                        Console.WriteLine("lose");
                        endOfGame = true;
                        break;

                    case ('s', 1):
                        Console.WriteLine("Scissors vs Rock");
                        Console.WriteLine("lose");
                        endOfGame = true;
                        break;

                    case ('s', 2):
                        Console.WriteLine("Scissors vs Paper");
                        Console.WriteLine("win");
                        endOfGame = true;
                        break;

                    case ('s', 3):
                        Console.WriteLine("Scissors vs Scissors");
                        Console.WriteLine("tied");
                        break;
                }

            }

            Console.WriteLine("GG! EZ! press any key to go back");
            Console.ReadKey();

        }

    }
}
