using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ShowAllFolders
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("G://javaproject");
            DirectoryInfo[] getAllDirectories = di.GetDirectories();

            StreamWriter sw = new StreamWriter("C:/Users/ivelin/Documents/getAllDirs.txt");

            using (sw)
            {
                foreach (var directory in getAllDirectories)
                {
                    // Console.WriteLine(directory.FullName);

                    sw.WriteLine($"Name - {directory.FullName}  Files - {directory.GetFiles().Length} Directories- {directory.GetDirectories().Length}");
                }
            }

        }
    }
}
