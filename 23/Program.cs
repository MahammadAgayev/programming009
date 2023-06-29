using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23
{
    class List
    {
        private int[] _array;
        private int _count;

        public List() : this(1)
        {

        }

        public List(int capacity)
        {
            _array = new int[capacity];
        }


        public int Count => _count;
        public int Capacity => _array.Length;

        public void Add(int value)
        {
            if (_count == _array.Length)
            {
                int[] newArr = new int[_array.Length * 2];

                for (int i = 0; i < _array.Length; i++)
                {
                    newArr[i] = _array[i];
                }

                _array = newArr;
            }

            _array[_count] = value;

            _count++;
        }

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_array[i] + " ");
            }

            Console.WriteLine();
        }

        public void InsertV1(int index, int value)
        {
            int[] newArr = new int[_array.Length];

            int iterNewArr = 0;
            int iterOldArr = 0;

            for (; iterOldArr < _count;)
            {
                if (iterNewArr == index)
                {
                    newArr[iterNewArr] = value;
                    iterNewArr++;
                    continue;
                }

                newArr[iterNewArr] = _array[iterOldArr];

                iterNewArr++;
                iterOldArr++;
            }

            _array = newArr;
            _count++;
        }

        public void InsertV2(int index, int value)
        {
            //1 2 4 5 6
            //1 2 4 5 6 6
            //1 2 4 5 5 6
            //1 2 4 4 5 6
            //1 2 2 4 5 6
            _count++;

            for (int i = _count - 1; i >= index; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[index] = value;
        }

        public void RemoveV3(int index)
        {
            _array[index] = _array[_count - 1];

            _count--;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //int a1 = 4;
            //int a2 = 4;

            //Console.WriteLine(a1++);
            //Console.WriteLine(++a2);

            //Console.WriteLine(a1);
            //Console.WriteLine(a2);

            //int a = 4;

            //Console.WriteLine(a++);
            //Console.WriteLine(++a);

            //int a = 4;

            //int b = a++;
            //int c = ++a;

            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //int a = 1;
            //int b = ++a + a++;

            //Console.WriteLine(b);

            //List ints = new List();

            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //ints.Add(4);
            //ints.Add(5);

            //ints.Print();

            //Console.WriteLine(ints.Capacity);
            //Console.WriteLine(ints.Count);

            //List ints = new List();
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(4);
            //ints.Add(5);
            //ints.Add(6);

            //ints.InsertV1(2, 3);
            //ints.InsertV2(2, 3);

            //ints.Print();
            //ints.RemoveV3(3);

            //ints.Print();

            //queue/stack
            //Queue -> FIFO -> first in first out
            //Enqueue
            //Dequeue

            Queue<int> ints = new Queue<int>();

            ints.Enqueue(1);
            ints.Enqueue(2);
            ints.Enqueue(3);
            ints.Enqueue(4);

            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine(ints.Dequeue());

            //Console.WriteLine(ints.Peek());
            //Console.WriteLine(ints.Peek());
            //Console.WriteLine(ints.Dequeue());
            //Console.WriteLine(ints.Dequeue());

            //Stack -> LIFO -> last in first out

            Stack<int> intsStack = new Stack<int>();

            intsStack.Push(1);
            intsStack.Push(2);
            intsStack.Push(3);
            intsStack.Push(4);

            Console.WriteLine(intsStack.Pop());
            Console.WriteLine(intsStack.Peek());
            Console.WriteLine(intsStack.Pop());
        }
    }
}