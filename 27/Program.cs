using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    class Node
    {
        public Node(int data)
        {
            this.Data = data;
        }

        public int Data { get; set; }
        public Node Right { get; set; }
        public Node Left { get; set; }
    }

    class BinaryTree
    {
        private Node _root;

        public void Add(int data)
        {
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }

            Node iter = _root;

            while (true)
            {
                if (data > iter.Data)
                {
                    if (iter.Right == null)
                    {
                        iter.Right = new Node(data);
                        break;
                    }

                    iter = iter.Right;
                }
                else
                {
                    if (iter.Left == null)
                    {
                        iter.Left = new Node(data);
                        break;
                    }

                    iter = iter.Left;
                }
            }
        }

        public void Print()
        {
            PrintNode(_root);

            Console.WriteLine();
        }

        private void DeleteTheChild(Node root, int data)
        {
            Node parent = root;
            bool isLeft;

            while (true)
            {
                if (parent.Left != null && parent.Left.Data == data)
                {
                    isLeft = true;
                    break;
                }
                else if (parent.Right != null && parent.Right.Data == data)
                {
                    isLeft = false;
                    break;
                }
                else if (data > parent.Data)
                {
                    parent = parent.Right;
                }
                else
                {
                    parent = parent.Left;
                }
            }

            if (parent == null)
            {
                return;
            }

            Node removalNode = isLeft ? parent.Left : parent.Right;

            if (removalNode.Left == null && removalNode.Right == null)
            {
                if (isLeft)
                {
                    parent.Left = null;
                }
                else
                {
                    parent.Right = null;
                }
            }
        }

        public void Delete(int data)
        {
            Node iter = _root;

            while (true)
            {
                if (iter.Data == data)
                {
                    break;
                }
                else if (data > iter.Data)
                {
                    iter = iter.Right;
                }
                else
                {
                    iter = iter.Left;
                }
            }

            Node iter2 = iter.Right;

            while (true)
            {
                if (iter2 == null)
                {
                    break;
                }

                if (iter2.Left != null)
                {
                    iter2 = iter2.Left;
                }
                else if (iter2.Right != null)
                {
                    iter2 = iter2.Right;
                }
                else if (iter2.Left == null && iter2.Right == null)
                {
                    break;
                }
            }

            int temp = iter.Data;

            if (iter2 != null)
            {
                iter.Data = iter2.Data;
                iter2.Data = temp;

                this.DeleteTheChild(iter.Right, data);
            }
            else
            {
                this.DeleteTheChild(_root, data);
            }
        }

        private void PrintNode(Node node)
        {
            if (node == null)
                return;

            PrintNode(node.Left);
            PrintNode(node.Right);

            Console.Write(node.Data + " ");
        }


        private Node DeleteRec(Node node, int data)
        {
            if(node == null)
            {
                return node;
            }

            if (data < node.Data)
            {
                node.Left = this.DeleteRec(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = this.DeleteRec(node.Right, data);
            }
            else
            {
                if(node.Left == null)
                {
                    return node.Right;
                }
                else if(node.Right == null)
                {
                    return node.Left;
                }

                node.Data = Min(node.Right);

                node.Right = this.DeleteRec(node.Right, data);
            }

            return node;
        }

        private int Min(Node node)
        {
            int min = node.Data;

            while(node.Left != null)
            {
                min = node.Left.Data;
                node = node.Left;
            }

            return min;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            tree.Add(50);
            tree.Add(30);
            tree.Add(20);
            tree.Add(10);
            tree.Add(40);
            tree.Add(35);
            tree.Add(45);
            tree.Add(70);
            tree.Add(60);
            tree.Add(55);
            tree.Add(65);
            tree.Add(80);
            tree.Add(75);
            tree.Add(85);


            tree.Print();

            tree.Delete(70);

            tree.Print();

            /*
             *    [50, 30, 20, 10, 40, 35, 45, 70, 60, 55, 65, 80, 75, 85]
             *    
             *                        (50)
             *                  /              \
             *               (30)                (70)
             *              /    \              /       \
             *            (20)  (40)          (60)       (80)
             *            /      /   \         /  \       /   \
             *          (10)   (35)  (45)   (55)  (65)   (75)  (85)
             *                                           
             */

            //#1
            //Revert the linked list
            //(1) -> (2) -> (3) -> (4) -> (5)
            //(5) -> (4) -> (3) -> (2) -> (1)
        }
    }
}
