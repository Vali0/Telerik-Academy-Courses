namespace Task01Tree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FindInTree
    {
        static void Main()
        {
            Dictionary<int, Node<int>> nodes = ParseElementsToTree();

            //a) find root node
            Node<int> rootNode = FindRootNode(nodes);
            Console.WriteLine("Root node: {0}.", rootNode.Value);

            //b) find all leaf nodes
            List<Node<int>> leafNodes = FindLeafNodes(nodes);
            Console.WriteLine("Find all leaf nodes");
            PrintNodes(leafNodes);

            //c) find all all middle nodes
            List<Node<int>> middleNodes = FindMiddleNodes(nodes);
            Console.WriteLine("Find all middle nodes");
            PrintNodes(middleNodes);

            //d) find the longest path at the tree from root only lenth of the path.
            int longestPath = FindLongestPath(rootNode);
            Console.WriteLine("Longest path from root: {0}", longestPath);

            //d) find two longest paths from root adding all paths to a list of lists
            List<List<int>> treePaths = new List<List<int>>();
            List<int> currentPath = new List<int>();
            currentPath.Add(rootNode.Value);
            GetLongestPath(rootNode, treePaths, currentPath);
            treePaths.Sort((x, y) => x.Count.CompareTo(y.Count));

            Console.WriteLine("Display longest path:");

            for (int i = treePaths[0].Count - 1; i > 0; i--)
            {
                Console.Write("{0}, ", treePaths[0][i]);
            }

            for (int i = 1; i < treePaths.Count; i++)
            {
                if (treePaths[i][1] != treePaths[0][1])
                {
                    Console.WriteLine(string.Join(", ", treePaths[i]));
                    break;
                }
            }

            //e) find all paths in the tree with given sum S of their nodes
            Console.WriteLine("Enter searching sum");
            int sum = int.Parse(Console.ReadLine());
            treePaths = new List<List<int>>();
            currentPath = new List<int>();

            foreach (var node in nodes)
            {
                currentPath.Add(node.Value.Value);
                FindPathWithSumS(node.Value, treePaths, currentPath, sum);
                currentPath.Clear();
            }

            Console.WriteLine("Display all paths with sum {0}:", sum);
            if (treePaths.Count > 0)
            {
                for (int i = 0; i < treePaths.Count; i++)
                {
                    Console.WriteLine(string.Join(", ", treePaths[i]));
                }
            }
            else
            {
                Console.WriteLine("There is no path with this sum.");
            }

            //f) all subtrees with given sum S of their nodes  - BFS
            Console.WriteLine("Enter searching sum");
            sum = int.Parse(Console.ReadLine());
            treePaths = new List<List<int>>();
            currentPath = new List<int>();

            foreach (var node in nodes)
            {
                //currentPath.Add(node.Value.Value);
                FindSubtreeWithSumS(node.Value, treePaths, currentPath, sum);
                currentPath.Clear();
            }

            Console.WriteLine("Display all sutree with sum {0}:", sum);
            if (treePaths.Count > 0)
            {
                for (int i = 0; i < treePaths.Count; i++)
                {
                    Console.WriteLine(string.Join(", ", treePaths[i]));
                }
            }
            else
            {
                Console.WriteLine("There is no subtree with this sum.");
            }
        }

        private static Dictionary<int, Node<int>> ParseElementsToTree()
        {
            Console.WriteLine("Enter size of the tree");
            int treeSize = int.Parse(Console.ReadLine());
            Dictionary<int, Node<int>> nodes = new Dictionary<int, Node<int>>();

            for (int i = 0; i < treeSize - 1; i++)
            {
                Console.WriteLine("Enter node connection separated by interval ex. 5 6");
                string edges = Console.ReadLine();
                string[] edjeParts = edges.Split(new char[] { ' ' });

                int parent = int.Parse(edjeParts[0]);
                int child = int.Parse(edjeParts[1]);

                Node<int> parentNode;
                Node<int> childNode;

                if (nodes.ContainsKey(parent))
                {
                    parentNode = nodes[parent];
                    if (nodes.ContainsKey(child))
                    {
                        childNode = nodes[child];
                        childNode.HasParent = true;
                    }
                    else
                    {
                        childNode = new Node<int>(child);
                        nodes.Add(child, childNode);
                    }
                }
                else
                {
                    parentNode = new Node<int>(parent);
                    if (nodes.ContainsKey(child))
                    {
                        childNode = nodes[child];
                        childNode.HasParent = true;
                    }
                    else
                    {
                        childNode = new Node<int>(child);
                        nodes.Add(child, childNode);
                    }

                    nodes.Add(parent, parentNode);
                }

                parentNode.AddChild(childNode);
            }

            return nodes;
        }

        private static Node<int> FindRootNode(Dictionary<int, Node<int>> nodes)
        {
            foreach (var node in nodes)
            {
                if (!node.Value.HasParent)
                {
                    return node.Value;
                }
            }

            throw new ArgumentException("This three has no root.");
        }

        private static List<Node<int>> FindLeafNodes(Dictionary<int, Node<int>> nodes)
        {
            List<Node<int>> leafs = new List<Node<int>>();
            foreach (var node in nodes)
            {
                if (node.Value.Children.Count == 0)
                {
                    leafs.Add(node.Value);
                }
            }

            return leafs;
        }

        private static List<Node<int>> FindMiddleNodes(Dictionary<int, Node<int>> nodes)
        {
            List<Node<int>> middles = new List<Node<int>>();
            foreach (var node in nodes)
            {
                if (node.Value.Children.Count != 0 && node.Value.HasParent)
                {
                    middles.Add(node.Value);
                }
            }

            return middles;
        }

        private static int FindLongestPath(Node<int> rootNode)
        {
            if (rootNode.Children.Count == 0)
            {
                return 0;
            }

            int maxPath = 0;
            foreach (var node in rootNode.Children)
            {
                maxPath = Math.Max(maxPath, FindLongestPath(node));
            }

            return maxPath + 1;
        }

        private static void GetLongestPath(Node<int> rootNode, List<List<int>> treePaths, List<int> currentPath)
        {
            if (rootNode.Children.Count == 0)
            {
                treePaths.Add(currentPath.GetRange(0, currentPath.Count));
            }
            else
            {
                foreach (var child in rootNode.Children)
                {
                    currentPath.Add(child.Value);
                    GetLongestPath(child, treePaths, currentPath);
                    currentPath.RemoveAt(currentPath.Count - 1);
                }
            }
        }

        private static void FindPathWithSumS(Node<int> node, List<List<int>> treePaths, List<int> currentPath, int sum)
        {
            int currentSum = currentPath.Sum();
            if (currentSum == sum)
            {
                treePaths.Add(currentPath.GetRange(0, currentPath.Count));
            }
            else if (node.Children.Count > 0 || currentSum < sum)
            {
                foreach (var child in node.Children)
                {
                    currentPath.Add(child.Value);
                    FindPathWithSumS(child, treePaths, currentPath, sum);
                    currentPath.RemoveAt(currentPath.Count - 1);
                }
            }
        }

        private static void FindSubtreeWithSumS(Node<int> node, List<List<int>> treePaths, List<int> currentPath, int sum)
        {
            Queue<Node<int>> queue = new Queue<Node<int>>();
            Node<int> currentNode;
            queue.Enqueue(node);
            int currentSum = node.Value;
            while (queue.Count > 0)
            {
                if (currentSum > sum)
                {
                    break;
                }

                currentNode = queue.Peek();
                foreach (var child in currentNode.Children)
                {
                    queue.Enqueue(child);
                    currentSum += child.Value;
                }
                currentPath.Add(queue.Dequeue().Value);
            }

            if (currentSum == sum)
            {
                treePaths.Add(currentPath.GetRange(0, currentPath.Count));
            }
        }

        private static void PrintNodes(List<Node<int>> elements)
        {
            StringBuilder result = new StringBuilder();
            foreach (var element in elements)
            {
                result.Append(element.Value);
                result.Append(", ");
            }

            result.Remove(result.Length - 2, 2);
            Console.WriteLine(result.ToString());
        }
    }
}