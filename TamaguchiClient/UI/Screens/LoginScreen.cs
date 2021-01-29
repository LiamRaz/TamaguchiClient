using Tamaguchi.UI.Screens;
using System;
using System.Collections.Generic;
using System.Text;
using TamaguchiClient.DTO;
using System.Threading.Tasks;

namespace TamaguchiClient.UI.Screens
{
    class LoginScreen : Screen
    {
        public LoginScreen() : base("Login Screen")
        {

        }

        public override void Show()
        {
            base.Show();
            if (MainUI.currentPlayer == null)
            {
                Console.WriteLine("Please enter email or user name:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string email = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Please enter password");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string pass = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                UserDTO user = new UserDTO { Email = email, Pass = pass };
                Task<PlayerDTO> t = MainUI.client.Login(user);
                t.Wait();
                MainUI.currentPlayer = t.Result;
                if (MainUI.currentPlayer == null)
                {
                    Console.WriteLine("error usr,pass");
                    Console.ReadKey();
                    
                }
                else
                {
                    Console.WriteLine("Login Successfull press any key to continue");
                    Console.ReadKey();
                    Screen next = new ChooseScreen();
                    next.Show();
                    
                }
            }
            else
            {
                MainUI.currentPlayer = null;
                this.Show();
                //Console.WriteLine("Would like to sign out and re-Login?");

                //bool validChoice = false;
                //while (!validChoice)
                //{
                //    char choice = Console.ReadKey().KeyChar;
                //    switch (choice)
                //    {
                //        case 'y':
                //            MainUI.currentPlayer = null;
                //            validChoice = true;
                //            this.Show();
                //            break;
                //        case 'n':
                //            validChoice = true;
                //            //קריאה למסך ניהול

                //            break;
                //        default:
                //            Console.WriteLine("\ny or n only");

                //            break;
                //    }
                //}

            }
        }
    }
}
