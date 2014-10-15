using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            int[] arr = new int[11];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 4;
            arr[3] = 8;
            arr[4] = 16;
            arr[5] = 32;
            arr[6] = 64;
            arr[7] = 128;
            arr[8] = 256;
            arr[9] = 512;
            arr[10] = 1024;
            int input = 0;
          //  Console.WriteLine("Enter your input");
            input = int.Parse(Console.ReadLine());
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (input - arr[i] >= 0)
                {

                    input = input - arr[i];
                    arr[i] = 0;
                }
            }

           // Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] != 0)
                    Console.WriteLine("A{0}", 10 - i);
        }
    }
}
