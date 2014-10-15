using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03TreiImplementation
{
    class LargeFileGenerator
    {
        public static void GenerateBigFile()
        {
            string inputPath = "text.txt";
            Console.WriteLine("It will take ~20seconds or more depending of OS, working please wait...");

            string text = "bira bira bira";

            using (StreamWriter writer = new StreamWriter(inputPath))
            {
                long fileSize = 0;
                long maxSize = 100000000; // ~100 MB
                int lineNumber = 1;

                while (fileSize < maxSize)
                {
                    writer.WriteLine(text, lineNumber);
                    FileInfo file = new FileInfo("text.txt");
                    fileSize = file.Length;
                    lineNumber++;
                }
            }
        }
    }
}
