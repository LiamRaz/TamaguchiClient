using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tamaguchi.UI;
using Tamaguchi.UI.Screens;
using Tamaguchi.Models;

namespace Tamaguchi.UI.Screens
{
    class PrintAllPlayers:Screen
    {
        public PrintAllPlayers():base("All Players")
        {

        }

        public override void Show()
        {
            base.Show();
            using (TamaguchiContext db = new TamaguchiContext())
            {
                ObjectsList list = new ObjectsList(" ",db.Players.ToList<Object>());
                list.Show();
                Console.WriteLine();
                Console.WriteLine("Press any key to go back");
                Console.ReadKey();

            }
        }
    }
}
