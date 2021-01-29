using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tamaguchi.UI;
using Tamaguchi.UI.Screens;


//namespace Tamaguchi.UI.Screens
//{
//    class CreatePetScreen : Screen
//    {

//        private const int IMPROVMENT = 100;
//        private const int PET_WEIGHT = 18;
//        private const int AGE = 0;
//        private const int LIFE_CYCLE_CODE = 1;
//        private const int HEALTH_STATUS = 1;

//        public CreatePetScreen() : base("Create Pet")
//        {

//        }

//        public string IsNameValid()
//        {
//            Console.WriteLine("Please type a name for your pet:");
//            string name = Console.ReadLine();
//            for (int i = 0; i < name.Length; i++)
//            {
//                if (name[i] < 'A' || name[i] > 'z')
//                {
//                    Console.WriteLine("invalid name! The name must contain letters only! please type a new name:");
//                    name = Console.ReadLine();
//                    i = 0;
//                }

//            }
//            return name;
//        }

//        public override void Show()
//        {
//            using (TamaguchiContext db = new TamaguchiContext())
//            {
//                base.Show();
//                if (MainUI.currentPlayer.CurrentPet != null)
//                {
//                    Console.WriteLine("You already have a living pet are you sure you want to proceed?");
//                    Console.WriteLine("Press enter to proceed or any other key to go back");
//                    char c = Console.ReadKey().KeyChar;
//                    if (c != '\r')
//                        return;
//                }
//                Console.WriteLine();
//                Console.WriteLine("If you desire to go back then write 'back'");
//                Console.WriteLine();
//                string name = IsNameValid();
//                if (name == "back")
//                    return;
//                Pet p = new Pet();
//                p.InsertPet(name, CreatePetScreen.PET_WEIGHT, CreatePetScreen.IMPROVMENT, CreatePetScreen.AGE, CreatePetScreen.LIFE_CYCLE_CODE, CreatePetScreen.HEALTH_STATUS, MainUI.currentPlayer.PlayerCode);
//                db.AddPet(p);
//                if (MainUI.currentPlayer.CurrentPet != null)
//                {
//                    MainUI.currentPlayer.CurrentPet.HealthCode = 4;
//                }
//                MainUI.currentPlayer.CurrentPet = p;
//                MainUI.currentPlayer.CurrentPetId = p.PetCode;
//                MainUI.db.SaveChanges();
//                Console.WriteLine();
//                Console.WriteLine("Your pet has been created successfully");
//                Console.WriteLine("Press any key to go back");
//                Console.ReadKey();

//            }





//        }

//    }
//}
