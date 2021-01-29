using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tamaguchi.UI;
using Tamaguchi.UI.Screens;


//namespace Tamaguchi.UI.Screens
//{
//    class PlayingScreen : Screen
//    {
//        private const int RPS_ACTIVITIES = 22;
//        public PlayingScreen() : base("Playing")
//        {

//        }

//        public override void Show()
//        {
            
//            char c = '\r';
//            while (c == '\r')
//            {
//                base.Show();
//                using (TamaguchiContext db = new TamaguchiContext())
//                {
//                    List<object> gameList = db.GetGameList();
//                    ObjectsList list = new ObjectsList(" ", gameList);
//                    list.Show();
//                    Console.WriteLine();
//                    Console.WriteLine("Please enter the number of the game you want to play with your pet");
//                    Console.WriteLine("if you want to go back enter the number 6969");
//                    int option = 0;
//                    int.TryParse(Console.ReadLine(), out option);
//                    if (option == 6969)
//                        return;
//                    Activity a = null;
//                    try
//                    {
//                        a = db.GetGame(option);
//                    }
//                    catch (Exception e)
//                    {
//                        while (a == null)
//                        {
//                            Console.WriteLine("invalid number please enter a number again");
//                            int.TryParse(Console.ReadLine(), out option);
//                            if (option == 6969)
//                                return;
//                            try
//                            {
//                                a = db.GetGame(option);
//                            }
//                            catch (Exception e1)
//                            {

//                            }
//                        }
//                    }

//                    Pet p = MainUI.currentPlayer.CurrentPet;
//                    if (p != null)
//                    {

//                        p.Improve(a);
//                        ActivitiesHistory aH = new ActivitiesHistory();
//                        aH.InsertActivity(p, a);
//                        db.AddActivityHistory(aH);
//                        MainUI.db.SaveChanges();
//                        db.SaveChanges();
//                        if (option == PlayingScreen.RPS_ACTIVITIES)
//                        {
//                            rpsScreen rps = new rpsScreen();
//                            rps.Show();
//                            Console.Clear();
//                        }


//                    }
//                    else
//                    {
//                        Console.ForegroundColor = ConsoleColor.Red;
//                        Console.WriteLine("You currently don't own a living pet!!!!");
//                        Console.ForegroundColor = ConsoleColor.White;
//                    }

//                }
//                Console.WriteLine();
//                Console.WriteLine("Would you like to play with your pet again?");
//                Console.WriteLine("Press enter to play with your pet again or any other key to go back");
//                c = Console.ReadKey().KeyChar;
//            }

//        }

//    }
//}
