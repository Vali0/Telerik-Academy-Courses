﻿namespace Task10ShortestSequenceForPath
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static IList<IEnumerable<T>> GetShortestSequences<T>(T start, T end, IList<Func<T, T>> operations)
            where T : IComparable<T>
        {
            var results = new List<IEnumerable<T>>();
            var visited = new HashSet<T>();
            var currentWave = new Queue<Node<T>>();
            visited.Add(start);
            currentWave.Enqueue(new Node<T>(start));
            int level = 1;

            while (currentWave.Count != 0)
            {
                var nextWave = new Queue<Node<T>>();
                var nextVisited = new HashSet<T>();
                level++;

                while (currentWave.Count != 0)
                {
                    var currentNode = currentWave.Dequeue();
                    foreach (var operation in operations)
                    {
                        T nextElement = operation(currentNode.Value);
                        if (nextElement.CompareTo(end) > 0)
                        {
                            continue;
                        }
                        if (visited.Contains(nextElement))
                        {
                            continue;
                        }

                        var nextNode = new Node<T>(nextElement);
                        nextNode.Previous = currentNode;
                        nextVisited.Add(nextElement);
                        nextWave.Enqueue(nextNode);

                        if (nextElement.Equals(end))
                        {
                            var sequence = new ReversedLinkedList<T>(nextNode);
                            results.Add(sequence.Reverse());
                        }
                    }
                }

                visited.UnionWith(nextVisited);

                if (results.Count != 0)
                {
                    nextWave.Clear();
                }

                currentWave = nextWave;
            }

            return results;
        }

        static void Main()
        {
            Func<int, int>[] operations =
            {
                x => x + 1,
                x => x + 2,
                x => x * 2,
            };
            foreach (var sequence in GetShortestSequences(5, 16, operations))
            {
                Console.WriteLine(string.Join(" -> ", sequence));
            }
        }
    }
}