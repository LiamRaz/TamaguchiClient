
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TamaguchiClient.DTO;
using TamaguchiClient.WebServices;

namespace TamaguchiClient.UI
{
    class MainUI
    {
        private Screen StartScreen;
        public static PlayerDTO currentPlayer;
        public static Client client;

        public MainUI()
        {

            currentPlayer = null;
            StartScreen = new StartScreen();

        }
        public void ApplicationStart()
        {
            client = new Client("https://localhost:44387/api/Tamaguchi");
            StartScreen.Show();
        }
    }
}
