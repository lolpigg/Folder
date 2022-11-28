using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder
{
    static class Folders
    {
        public static void Disk()
        {
            int i = 0;
            Console.WriteLine($"Добро пожаловать в проводник! Выберите диск.\n");
            DriveInfo[] disks = DriveInfo.GetDrives();
            foreach (var disk in disks)
            {
                Console.WriteLine($"  {disk.Name} Свободно {disk.TotalFreeSpace / 1073741824}ГБ из {disk.TotalSize / 1073741824}ГБ.");
                i++;
            }
            Operation();
        }
        private static void Operation()
        {
            do
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Escape:
                        break;
                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.UpArrow:
                        Arrow.ArrowAct("Up");
                        break;
                    case ConsoleKey.DownArrow:
                        Arrow.ArrowAct("Down");
                        break;
                }
            } while (true);
        }
    }
}
