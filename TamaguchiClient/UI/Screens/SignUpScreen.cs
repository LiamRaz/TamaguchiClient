using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

//namespace Tamaguchi.UI.Screens
//{
//    class SignUpScreen : Screen
//    {
//        public SignUpScreen() : base("Sign Up")
//        {

//        }

//        public override void Show()
//        {
//            base.Show();
//            using (TamaguchiContext db = new TamaguchiContext())
//            {
//                Console.WriteLine("First Name: ");
//                string fName = IsNameValid();

//                Console.WriteLine("Last Name: ");
//                string lName = IsNameValid();

//                Console.WriteLine("Email Adress: ");
//                string mail = Console.ReadLine();
//                Regex regex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
//                Match match = regex.Match(mail);
//                //בדיקה האם מייל קיים
//                Player p1 = db.Players.FirstOrDefault(p => p.Email == mail);

//                while (match.Success == false || p1 != null)//Invalid email or already exists
//                {

//                    Console.WriteLine("Invalid email or already exists!");
//                    mail = Console.ReadLine();
//                    match = regex.Match(mail);
//                    p1 = db.Players.FirstOrDefault(p => p.Email == mail);
//                }


//                Console.WriteLine("Gender: ");
//                string gender = Console.ReadLine();
//                gender = gender.ToLower();
//                while (gender != "male" && gender != "female" && gender != "other")
//                {
//                    Console.WriteLine("Please type again (male/fenale/other): ");
//                    gender = Console.ReadLine();
//                }

//                Console.WriteLine("Birth Year: ");
//                int year = 0;
//                int.TryParse(Console.ReadLine(), out year);
//                while (year < 1898 || year > DateTime.Now.Year)
//                {
//                    Console.WriteLine("Please type again in a valid range: ");
//                    int.TryParse(Console.ReadLine(), out year);
//                }

//                Console.WriteLine("Birth Month: ");
//                int month = 0;
//                int.TryParse(Console.ReadLine(), out month);
//                while (month <= 0 || month > 12)
//                {
//                    Console.WriteLine("Please type again in a valid range: ");
//                    int.TryParse(Console.ReadLine(), out month);
//                }

//                Console.WriteLine("Birth Day: ");
//                int day = 0;
//                int.TryParse(Console.ReadLine(), out day);
//                while (day <= 0 || day > 31)
//                {
//                    Console.WriteLine("Please type again in a valid range: ");
//                    int.TryParse(Console.ReadLine(), out day);
//                }


//                Console.WriteLine("Username: ");
//                string uName = IsUserNameValid();
//                Player p2 = db.Players.FirstOrDefault(p => p.UserName == uName);

//                while (p2 != null)
//                {

//                    Console.WriteLine("Invalid email or already exists!");
//                    uName = IsUserNameValid();
//                    p2 = db.Players.FirstOrDefault(p => p.UserName == uName);
//                }

//                Console.WriteLine("Password: ");
//                string pass = Console.ReadLine();


//                Player p = new Player();
//                DateTime birthDay = new DateTime(year, month, day);
//                p.InsertPlayer(fName, lName, mail, gender, birthDay, uName, pass);
//                db.AddPlayer(p);

//                Console.WriteLine("SUCCESS!");
//                Console.WriteLine("Press any key to go back");
//                db.SaveChanges();

//                Console.ReadKey();

//            }

//        }

//        //מסננת קלט לשם
//        public string IsNameValid()
//        {
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

//        public string IsUserNameValid()
//        {

//            string name = Console.ReadLine();
//            for (int i = 0; i < name.Length; i++)
//            {
//                if (name[i] < '0' || name[i] > 'z')
//                {
//                    Console.WriteLine("invalid name! The name must contain letters only! please type a new name:");
//                    name = Console.ReadLine();
//                    i = 0;
//                }

//            }
//            return name;
//        }



//    }
//}
