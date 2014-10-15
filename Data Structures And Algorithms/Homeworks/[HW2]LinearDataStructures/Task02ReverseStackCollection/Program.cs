using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02ReverseStackCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            string line = "";
            Console.WriteLine("Enter single number on different line (empty line or whitespace to end)");

            do
            {
                line = Console.ReadLine();
                bool canParse = TryToParse(line);

                if (canParse)
                {
                    numbers.Push(int.Parse(line));
                }
            }
            while (!String.IsNullOrWhiteSpace(line));

            // Uncomment if you want to reverse stack. Task doesn't say if we want to reverse stack or to print nubmers in reversed order.
            //var reversedStack = ReverseStack(numbers);
            //Console.WriteLine(string.Join(", ", reversedStack));

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static bool TryToParse(string input)
        {
            int number = 0;
            bool isParsed = Int32.TryParse(input, out number);

            return isParsed;
        }

        private static Stack<int> ReverseStack(Stack<int> numbers)
        {
            Stack<int> result = new Stack<int>(numbers.Count);

            foreach (var num in numbers)
            {
                result.Push(num);
            }

            return result;
        }
    }
}