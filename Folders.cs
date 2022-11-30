using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder
{
    static class Folders
    {
        public static int i = 0;
        public static void Processing()
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
            Console.WriteLine($"Добро пожаловать в проводник! Выберите диск.\n");
            DriveInfo[] disks = DriveInfo.GetDrives();
            foreach (var disk in disks)
            {
                Console.WriteLine($"  {disk.Name} Свободно {disk.TotalFreeSpace / 1073741824}ГБ из {disk.TotalSize / 1073741824}ГБ.");
                i++;
            }
            Arrow Arrow = new Arrow(2, disks.Length+1);
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
                Process process = new Process();
                process.StartInfo.FileName = Path;
                process.StartInfo.UseShellExecute = true;
                process.Start();
                return string.Empty;
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
            Arrow menu = new Arrow(2, FileNum);
            int chosenPosition = menu.ArrowAct() - 2;
            if (chosenPosition == -1002)
            {
                Console.Clear();
                return string.Empty;
            }
            return Papka(allElements[chosenPosition]);
        }
    }
}
