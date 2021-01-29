using System;
using TamaguchiClient.WebServices;
using System.Threading.Tasks;
using TamaguchiClient.UI;

namespace TamaguchiClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MainUI UI = new MainUI();
            UI.ApplicationStart();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("bye bye");
        }
    }
}
