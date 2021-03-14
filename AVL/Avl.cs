using System;
using System.Collections.Generic;
using System.Text;

namespace AVL
{
    class Avl<T> where T : IComparable<T>
    {
        Node<T> root;
        int nodeCount;

        //insert
        Node<T> Insert(Node<T> currentNode, T value)
        {

        }


        //inserthelper
        void InsertHelper()
        {

        }

        //rotations
        Node<T> RightRotate(Node<T> unbalancedNode)
        {
            Node<T> pivot = unbalancedNode.LeftNode;
            unbalancedNode.RightNode = pivot.RightNode;
            pivot.RightNode = unbalancedNode;
            return pivot;
        }

        Node<T> LeftRotate(Node<T> unbalancedNode)
        {
            Node<T> pivot = unbalancedNode.RightNode;
            unbalancedNode.LeftNode = pivot.LeftNode;
            pivot.LeftNode = unbalancedNode;
            return pivot;
        }

        //balance
        Node<T> Balance(Node<T> currentNode)
        {
            //if tree is leaning left but subtree is leaning right
            if(currentNode.Balance < -1)
            {
                if(currentNode.LeftNode.Balance > 0)
                {
                    currentNode.LeftNode = LeftRotate(currentNode.LeftNode);
                }
                currentNode = RightRotate(currentNode);
            }

            //if tree is leaning right but subtree is leaning left
            else if(currentNode.Balance > 1)
            {
                if(currentNode.RightNode.Balance < 0)
                {
                    currentNode.RightNode = RightRotate(currentNode.RightNode);
                }
                currentNode = LeftRotate(currentNode);
            }

            return currentNode;
        }

        //remove

    }
}
