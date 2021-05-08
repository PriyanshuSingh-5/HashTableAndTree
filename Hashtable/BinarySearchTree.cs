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
        public BinarySearchTree(T nodedata)
        {
            NodeData = nodedata;
            Left = null;
            Right = null;
        }

        public void Insert(T item)
        {
            T currentValue = NodeData;
            if (currentValue.CompareTo(item) > 0)
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
                    Right.Insert(item);
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
    }
}

