using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder
{
    static class Folders
    {
        public static void Process()
        {
            do
            {
                string DiskPath = Disk();
                string PapkaPath = Papka(DiskPath);
            } while (true);
        }
        public static string Disk()
        {
            Console.Clear();
            int i = 0;
            Console.WriteLine($"Добро пожаловать в проводник! Выберите диск.\n");
            DriveInfo[] disks = DriveInfo.GetDrives();
            foreach (var disk in disks)
            {
                Console.WriteLine($"  {disk.Name} Свободно {disk.TotalFreeSpace / 1073741824}ГБ из {disk.TotalSize / 1073741824}ГБ.");
                i++;
            }
            Arrow Arrow = new Arrow(i - 1, i);
            int Pos = Arrow.ArrowAct() - 2;
            return disks[Pos].Name;
        }
        static private string Papka(string Path)
        {
            int FileNum = 0;
            Console.WriteLine("Выбраны папки.\n");
            List<string> allElements = new List<string>();
            var PapkaInf = new DirectoryInfo(Path);
            if (Path.Contains("."))
            {
                return Path;
            }
            string[] allDirectories = Directory.GetDirectories(Path);
            string[] allFiles = Directory.GetFiles(Path);
            allElements.AddRange(allDirectories);
            allElements.AddRange(allFiles);
            allElements.Sort();
            foreach (string elements in allElements)
            {
                Console.WriteLine($"  {elements}");
                Console.SetCursorPosition(90, FileNum + 2);
                Console.WriteLine($"  {PapkaInf.CreationTime}");
                FileNum++;
            }
            Arrow menu = new Arrow(1, FileNum - 1);
            int chosenPosition = Arrow.ArrowAct() - 2;
            if (chosenPosition == -100)
            {
                Console.Clear();
                return string.Empty;
            }
            return Papka(allElements[chosenPosition]);
        }
    }
}
