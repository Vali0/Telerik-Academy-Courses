using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09SequenceMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = PrintSequence(2, 50);
        }

        private static Queue<int> PrintSequence(int number, int count)
        {
            Queue<int> sequence = new Queue<int>();

            sequence.Enqueue(number);
            int currentElement = 0;

            for (int i = 0; i < count; i++)
            {
                currentElement = sequence.Dequeue();
                Console.WriteLine(currentElement);

                sequence.Enqueue(currentElement + 1);
                sequence.Enqueue(2 * currentElement + 1);
                sequence.Enqueue(currentElement + 2);
            }

            return sequence;
        }
    }
}