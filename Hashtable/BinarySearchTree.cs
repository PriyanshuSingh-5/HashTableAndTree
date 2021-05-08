using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable
{
    class BinarySearchTree<T> where T:IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> Left { get; set; }
        public BinarySearchTree<T> Right { get; set; }
        public BinarySearchTree(T nodedata)//initializing the tree nodes
        {
            NodeData = nodedata;
            Left = null;
            Right = null;
        }

        public void Insert(T item)  //method to insert in tree
        {
            T currentValue = NodeData;
            if (currentValue.CompareTo(item) > 0) //condition for inserting in left node
            {
                if (Left == null)
                {
                    Left = new BinarySearchTree<T>(item);
                }
                else
                {
                    Left.Insert(item);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = new BinarySearchTree<T>(item);
                }
                else
                {
                    Right.Insert(item); //else insert in right node
                }
            }
        }

        int leftCount = 0;
        int rightCount = 0;
        public void Display()
        {
            if (Left != null)
            {
                leftCount++;
                Left.Display();
            }
            Console.WriteLine(NodeData);
            if (Left != null)
            {
                rightCount++;
                Right.Display();
            }
        }

        bool flag = false;
        public bool Search(T item, BinarySearchTree<T> tree) //search the node in the binary tree
        {
            if (tree == null)
                return false;
            if (tree.NodeData.Equals(item))
            {
                flag = true;
            }
            else if (tree.NodeData.CompareTo(item) < 0)
            {
                Search(item, tree.Right);
            }
            else
            {
                Search(item, tree.Left);
            }
            return flag;
        }

        public void Size() //to get the size of the tree
        {
            Console.WriteLine("The size of the BST is: " + (1 + leftCount + rightCount));
        }
    }
}

