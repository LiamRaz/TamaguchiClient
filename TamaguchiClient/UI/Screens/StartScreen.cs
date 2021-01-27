using Tamaguchi.UI.Screens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tamaguchi.UI
{
    class StartScreen : Screen
    {
        public StartScreen() : base("Tamaguchi App")
        {
        }

        public override void Show()
        {
            base.Show();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Welcome to Tamaguchi app");
            Console.WriteLine("By TEMEG Group \n\n");
            Console.WriteLine("Press any key to continue");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
            Screen l = new MainMenu(this.Title);
            l.Show();

        }
        

    }
}
