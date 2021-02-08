using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tamaguchi.UI;
using Tamaguchi.UI.Screens;
using System.Threading.Tasks;
using System.Text.Json;
using TamaguchiClient.DTO;

namespace TamaguchiClient.UI.Screens
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

            try
            {
                Task<List<PetStatsDTO>> petStats = MainUI.client.GetPets();
                Console.WriteLine("fetching your pets information...");
                petStats.Wait();

                if (petStats.Result != null)
                {
                    
                    ObjectsList list = new ObjectsList(" ", petStats.Result.ToList<object>());
                    list.Show();
                }
                else
                {
                    Console.WriteLine("No Data Found");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("oopsi doopi something went wrong or" + e.InnerException);
                Console.WriteLine("enter any key to go back");
                Console.ReadKey();
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to go back");
            Console.WriteLine();
            Console.ReadKey();

        }

    }
}