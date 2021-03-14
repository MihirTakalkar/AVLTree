using System;
using System.Collections.Generic;
using System.Text;

namespace AVL
{
      
    class Node<T> where T : IComparable<T> 
    {
        public T Val { get; set; }
        public Node<T> LeftNode { get; set; }
        public Node<T> RightNode { get; set; }

        public int ChildCount
        {
            get
            {
                int count = 0;
                if(LeftNode != null)
                {
                    count++;
                }
                if(RightNode != null)
                {
                    count++;
                }
                return count;
            }
        }

        public int Height
        {
            get
            {
                int leftHeight = 0;
                if(LeftNode != null)
                {
                    leftHeight = LeftNode.Height;
                }

                int rightHeight = 0;
                if(RightNode != null)
                {
                    rightHeight = RightNode.Height;
                }

                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }

        public int Balance
        {
            get
            {
                int leftHeight = 0;
                if (LeftNode != null)
                {
                    leftHeight = LeftNode.Height;
                }

                int rightHeight = 0;
                if (RightNode != null)
                {
                    rightHeight = RightNode.Height;
                }

                return rightHeight - leftHeight;
            }
        }

        public Node(T val, Node<T> rightChild = null, Node<T> leftChild = null)
        {
            this.Val = val;
            LeftNode = leftChild;
            RightNode = rightChild;
        }
    }
}
