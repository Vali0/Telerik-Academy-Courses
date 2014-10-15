using System;
using System.Collections;
using System.Collections.Generic;

public class BinarySearchTree<T> : IEnumerable<BinaryTreeNode<T>>, ICloneable
    where T : IComparable<T>
{
    private BinaryTreeNode<T> root; // The root of the tree

    public BinarySearchTree(T value, BinarySearchTree<T> leftChild, BinarySearchTree<T> rightChild)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }

        BinaryTreeNode<T> leftChildNode = leftChild != null ? leftChild.root : null;
        BinaryTreeNode<T> rightChildNode = rightChild != null ? rightChild.root : null;
        this.root = new BinaryTreeNode<T>(value, leftChildNode, rightChildNode);
    }

    public BinarySearchTree()
    {
    }

    public BinarySearchTree(T value) : this(value, null, null)
    {
    }

    public BinaryTreeNode<T> Root
    {
        get
        {
            return this.root;
        }
    }

    private void PrintInorder(BinaryTreeNode<T> root)
    {
        if (root == null)
        {
            return;
        }
        // 1. Visit the left child
        PrintInorder(root.LeftChild);
        // 2. Visit the root of this subtree
        Console.Write(root.Value + " ");
        // 3. Visit the right child
        PrintInorder(root.RightChild);
    }
    
    public void PrintInorder()
    {
        PrintInorder(this.root);
        Console.WriteLine();
    }

    public void Insert(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(
                "Cannot insert null value!");
        }

        this.root = BinaryTreeNode<T>.Insert(value, null, root);
    }

    public BinaryTreeNode<T> Find(T value)
    {
        return BinaryTreeNode<T>.Find(value, root);
    }

    public void Remove(T value)
    {
        BinaryTreeNode<T> nodeToDelete = Find(value);

        if (nodeToDelete == null)
        {
            return;
        }

        BinaryTreeNode<T>.Remove(nodeToDelete, root);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator)GetEnumerator();
    }

    private void CheckEqualNodes(BinaryTreeNode<T> node1, BinaryTreeNode<T> node2, ref bool equal)
    {
        if (node1 == null && node2 == null)
            return; // must not compare null nodes

        if ((node1 != null && node2 == null) || (node1 == null && node2 != null) || node1.CompareTo(node2) != 0)
        {
            // obviously null and something aren't equal
            equal = false;
            return;
        }

        CheckEqualNodes(node1.LeftChild, node2.LeftChild, ref equal);
        CheckEqualNodes(node1.RightChild, node2.RightChild, ref equal);
    }

    public override bool Equals(object obj)
    {
        bool equal = true;
        CheckEqualNodes(this.root, ((BinarySearchTree<T>)obj).root, ref equal);
        return equal;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int result = 17;
            result = result * 23 + ((root != null) ? this.root.GetHashCode() : 0);
            return result;
        }
    }

    public IEnumerator<BinaryTreeNode<T>> GetEnumerator()
    {
        List<BinaryTreeNode<T>> nodes = new List<BinaryTreeNode<T>>();
        GetNextNode(root, ref nodes);

        foreach (BinaryTreeNode<T> node in nodes)
            yield return node;
    }

    public void GetNextNode(BinaryTreeNode<T> node, ref List<BinaryTreeNode<T>> nodes)
    {
        if (node == null)
            return;

        GetNextNode(node.LeftChild, ref nodes);
        nodes.Add(node);
        GetNextNode(node.RightChild, ref nodes);
    }

    public object Clone()
    {
        BinarySearchTree<T> clone = new BinarySearchTree<T>();
        CopyNode(this.root, ref clone);
        return clone;
    }

    private void CopyNode(BinaryTreeNode<T> root, ref BinarySearchTree<T> tree)
    {
        if (root == null)
            return;

        tree.Insert(root.Value);
        CopyNode(root.LeftChild, ref tree);
        CopyNode(root.RightChild, ref tree);
    }
}