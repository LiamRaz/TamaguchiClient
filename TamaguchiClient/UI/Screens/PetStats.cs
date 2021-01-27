using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tamaguchi.UI;
using Tamaguchi.UI.Screens;
using Tamaguchi.Models;

namespace Tamaguchi.UI.Screens
{
    class PetStats : Screen
    {

        public PetStats() : base("Pet Stats")
        {

        }

        public override void Show()
        {
            base.Show();

            Console.WriteLine();


            List<object> petStats = MainUI.currentPlayer.GetPetStats();
            if (petStats == null)
            {
                return;
            }
            ObjectsList list = new ObjectsList(" ", petStats);
            list.Show();

            Console.WriteLine();
            Console.WriteLine("Press any key to go back");
            Console.WriteLine();
            Console.ReadKey();

        }

    }
}
