using Tamaguchi.UI.Screens;
using System;
using System.Collections.Generic;
using System.Text;

//namespace Tamaguchi.UI
//{
//    class LoginScreen : Screen
//    {
//        public LoginScreen() : base("Login Screen")
//        {

//        }

//        public override void Show()
//        {
//            base.Show();
//            if (MainUI.currentPlayer == null)
//            {
//                Console.WriteLine("Please enter email:");
//                Console.ForegroundColor = ConsoleColor.Cyan;
//                string email = Console.ReadLine();
//                Console.ForegroundColor = ConsoleColor.White;

//                Console.WriteLine("Please enter password");
//                Console.ForegroundColor = ConsoleColor.Cyan;
//                string pass = Console.ReadLine();
//                Console.ForegroundColor = ConsoleColor.White;
//                MainUI.currentPlayer = MainUI.db.Login(email, pass);
//                if (MainUI.currentPlayer == null)
//                    Console.WriteLine("error usr,pass");
//                else
//                {
//                    Console.WriteLine("Login Succesfull");
//                    Screen next = new ChooseScreen();
//                    next.Show();

//                }
//            }
//            else
//            {
//                Console.WriteLine("Would like to sign out and re-Login?");

//                bool validChoice = false;
//                while (!validChoice)
//                {
//                    char choice = Console.ReadKey().KeyChar;
//                    switch (choice)
//                    {
//                        case 'y':
//                            MainUI.db.SaveChanges();
//                            MainUI.currentPlayer = null;
//                            validChoice = true;
//                            this.Show();
//                            break;
//                        case 'n':
//                            validChoice = true;
//                            //קריאה למסך ניהול

//                            break;
//                        default:
//                            Console.WriteLine("\ny or n only");

//                            break;
//                    }
//                }

//            }
//        }
//    }
//}
