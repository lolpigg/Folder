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
        public static int ArrowAct()
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
                        if (Pos < Min)
                        {
                            Pos = Max;
                        }
                        else if (Pos > Max)
                        {
                            Pos = Min;
                        }
                        Console.SetCursorPosition(0, Pos);
                        Console.Write(ArrowStr);
                        break;
                    case ConsoleKey.DownArrow:
                        {
                            if (Pos < Min)
                            {
                                Pos = Max;
                            }
                            if (Pos > Max)
                            {
                                Pos = Min;
                            }
                            Pos++;
                            Console.SetCursorPosition(0, Pos);
                            Console.Write(ArrowStr);
                        }
                        break;
                    case ConsoleKey.Escape:
                        Pos = -1000;
                        return Pos;
                        break;
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.Clear();
            return Pos;
        }
    }
}
