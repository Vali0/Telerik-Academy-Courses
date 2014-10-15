using System;

/*
(Bonus task) Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements". It is not necessary to keep the tree balanced. Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() and the operators for comparison  == and !=. Add and implement the ICloneable interface for deep copy of the tree. Remark: Use two types – structure BinarySearchTree (for the tree) and class TreeNode (for the tree elements). Implement IEnumerable<T> to traverse the tree.
*/

class BinaryTreeDemo
{
    public static void Main()
    {
        // more info about code: http://www.introprogramming.info/intro-csharp-book/read-online/glava17-durveta-i-grafi/#_Toc298864450
        
        // Create the binary tree from the sample
        BinarySearchTree<int> binaryTree = new BinarySearchTree<int>(14);

        // Inserting few elements.
        binaryTree.Insert(10);
        binaryTree.Insert(20);
        binaryTree.Insert(5);
        binaryTree.Insert(18);
        binaryTree.Insert(21);
        binaryTree.PrintInorder();  // Traverse and print the tree in in-order manner
        Console.WriteLine(binaryTree.Find(20).RightChild);
        binaryTree.Remove(20);
        binaryTree.PrintInorder();

        Console.WriteLine("Foreach traverse:");
        foreach (var item in binaryTree)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        BinarySearchTree<int> tree = (BinarySearchTree<int>)binaryTree.Clone(); // Performing deeply clone

        Console.WriteLine("Clone foreach traverse:");
        foreach (var item in tree)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.WriteLine(binaryTree.Equals(tree)); // Check if they are equal
    }
}