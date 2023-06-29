using Microsoft.SqlServer.Server;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace _25
{
    //class Node
    //{
    //    public Node(int data)
    //    {
    //        this.Data = data;
    //    }

    //    public int Data { get; set; }
    //    public Node Next { get; set; }
    //}

    //class Queue
    //{
    //    private Node _root;

    //    //linked listde 5 element var
    //    /*  
    //     *   root
    //     *   +--+   +--+   +--+   +--+   +--+    
    //     *   |  |-> |  |-> |  |-> |  |-> |  | -> 
    //     *   +--+   +--+   +--+   +--+   +--+ 
    //     *   
    //     *   O(n)
    //     */
    //    public void Enqueue(int data)
    //    {
    //        if(_root == null)
    //        {
    //            _root = new Node(data);
    //            return;
    //        }

    //        Node iter = _root;

    //        while(iter.Next != null)
    //        {
    //            iter = iter.Next;
    //        }

    //        iter.Next = new Node(data);
    //    }

    //    public int Dequeue()
    //    {
    //        if(_root == null)
    //        {
    //            Console.WriteLine("Queue is empty");

    //            return -1;
    //        }

    //        int data = _root.Data;

    //        _root = _root.Next;

    //        return data;
    //    }

    //    public int Peek()
    //    {
    //        return _root.Data;
    //    }
    //}

    class Node
    {
        public Node(int data)
        {
            this.Data = data;
        }

        public int Data { get; set; }

        public Node Left { get; set; }
        public Node Right { get; set; }
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

        public void PrintRecursive()
        {
            this.PrintRecursive(_root);
        }

        /*
         *          root -> Print(3)
        *            +--+
        *        --  |3 | ---
        *        |   +--+   |
        *        v          v
        *      Print(2) 
        *       +--+       +--+
        *    -- |2 |    -- |5 | ------------
        *    |  +--+    |  +--+            |
        */

        public void PrintNonRecursive()
        {
            //generic
            Stack<Node> nodes = new Stack<Node>();

            nodes.Push(_root);

            /*
             *            +--+
             *        --  |3 | ---
             *        |   +--+   |
             *        v          v
             *       +--+       +--+
             *    -- |2 |    -- |5 | ------------
             *    |  +--+    |  +--+            |
             *    v          v                  |
             *   +--+      +--+                 v
             *   |1 |      |4 |                +--+
             *   +--+      +--+             +--|10|
             *                              |  +--+
             *                             +--+ 
             *                             |8 | ---
             *                             +--+    |
             *                                     v
             *                                    +--+
             *                                    |9 |
             *                                    +--+
             * 
             *   |    |
             *   |    |
             *   |    |
             *   |    |  
             *   |    | 
             *   +----+ 
             */

            while (nodes.Count > 0)
            {
                Node node = nodes.Pop();

                if(node.Left != null)
                {
                    nodes.Push(node.Left);
                }
                
                if(node.Right != null)
                {
                    nodes.Push(node.Right);
                }

                Console.WriteLine(node.Data);
            }
        }

        //traverse
        private void PrintRecursive(Node node)
        {
            if (node == null)
                return;

            //left traverse
            PrintRecursive(node.Left);
            PrintRecursive(node.Right);

            //rigt traverse
            //Print(node.Right);
            //Print(node.Left);

            Console.WriteLine(node.Data);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack arrayle yazin
            //Stack linkedlistle yazin
            //Queue LinkedList burda yaziriq

            //Queue ints = new Queue();
            //ints.Enqueue(1);
            //ints.Enqueue(2);
            //ints.Enqueue(3);
            //ints.Enqueue(4);
            //ints.Enqueue(5);

            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine(ints.Peek());
            //Console.WriteLine(ints.Peek());

            //Binary Tree

            //Sorted Array
            //Search -> 
            //Linear search O(n) 10 - n
            //Binary search O(logn) 3 -> logn -> 2^3.5 ~ 10

            //Linear Search 100 000 -> 100 000
            //Binary Search 100 000 -> 2^10 * 2^10 = 2^20 -> 20
            //100 000 / 20 = 5000 -> 5000 dəfə daha sürətlidir

            //1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            //5 den kicik elementler 9-dan boyuk ola bilmezler
            //6 7 8 9 10
            //8 den kicik elementler 9-dan boyuk ola bilmezler
            //9 10
            //9

            //1, 2, 3, 5, 6, 9, 12, 15
            //-> 8
            //1, 2, 3, 5, 6, 8, 9, 12, 15
            //Insert to sorted array: Big O -> O(logn)
            //Read: O(logn), Write O(logn)

            //Binary Tree - 2-lik agac
            //LSM tree -> log structured merge tree(cox cox cox optinal)

            /*
             *            +--+
             *        --  |3 | ---
             *        |   +--+   |
             *        v          v
             *       +--+       +--+
             *    -- |2 |    -- |5 | ------------
             *    |  +--+    |  +--+            |
             *    v          v                  |
             *   +--+      +--+                 v
             *   |1 |      |4 |                +--+
             *   +--+      +--+             +--|10|
             *                              |  +--+
             *                             +--+ 
             *                             |8 | ---
             *                             +--+    |
             *                                     v
             *                                    +--+
             *                                    |9 |
             *                                    +--+
             */

            BinaryTree tree = new BinaryTree();

            tree.Add(3);
            tree.Add(2);
            tree.Add(1);
            tree.Add(5);
            tree.Add(4);
            tree.Add(10);
            tree.Add(8);
            tree.Add(9);

            //tree.PrintRecursive();

            tree.PrintNonRecursive();
        }
    }
}
