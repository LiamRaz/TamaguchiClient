
using Tamaguchi.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Tamaguchi.UI
{
    class MainUI
    {
        private Screen StartScreen;
        public static Player currentPlayer;
        public static TamaguchiContext db;

        public MainUI()
        {

            currentPlayer = null;
            StartScreen = new StartScreen();

        }
        public void ApplicationStart()
        {
            db = new TamaguchiContext();
            StartScreen.Show();
        }
    }
}
