using System;
using System.Collections.Generic;
using System.Text;
using Tamaguchi.UI;

namespace Tamaguchi.UI.Screens
{
    class MainMenu : MenuScreen
    {
        public MainMenu(string title) : base(title)
        {
            this.items = new List<MenuItem>();
            this.items.Add(new MenuItem("Log In", new LoginScreen()));
            this.items.Add(new MenuItem("Sign Up", new SignUpScreen()));

            Console.Clear();
            ConsoleSpinner spin = new ConsoleSpinner();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Loading....");
            for (int i = 0; i < 20; i++) 
            {

                spin.Turn();
            }
            Console.ForegroundColor = ConsoleColor.White;


        }
        //להעביר לעפולה 




    }
}
