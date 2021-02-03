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
                try
                {
                    Task<PlayerDTO> t = MainUI.client.Login(user);
                    Console.WriteLine("please wait while we are logging you in...");
                    Console.WriteLine("this may take a few seconds...");
                    t.Wait();
                    MainUI.currentPlayer = t.Result;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.InnerException);
                    Console.WriteLine("press any button to shut down the application");
                    Console.ReadKey();
                    return;
                }
                
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
                try
                {
                    Task<bool> t = MainUI.client.Logout();
                    t.Wait();
                }
                catch(Exception e)
                {
                    Console.WriteLine("problem -" + e.InnerException);

                }
                
                this.Show();
              

            }
        }
    }
}
