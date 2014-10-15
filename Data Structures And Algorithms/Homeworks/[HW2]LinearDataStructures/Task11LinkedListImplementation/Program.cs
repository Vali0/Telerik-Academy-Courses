using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                linkedList.Add(i);
            }

            var node = linkedList.Head;
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.NextItem;
            }
        }
    }
}
