using System;

public class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>>
    where T : IComparable<T>
{
    private T value; // Contains the value of the node
    private bool hasParent; // Shows whether the current node has parent
    private BinaryTreeNode<T> parent;
    private BinaryTreeNode<T> leftChild; // Contains the left child of the node
    private BinaryTreeNode<T> rightChild; // Contains the right child of the node

    public BinaryTreeNode(T value, BinaryTreeNode<T> leftChild,
        BinaryTreeNode<T> rightChild)
    {
        if (value == null)
        {
            throw new ArgumentNullException("Cannot insert null value!");
        }
        this.value = value;
        this.parent = null;
        this.leftChild = leftChild;
        this.rightChild = rightChild;
    }

    public BinaryTreeNode(T value) : this(value, null, null)
    {
    }

    public T Value
    {
        get
        {
            return this.value;
        }
        set
        {
            this.value = value;
        }
    }

    public BinaryTreeNode<T> LeftChild
    {
        get
        {
            return this.leftChild;
        }
        set
        {
            if (value == null)
            {
                return;
            }
            if (value.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }
            value.hasParent = true;
            this.leftChild = value;
        }
    }

    public BinaryTreeNode<T> RightChild
    {
        get
        {
            return this.rightChild;
        }
        set
        {
            if (value == null)
            {
                return;
            }

            if (value.hasParent)
            {
                throw new ArgumentException("The node already has a parent!");
            }

            value.hasParent = true;
            this.rightChild = value;
        }
    }

    public override string ToString()
    {
        return this.value.ToString();
    }

    public override int GetHashCode()
    {
        return this.value.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        BinaryTreeNode<T> other = (BinaryTreeNode<T>)obj;

        return this.CompareTo(other) == 0;
    }

    public int CompareTo(BinaryTreeNode<T> other)
    {
        return this.value.CompareTo(other.value);
    }

    public static BinaryTreeNode<T> Insert(T value, BinaryTreeNode<T> parentNode, BinaryTreeNode<T> node)
    {
        if (node == null)
        {
            node = new BinaryTreeNode<T>(value);

            node.parent = parentNode;
        }
        else
        {
            int compareTo = value.CompareTo(node.value);

            if (compareTo < 0)
            {
                node.leftChild =
                    Insert(value, node, node.leftChild);
            }
            else if (compareTo > 0)
            {
                node.rightChild =
                    Insert(value, node, node.rightChild);
            }
        }

        return node;
    }

    public static BinaryTreeNode<T> Find(T value, BinaryTreeNode<T> root)
    {
        BinaryTreeNode<T> node = root;

        while (node != null)
        {
            int compareTo = value.CompareTo(node.value);

            if (compareTo < 0)
            {
                node = node.leftChild;
            }
            else if (compareTo > 0)
            {
                node = node.rightChild;
            }
            else
            {
                break;
            }
        }

        return node;
    }

    public static void Remove(BinaryTreeNode<T> node, BinaryTreeNode<T> root)
    {
        // Case 3: If the node has two children.
        // Note that if we get here at the end
        // the node will be with at most one child
        if (node.leftChild != null && node.rightChild != null)
        {
            BinaryTreeNode<T> replacement = node.rightChild;

            while (replacement.leftChild != null)
            {
                replacement = replacement.leftChild;
            }

            node.value = replacement.value;

            node = replacement;
        }

        // Case 1 and 2: If the node has at most one child

        BinaryTreeNode<T> theChild = node.leftChild != null ? node.leftChild : node.rightChild;

        // If the element to be deleted has one child

        if (theChild != null)
        {
            theChild.parent = node.parent;

            // Handle the case when the element is the root

            if (node.parent == null)
            {
                root = theChild;
            }
            else
            {
                // Replace the element with its child subtree
                if (node.parent.leftChild == node)
                {
                    node.parent.leftChild = theChild;
                }
                else
                {
                    node.parent.rightChild = theChild;
                }
            }
        }
        else
        {
            // Handle the case when the element is the root
            if (node.parent == null)
            {
                root = null;
            }
            else
            {
                // Remove the element - it is a leaf
                if (node.parent.leftChild == node)
                {
                    node.parent.leftChild = null;
                }
                else
                {
                    node.parent.rightChild = null;
                }
            }
        }
    }
}