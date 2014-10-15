using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01BinaryPasswords
{
    class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            long passwordsCount = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    passwordsCount *= 2;
                }
            }

            Console.WriteLine(passwordsCount);
        }
    }
}