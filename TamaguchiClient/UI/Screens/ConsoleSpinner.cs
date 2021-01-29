using System;
using System.Collections.Generic;
using System.Text;

//namespace Tamaguchi.UI.Screens
//{
//    class ConsoleSpinner
//    {
//        bool increment = true,
//             loop = false;
//        int counter = 0;
//        int delay;
//        string[] sequence;

//        public ConsoleSpinner(string sSequence = "dots", int iDelay = 100, bool bLoop = false)
//        {
//            delay = iDelay;
//            if (sSequence == "dots")
//            {
//                sequence = new string[] { ".   ", "..  ", "... ", "...." };
//                loop = true;
//            }
//            else if (sSequence == "slashes")
//                sequence = new string[] { "/", "-", "\\", "|" };
//            else if (sSequence == "circles")
//                sequence = new string[] { ".", "o", "0", "o" };
//            else if (sSequence == "crosses")
//                sequence = new string[] { "+", "x" };
//            else if (sSequence == "arrows")
//                sequence = new string[] { "V", "<", "^", ">" };
//        }

//        public void Turn()
//        {
//            if (loop)
//            {
//                if (counter >= sequence.Length - 1)
//                    increment = false;
//                if (counter <= 0)
//                    increment = true;

//                if (increment)
//                    counter++;
//                else if (!increment)
//                    counter--;
//            }
//            else
//            {
//                counter++;

//                if (counter >= sequence.Length)
//                    counter = 0;
//            }

//            Console.Write(sequence[counter]);
//            Console.SetCursorPosition(Console.CursorLeft - sequence[counter].Length, Console.CursorTop);

//            System.Threading.Thread.Sleep(delay);
//        }
//    }
//}
