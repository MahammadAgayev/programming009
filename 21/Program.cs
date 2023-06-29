using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Runtime.InteropServices;

namespace _21
{
    class Node
    {
        public Node(int data)
        {
            this.Data = data;
        }

        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }
    }

    class LinkedList
    {
        public Node _root;

        public void AddFirst(int a)
        {
            Node n = new Node(a);

            n.Next = _root;
            _root = n;
        }

        public void Insert(int index, int a)
        {
            Node iter = _root;
            int indexCounter = 0;

            while (indexCounter < index)
            {
                iter = iter.Next;
                indexCounter++;
            }

            Node tempNext = iter.Next;
            Node newNode = new Node(a);

            iter.Next = newNode;
            newNode.Next = tempNext;
        }

        public void Add(int a)
        {
            if (_root == null)
            {
                _root = new Node(a);
                return;
            }

            Node iter = _root;

            while (iter.Next != null)
            {
                //i++
                iter = iter.Next;
            }

            iter.Next = new Node(a);
        }

        public void Remove(int element)
        {
            Node iter = _root;

            if (iter.Data == element)
            {
                _root = _root.Next;

                return;
            }

            while (iter.Next != null
                && iter.Next.Data != element)
            {
                iter = iter.Next;
            }

            iter.Next = iter.Next.Next;
        }

        public int Middle()
        {
            Node iter = _root;

            int counter = 0;
            while (iter != null)
            {
                counter++;
                iter = iter.Next;
            }

            iter = _root;
            for (int i = 0; i < counter / 2; i++)
            {
                iter = iter.Next;
            }

            return iter.Data;
        }

        public int MiddleOptimised()
        {
            Node iterS = _root;
            Node iterF = _root;

            while (iterF != null && iterF.Next != null)
            {
                iterS = iterS.Next;
                iterF = iterF.Next.Next;
            }

            return iterS.Data;
        }

        public void Print()
        {
            Node iter = _root;

            while (iter != null)
            {
                Console.WriteLine(iter.Data);
                iter = iter.Next;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //linkedlist

            /*  (6)root     8        10         12       13
             * +-----+   +-----+   +-----+   +-----+   +------+
             * |     |   |     |   |     |   |     |   |      |
             * | 20  |-->| 1   |-->| 2   |-->| 3   |-->| 4    |
             * |N:8  |   |N:10 |   |N:12 |   |N:13 |   |N:null|
             * +-----+   +-----+   +-----+   +-----+   +------+
             *                                  iter        
             */


            /*
             * 
             *              +-----+
             *              | E   |
             *              |     |------
             *              +-----+     |
             *                 ^        |
             *                 |        v
             * +-----+     +-----+     +-----+    +-----+
             * | A   |     |  B  |     | C   |    | D   |
             * |     | --> |     |     |     |--->|     |
             * +-----+     +-----+     +-----+    +-----+
             * 
             *     +------------------------------------------------------+
             *     v                                                      |
             * +-----+     +-----+     +-----+    +-----+     +-----+     |
             * | 1   |     |  2  |     | 3   |    | 4   |     | 5   |     |
             * |     | --> |     | --->|     |--->|     |-->  |     | ----+
             * +-----+     +-----+     +-----+    +-----+     +-----+
             *  iterS        iterS      iterS
             *  iterF                                           iterF
             */

            //object a = new object();
            //int b = 4;
            /*
             *   Stack       Heap
             *   +----+      +-------------------+
             * a | ha |   ha | {}                |
             * b | 4  |      |                   |
             * c |    |      |                   |
             *   +----+      +--------------------+
             */

            //Node a = new Node(1);

            //Node b = new Node(2);

            //a.Next = b;

            //Node c = new Node(3);

            //b.Next = c;

            //Node d = new Node(4);

            //c.Next = d;

            //PrintNodes(c);

            //LinkedList l = new LinkedList();

            //l.Add(1);
            //l.Add(2);
            //l.Add(3);
            //l.Add(4);
            //l.AddFirst(0);

            //l.Insert(2, 100);

            //l.Remove(3);
            //l.Remove(0);

            //l.Print();

            //Console.WriteLine("Middle: " + l.Middle());
            //Console.WriteLine("Middle Optimized: " + l.MiddleOptimised());
            //linkedlistde ortadaki elementi tapin.

            //SortedLinkedList

            LinkedList<int> ints = new LinkedList<int>(); ;

            ints.AddLast(0);
              ints.AddLast(1);
            ints.AddLast(2);
        }

        static void PrintNodes(Node root)
        {
            Node iter = root;

            while (iter != null)
            {
                Console.WriteLine(iter.Data);
                iter = iter.Next;
            }
        }
    }
}
