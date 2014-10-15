using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13ADTQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<int> numbers = new LinkedQueue<int>();

            for (int i = 0; i < 10; i++)
            {
                numbers.Enqueue(i);
            }

            Console.WriteLine("Is containing 5: " + numbers.Contains(5));

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers.Dequeue());
            }

            numbers.Enqueue(999);
            Console.WriteLine(numbers.Peek());
            Console.WriteLine(numbers.Dequeue());
        }
    }
}
