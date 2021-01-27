using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Tamaguchi.UI;
using Tamaguchi.UI.Screens;
using Tamaguchi.Models;

namespace Tamaguchi.UI.Screens
{
    class PrintPlayerScreen : Screen
    {
        public PrintPlayerScreen() : base("Player Details")
        { }
        public override void Show()
        {
            base.Show();

            ObjectView showPlayer = new ObjectView("", MainUI.currentPlayer);
            showPlayer.Show();
            //List<object> playerStats = new List<object>();
            //playerStats.Add(MainUI.currentPlayer.UserName);
            //playerStats.Add(MainUI.currentPlayer.Email);
            //playerStats.Add(MainUI.currentPlayer.FirstName);
            //playerStats.Add(MainUI.currentPlayer.LastName);
            //playerStats.Add(MainUI.currentPlayer.BirthDate);
            //playerStats.Add(MainUI.currentPlayer.Gender);
            //playerStats.Add(MainUI.currentPlayer.Pass);
            //ObjectsList list = new ObjectsList(" ", playerStats);
            //list.Show();
            Console.WriteLine("Press Any Key To Go Back");
            Console.ReadKey();
            //if (c == null)
            //{
            //    Console.WriteLine();
            //    //Create list to be displayed on screen
            //    //Format the desired fields to be shown!(screen is not wide enough to show all)
            //    //List<Object> playerStats = (from Player in MainUI.currentPlayer
            //    //                           select new
            //    //                           {

            //    //                               Name = highScore.Game.Name,
            //    //                               HighScore = highScore.HighScore
            //    //                           }).ToList<Object>();


            //Console.WriteLine();

            //}


        }

    }
}
