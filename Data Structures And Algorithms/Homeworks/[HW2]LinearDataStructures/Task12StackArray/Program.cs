using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12StackArray
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray<int> numbers = new StackArray<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Push(i);
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers.Pop());
            }

            numbers.Push(999);
            Console.WriteLine(numbers.Pop());
        }
    }
}
