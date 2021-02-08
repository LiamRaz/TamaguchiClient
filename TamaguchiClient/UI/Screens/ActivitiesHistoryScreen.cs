using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using TamaguchiClient.DTO;

namespace TamaguchiClient.UI.Screens
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
                
                try
                {
                    Task<List<ActivityHistoryDTO>> t = MainUI.client.GetActivityHistory();
                    Console.WriteLine("please wait while we fetch your history of activities :)");
                    t.Wait();
                    if (t.Result != null)
                    {
                        List<object> lst = t.Result.Take(option).ToList<object>();
                        ObjectsList list = new ObjectsList(" ", lst);
                        list.Show();

                    }
                    else
                    {
                        Console.WriteLine("No data found!");
                    }

                }
                catch (Exception e)
                {

                    Console.WriteLine("Error with user logged in or "+ e.InnerException);
                    Console.WriteLine("press any key to go back");
                    Console.ReadKey();
                    return;
                }


                Console.WriteLine();
                Console.WriteLine("would you like to search again?");
                Console.WriteLine("press enter to search again or any other key to go back");
                c = Console.ReadKey().KeyChar;
            }




        }

    }
}
