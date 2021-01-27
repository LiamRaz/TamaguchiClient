using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tamaguchi.UI;
using Tamaguchi.UI.Screens;
using Tamaguchi.Models;

namespace Tamaguchi.UI.Screens
{
    class FeedingScreen : Screen
    {

        public FeedingScreen() : base("Feeding")
        {}

        public override void Show()
        {
            char c = '\r';
            while (c == '\r')
            {
                base.Show();
                using (TamaguchiContext db = new TamaguchiContext())
                {
                    List<object> foodList = db.GetFoodList();
                    ObjectsList list = new ObjectsList(" ", foodList);
                    list.Show();
                    Console.WriteLine();
                    Console.WriteLine("Please enter the number of the food you want to give to your pet");
                    Console.WriteLine("if you want to go back enter the number 6969");
                    int option = 0;
                    int.TryParse(Console.ReadLine(), out option);
                    if (option == 6969)
                        return;
                    Activity a = null;
                    try
                    {
                        a = db.GetFood(option);
                    }
                    catch (Exception e)
                    {
                        while (a == null)
                        {
                            Console.WriteLine("invalid number please enter a number again");
                            int.TryParse(Console.ReadLine(), out option);
                            if (option == 6969)
                                return;
                            try
                            {
                                a = db.GetFood(option);
                            }
                            catch (Exception e1)
                            {

                            }
                        }
                    }

                    Pet p = MainUI.currentPlayer.CurrentPet;
                    if (p!=null)
                    {

                        p.Improve(a);
                        ActivitiesHistory aH = new ActivitiesHistory();
                        aH.InsertActivity(p, a);
                        db.AddActivityHistory(aH);
                        MainUI.db.SaveChanges();
                        db.SaveChanges();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You currently don't own a living pet!!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to feed your pet again?");
                Console.WriteLine("Press enter to feed your pet again or any other key to go back");
                c = Console.ReadKey().KeyChar;
            }

        }

    }
}
