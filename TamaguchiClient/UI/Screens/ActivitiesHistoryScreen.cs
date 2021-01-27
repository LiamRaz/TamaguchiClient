using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tamaguchi.UI;
using Tamaguchi.UI.Screens;
using Tamaguchi.Models;

namespace Tamaguchi.UI.Screens
{
    class ActivitiesHistoryScreen : Screen
    {
        public ActivitiesHistoryScreen() : base("Activities History")
        {
            
        }

        public override void Show()
        {
            char c = '\r';
            while (c == '\r')
            {

                base.Show();
                Console.WriteLine("Please type the amount of recent activities you want to see");
                int option = 0;
                int.TryParse(Console.ReadLine(), out option);

                if (MainUI.currentPlayer.CurrentPet!=null)
                {
                    List<object> recent = MainUI.currentPlayer.CurrentPet.GetActivityHistory(option);
                    ObjectsList list = new ObjectsList(" ", recent);
                    list.Show();

                }
                else
                {
                    Console.WriteLine("No data found!");
                }


                Console.WriteLine();
                Console.WriteLine("would you like to search again?");
                Console.WriteLine("press enter to search again or any other key to go back");
                c = Console.ReadKey().KeyChar;
            }




        }

    }
}
