using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04RecoverMessage
{
    class Program
    {
        static SortedDictionary<char, Node> graph = new SortedDictionary<char, Node>();
        static List<Node> sortedElements = new List<Node>();
        static SortedSet<Node> noIncomingEdges = new SortedSet<Node>();

        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMessages; i++)
            {
                string line = Console.ReadLine();
                var previousNode = GetNode(line[0]);
                for (int j = 1; j < line.Length; j++)
                {
                    var currentNode = GetNode(line[j]);
                    previousNode.Successor.Add(currentNode);
                    currentNode.Parents.Add(previousNode);

                    previousNode = currentNode;
                }
            }

            FindParents();
            
            while (noIncomingEdges.Count > 0)
            {
                var parentNode = noIncomingEdges.Min; // S
                noIncomingEdges.Remove(parentNode);
                sortedElements.Add(parentNode); // L


                var children = parentNode.Successor.ToList();

                foreach (var child in children)
                {
                    child.Parents.Remove(parentNode);
                    parentNode.Successor.Remove(child);

                    if (child.Parents.Count == 0)
                    {
                        noIncomingEdges.Add(child);
                    }
                }
            }

            foreach (var item in sortedElements)
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }

        static void FindParents()
        {
            foreach (var node in graph.Values)
            {
                if (node.Parents.Count == 0)
                {
                    noIncomingEdges.Add(node);
                }
            }
        }

        static Node GetNode(char symbol)
        {
            if (graph.ContainsKey(symbol))
            {
                return graph[symbol];
            }

            var newNode = new Node(symbol);
            graph.Add(symbol, newNode);

            return newNode;
        }
    }

    class Node:IComparable<Node>
    {
        public Node(char value)
        {
            this.Value = value;
            this.Successor = new HashSet<Node>();
            this.Parents = new HashSet<Node>();
        }

        public char Value { get; set; }

        public ICollection<Node> Successor;

        public ICollection<Node> Parents;



        public override string ToString()
        {
            return this.Value.ToString();
        }

        public int CompareTo(Node other)
        {
            return this.Value.CompareTo(other.Value);
        }
    }
}