using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using TamaguchiClient.DTO;
using System.Threading.Tasks;

namespace TamaguchiClient.UI.Screens
{
    class SignUpScreen : Screen
    {
        public SignUpScreen() : base("Sign Up")
        {

        }

        public override void Show()
        {
            base.Show();

            Console.WriteLine("First Name: ");
            string fName = IsNameValid();

            Console.WriteLine("Last Name: ");
            string lName = IsNameValid();

            Console.WriteLine("Email Adress: ");
            string mail = Console.ReadLine();
            Regex regex = new Regex(@"^([\w.-]+)@([\w-]+)((.(\w){2,3})+)$");
            Match match = regex.Match(mail);

            // exception
            try
            {
                Task<bool> t = MainUI.client.IsEmailExists(mail);
                Console.WriteLine("validating your email...");
                t.Wait();
                while (match.Success == false || t.Result)//Invalid email or already exists
                {

                    Console.WriteLine("Invalid email or already exists!");
                    mail = Console.ReadLine();
                    match = regex.Match(mail);
                    t = MainUI.client.IsEmailExists(mail);
                    Console.WriteLine("validating your email...");
                    t.Wait();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine("press any key to go back");
                Console.ReadKey();
                return;
            }
            


            Console.WriteLine("Gender: ");
            string gender = Console.ReadLine();
            gender = gender.ToLower();
            while (gender != "male" && gender != "female" && gender != "other")
            {
                Console.WriteLine("Please type again (male/fenale/other): ");
                gender = Console.ReadLine();
            }

            Console.WriteLine("Birth Year: ");
            int year = 0;
            int.TryParse(Console.ReadLine(), out year);
            while (year < 1898 || year > DateTime.Now.Year)
            {
                Console.WriteLine("Please type again in a valid range: ");
                int.TryParse(Console.ReadLine(), out year);
            }

            Console.WriteLine("Birth Month: ");
            int month = 0;
            int.TryParse(Console.ReadLine(), out month);
            while (month <= 0 || month > 12)
            {
                Console.WriteLine("Please type again in a valid range: ");
                int.TryParse(Console.ReadLine(), out month);
            }

            Console.WriteLine("Birth Day: ");
            int day = 0;
            int.TryParse(Console.ReadLine(), out day);
            while (day <= 0 || day > 31)
            {
                Console.WriteLine("Please type again in a valid range: ");
                int.TryParse(Console.ReadLine(), out day);
            }


            Console.WriteLine("Username: ");
            string uName = IsUserNameValid();

            // exception

            try
            {
                Task<bool> t2 = MainUI.client.IsUserNameExists(mail);
                Console.WriteLine("validating your username...");
                t2.Wait();

                while (t2.Result)
                {

                    Console.WriteLine("Invalid user name or already exists!");
                    uName = IsUserNameValid();
                    t2 = MainUI.client.IsUserNameExists(mail);
                    Console.WriteLine("validating your email username...");
                    t2.Wait();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.InnerException);
                Console.WriteLine("press any key to go back");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Password: ");
            string pass = Console.ReadLine();

            DateTime birthDay = new DateTime(year, month, day);
            PlayerDTO p = new PlayerDTO {FirstName = fName, LastName = lName, BirthDate = birthDay, Email = mail, Gender = gender, Pass = pass, UserName = uName };
            //exception
            Task<PlayerDTO> t3 = MainUI.client.AddPlayer(p);
            Console.WriteLine("signing you up...");
            Console.WriteLine("this may take a few moments...");
            t3.Wait();
            if(t3.Result == null)
                Console.WriteLine("somthing went wrong");
            else
                Console.WriteLine("SUCCESS!");

            Console.WriteLine("Press any key to go back");

            Console.ReadKey();

        }

        //מסננת קלט לשם
        public string IsNameValid()
        {
            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] < 'A' || name[i] > 'z')
                {
                    Console.WriteLine("invalid name! The name must contain letters only! please type a new name:");
                    name = Console.ReadLine();
                    i = 0;
                }

            }
            return name;
        }

        public string IsUserNameValid()
        {

            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] < '0' || name[i] > 'z')
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
