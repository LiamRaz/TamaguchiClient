using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TamaguchiClient.UI.Screens;
using TamaguchiClient.UI;


namespace TamaguchiClient.UI.Screens
{
    class PrintPlayerScreen : Screen
    {
        public PrintPlayerScreen() : base("Player Details")
        { }
        public override void Show()
        {
            base.Show();

            if (MainUI.currentPlayer != null)
            {
                ObjectView showPlayer = new ObjectView("", MainUI.currentPlayer);
                showPlayer.Show();
            }
            else
            {
                Console.WriteLine("no data found!");
            }
            Console.WriteLine("Press Any Key To Go Back");
            Console.ReadKey();



        }

    }
}
