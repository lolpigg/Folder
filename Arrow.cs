using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder
{
    class Arrow
    {
        public static int Max, Min, Cur;
        public static int Pos;
        public static string ArrowStr = "->";
        public Arrow(int min, int max)
        {
            Cur = min;
            Max = max;
            Min = min;
        }
        public int ArrowAct()
        {
            ConsoleKeyInfo key;
            Pos = Min;
            do
            {
                key = Console.ReadKey(true);
                Console.SetCursorPosition(0, Pos);
                Console.Write("  ");
                switch (key.Key)
                {
                    case ConsoleKey.UpArrow:
                        Pos--;
                       /* if (Pos == 1 || Pos == 0)
                        {
                            Pos = Max + 2;
                        }*/
                        if (Pos < Min)
                        {
                            Pos = Max;
                        }
                        else if (Pos > Max + 1)
                        {
                            Pos = Min + 1;
                        }
                        Console.SetCursorPosition(0, Pos);
                        Console.Write(ArrowStr);
                        break;
                    case ConsoleKey.DownArrow:
                        /*if (Pos == Max + 2)
                        {
                            Pos = Min;
                        }*/
                        Pos++;
                        if (Pos <= Min + 1)
                        {
                            Pos = Max;
                        }
                        else if (Pos > Max + 1)
                        {
                            Pos = Min;
                        }
                        Console.SetCursorPosition(0, Pos);
                        Console.Write(ArrowStr);
                        break;
                    case ConsoleKey.Escape:
                        return -1000;
                        break;
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.Clear();
            return Pos;
        }
    }
}
