using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task02DirectoryTraversal
{
    class Program
    {
        private static readonly List<string> files = new List<string>();

        static void Main(string[] args)
        {
            string rootPath = @"C:\Windows";
            string fileExtension = "*.exe";

            DirSearch(rootPath, fileExtension);
            Console.WriteLine(string.Join("\n", files));
        }

        private static void DirSearch(string sDir, string extension)
        {
            try
            {
                foreach (string dir in Directory.GetDirectories(sDir))
                {
                    foreach (string file in Directory.GetFiles(dir, extension))
                    {
                        files.Add(file);
                    }

                    DirSearch(dir, extension);
                }
            }
            catch (UnauthorizedAccessException excpt)
            {
                Console.WriteLine("Unauthorized access to that directory\n" + excpt.Message);
            }
        }
    }
}