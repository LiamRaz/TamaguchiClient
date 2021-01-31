using System;
using System.Collections.Generic;
using System.Text;
using TamaguchiClient.UI;
using TamaguchiClient.WebServices;
using System.Threading.Tasks;

namespace Tamaguchi.UI.Screens
{
    class ChooseScreen : Screen
    {

        private List<MenuItem> items { get; set; }

        public ChooseScreen() : base("Choose")
        {
            this.items = new List<MenuItem>();
            
            this.items.Add(new MenuItem("Player Stats", new PrintPlayerScreen()));
            //this.items.Add(new MenuItem("Pet Stats", new PetStats()));
            //this.items.Add(new MenuItem("Activities History", new ActivitiesHistoryScreen()));
            //this.items.Add(new MenuItem("Activities", new ActivitiesScreen()));
            //this.items.Add(new MenuItem("Create Pet", new CreatePetScreen()));
            //if (MainUI.currentPlayer.Email == "admin@gmail.com")
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    this.items.Add(new MenuItem("Managment", new ManagemetScreen()));
            //    Console.ForegroundColor = ConsoleColor.White;

            //}



        }

        public override void Show()
        {
            int count = 1;
            bool exit = false;
            while (!exit) //Loop until user press the exit option (last option)
            {
                base.Show();
                Console.WriteLine("Please Choose from the following Options");
                foreach (MenuItem m in items)
                {
                    Console.WriteLine($"\n{count} - {m}");
                    count++;
                }
                Console.WriteLine($"\n{count} - exit and Log out");

                int option = 0;
                int.TryParse(Console.ReadLine(), out option);
                if (option >= 1 && option <= count)
                {
                    if (option == count)//Exit
                    { 
                        exit = true;
                        Task<bool> t = MainUI.client.Logout();
                        t.Wait();
                    }
                    else
                    {
                        if (this.items[option - 1].TargetScreen != null)
                            this.items[option - 1].Show(); //Show selected screen!
                        else
                            Console.WriteLine("no screen to show");
                    }
                }
                count = 1;

            }
        }



    }
}
