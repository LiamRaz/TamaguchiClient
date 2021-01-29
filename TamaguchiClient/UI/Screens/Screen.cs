using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamaguchiClient.UI
{
    abstract class Screen
    {
        public string Title { get; set; }
        public Screen(string title)
        {
            Title = title;
        }
        public virtual void Show()
        {
            Console.Clear();
            Random r = new Random();
            Console.ForegroundColor = (ConsoleColor)r.Next(1, 15);
            Console.WriteLine($"{Title}".PadLeft(Console.WindowWidth / 2));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
