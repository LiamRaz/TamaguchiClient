using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TamaguchiClient.UI;
using TamaguchiClient.DTO;
using System.Threading.Tasks;

namespace Tamaguchi.UI.Screens
{
    class AddActivityScreen : Screen
    {
        private const int FOOD_CATEGORYID = 1;
        private const int GAME_CATEGORYID = 2;
        private const int CLEAN_CATEGORYID = 3;

        public AddActivityScreen() : base("Create new activity")
        {

        }

        public override void Show()
        {

            base.Show();
            Console.WriteLine("Type the category of the activity you want to insert: \nIf you want to go back type 'B'!");


            string activity = Console.ReadLine();
            activity = activity.ToLower();

            while ((activity != "food" && activity != "game" && activity != "clean") || activity == "b")
            {
                if (activity == "b")
                {
                    return;
                }
                Console.WriteLine("Please type again (food/game/clean): ");
                activity = Console.ReadLine();

            }

            int category = 0;
            switch (activity)
            {
                case "food":
                    category = AddActivityScreen.FOOD_CATEGORYID;
                    break;
                case "game":
                    category = AddActivityScreen.GAME_CATEGORYID;
                    break;
                case "clean":
                    category = AddActivityScreen.CLEAN_CATEGORYID;
                    break;

                default:
                    return;
            }
            string activityName = IsNameValid();
            Console.WriteLine();
            int imp = IsImprovementValid();
            ActivityDTO a = null;
            switch (category)
            {
                case AddActivityScreen.FOOD_CATEGORYID:
                    a = new ActivityDTO { ActivityName = activityName, CategoryId = category, ImprovementHappiness = 0, ImprovementHunger = imp, ImprovementHygiene = 0};
                    break;

                case AddActivityScreen.GAME_CATEGORYID:
                    a = new ActivityDTO { ActivityName = activityName, CategoryId = category, ImprovementHappiness = imp, ImprovementHunger = 0, ImprovementHygiene = 0};
                    break;

                case AddActivityScreen.CLEAN_CATEGORYID:
                    a = new ActivityDTO { ActivityName = activityName, CategoryId = category, ImprovementHappiness = 0, ImprovementHunger = 0, ImprovementHygiene = imp};
                    break;

                default:
                    return;

            }
            if (a!=null)
            {
                try
                {
                    Task<ActivityDTO> t = MainUI.client.AddActivity(a);
                    Console.WriteLine("please wait while we are adding the activity...");
                    t.Wait();
                    if (t.Result != null)
                        Console.WriteLine("Activity was made successfully!");
                    else
                        Console.WriteLine("Something went wrong!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong!" + e.InnerException + "Press any key to go back");
                    Console.ReadKey();
                    return;

                }
            }
            else
            {
                Console.WriteLine("Something went wrong! Press any key to go back");
                Console.ReadKey();
                return;
            }
            
            Console.WriteLine("Press any key to go back");
            Console.ReadKey();



        }

        public int IsImprovementValid()
        {
            Console.WriteLine("Please enter improvment rate:");
            int imp = 0;
            int.TryParse(Console.ReadLine(), out imp);
            while (imp == 0 || imp > 100 || imp < -100)
            {
                Console.WriteLine("Invalid improvment rate, type again: ");
                int.TryParse(Console.ReadLine(), out imp);
            }

            return imp;
        }

        public string IsNameValid()
        {
            Console.WriteLine("Please type a name for your activity:");
            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] < 'A' || name[i] > 'z') && name[i] != ' ')
                {
                    Console.WriteLine("invalid name! The name must contain letters only! please type a new name:");
                    name = Console.ReadLine();
                    i = 0;
                }

            }
            return name;
        }

    }
}
