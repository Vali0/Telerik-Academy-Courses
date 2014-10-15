using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Task03CableCompany
{
    class Program
    {
        public static List<Edge<int>> GetMinimalspanningTreeUsingPrim(List<Edge<int>> graph, int start)
        {
            var result = new List<Edge<int>>();
            var priority = new OrderedBag<Edge<int>>();
            var visited = new HashSet<int>();
            visited.Add(start);

            foreach (var edge in graph)
            {
                if (edge.Start == start || edge.End == start)
                {
                    priority.Add(edge);
                }
            }

            while (priority.Count > 0)
            {
                var current = priority.RemoveFirst();
                if (!(visited.Contains(current.Start) && visited.Contains(current.End)))
                {
                    result.Add(current);
                }

                if (visited.Contains(current.Start) && !visited.Contains(current.End))
                {
                    priority.AddMany(graph.Where(x => x.Start == current.End || x.End == current.End));
                    visited.Add(current.End);
                }
                else if (!visited.Contains(current.Start) && visited.Contains(current.End))
                {
                    priority.AddMany(graph.Where(x => x.Start == current.Start || x.End == current.Start));
                    visited.Add(current.Start);
                }
            }
            return result;
        }
        internal static void Main()
        {
            var neighbourhood = new List<Edge<int>>();
            neighbourhood.Add(new Edge<int>(1, 3, 5));
            neighbourhood.Add(new Edge<int>(1, 2, 4));
            neighbourhood.Add(new Edge<int>(1, 4, 9));
            neighbourhood.Add(new Edge<int>(2, 4, 2));
            neighbourhood.Add(new Edge<int>(3, 4, 20));
            neighbourhood.Add(new Edge<int>(3, 5, 7));
            neighbourhood.Add(new Edge<int>(4, 5, 8));
            neighbourhood.Add(new Edge<int>(4, 7, 6));
            neighbourhood.Add(new Edge<int>(5, 6, 12));
            neighbourhood.Add(new Edge<int>(6, 8, 2));
            neighbourhood.Add(new Edge<int>(7, 8, 4));

            var forWiring = GetMinimalspanningTreeUsingPrim(neighbourhood, 1);

            foreach (var wire in forWiring)
            {
                Console.WriteLine("Wire from {0} to {1} -> length: {2}", wire.Start, wire.End, wire.Weight);
            }

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total wire length: {0}", forWiring.Sum(x => x.Weight));
        }
    }
}