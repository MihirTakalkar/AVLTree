using System;
using System.Collections.Generic;
using System.Text;

namespace AVL
{
    class Avl<T> where T : IComparable<T>
    {
        Node<T> root;
        int Count = 0;
        //insert
        Node<T> Insert(Node<T> currentNode, T value)
        {
            if(currentNode == null)
            {
                return new Node<T>(value);
            }

            int comp = value.CompareTo(currentNode.Val);
            if(comp < 0)
            {
                currentNode.LeftNode = Insert(currentNode.LeftNode, value);
            }

            else if (comp > 0)
            {
                currentNode.RightNode = Insert(currentNode.RightNode, value);
            }

            return Balance(currentNode);
        }


        //inserthelper
        public void Insert(T val)
        {
            root = Insert(root, val);
            Count++;
        }

        //rotations
        Node<T> RightRotate(Node<T> unbalancedNode)
        {
            Node<T> pivot = unbalancedNode.LeftNode;
            unbalancedNode.LeftNode = pivot.RightNode;
            pivot.RightNode = unbalancedNode;
            return pivot;
        }

        Node<T> LeftRotate(Node<T> unbalancedNode)
        {
            Node<T> pivot = unbalancedNode.RightNode;
            unbalancedNode.RightNode = pivot.LeftNode;
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
                currentNode = RightRotate(currentNode); // right rotate breaks currentNode
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
        Node<T> Delete(Node<T> currentNode, T val)
        {
            if()
            {
                
            }

            int comp = val.CompareTo(currentNode.Val);
            if (comp < 0)
            {
                currentNode.LeftNode = Delete(currentNode.LeftNode, val);
            }

            else if (comp > 0)
            {
                currentNode.RightNode = Delete(currentNode.RightNode, val);
            }

            else
            {
                //currentnode is the one we want to delete
                //no children
                if (currentNode.ChildCount == 0)
                {
                    return null;
                }

                //one child 
                else if (currentNode.ChildCount == 1)
                {
                    if(currentNode.RightNode == null)
                    {
                        return currentNode.LeftNode;
                    }

                    else if (currentNode.LeftNode == null)
                    {
                        return currentNode.RightNode;
                    }
                }

                //two children
            }
        }

        public bool Delete(T val)
        {
            int originalCount = Count;
            root = Delete(root, val);

            return originalCount < Count;
        }
    }
}
