using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01PriorityQueueWithBinaryHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new PriorityQueue<int>();

            elements.Enqueue(5);
            elements.Enqueue(2);
            elements.Enqueue(10);
            elements.Enqueue(0);
            elements.Enqueue(999);

            Console.WriteLine("Peek: "+elements.Peek());
            Console.WriteLine("Dequeue");
            while (elements.Count > 0)
            {
                Console.WriteLine(elements.Dequeue());
            }
        }
    }
}