using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class List
    {
        private int[] _array;

        private int _count;

        public List()
        {
            _array = new int[1];
        }

        public void Add(int value)
        {
            if (_count >= _array.Length)
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

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public int Capacity
        {
            get
            {
                return _array.Length;
            }
        }

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.Write(_array[i] + " ");
            }

            Console.WriteLine();
        }

        public int Find(int value)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_array[i] == value)
                    return value;
            }

            return -1;
        }

        public int FindByIndex(int index)
        {
            return _array[index];
        }

        public int Middle()
        {
            return _array[_count / 2];
        }

        public void InsertV1(int value, int index)
        {
            int[] newArr = new int[_array.Length];
            _count++;

            bool insertIndexFound = false;
            for (int i = 0; i < _count; i++)
            {
                if (index == i)
                {
                    newArr[i] = value;
                    insertIndexFound = true;
                }
                else if (insertIndexFound)
                {
                    newArr[i] = _array[i - 1];
                }
                else
                {
                    newArr[i] = _array[i];
                }
            }

            _array = newArr;
        }

        public void InsertV2(int value, int index)
        {
            for (int i = _count - 1; i > index; i--)
            {
                _array[i + 1] = _array[i];
            }

            _array[index] = value;
            _count++;
        }

        public void RemoveV1(int element)
        {
            int[] newArr = new int[_array.Length];
            bool isRemoveElementFound = false;

            for (int i = 0; i < _count; i++)
            {
                if (element == _array[i])
                {
                    isRemoveElementFound = true;
                }

                if (isRemoveElementFound)
                {
                    newArr[i] = _array[i + 1];
                }
                else
                {
                    newArr[i] = _array[i];
                }
            }

            _array = newArr;
            _count--;
        }

        public void RemoveV2(int element)
        {
            bool isRemoveElementFound = false;

            for (int i = 0; i < _count; i++)
            {
                if (_array[i] == element)
                {
                    isRemoveElementFound = true;
                }

                if(isRemoveElementFound)
                {
                    _array[i] = _array[i + 1];
                }
            }

            _count--;
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
            //int[] arr = new int[2];
            //arr[0] = 1;
            //arr[1] = 2;

            //int[] newArr = new int[4];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    newArr[i] = arr[i];
            //}

            //arr = newArr;

            //arr[2] = 3;
            //arr[3] = 4;

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            List ints = new List();

            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);

            //ints.InsertV1(12, 1);
            //ints.InsertV2(12, 1);
            //ints.InsertV2(13, 3);

            //ints.RemoveV1(3);
            //ints.RemoveV2(3);
            ints.RemoveV3(2);

            //Console.WriteLine("count: " + ints.Count);
            //Console.WriteLine("capacity: " + ints.Capacity);

            ints.Print();

            //Console.WriteLine("Search: " + ints.Find(4));
            //Console.WriteLine("Search by index: " + ints.FindByIndex(2));
            //Console.WriteLine("Middle: " + ints.Middle());

            //
            /*
             *     0         1         2        3        4
             *  +------+  +------+  +------+ +------+ +------+
             *  |      |  |      |  |      | |      | |      |
             *  |  1   |  |  2   |  |  3   | |   4  | |  5   |
             *  |      |  |      |  |      | |      | |      |
             *  +------+  +------+  +------+ +------+ +------+
             * 
             *      +------+
             *      |      |
             *      |  12  |
             *      |      |
             *      +------+
             *      
             *        0         1         2        3        4         5  
             *     +------+  +------+  +------+ +------+ +------+  +------+
             *     |      |  |      |  |      | |      | |      |  |      |
             *     |  1   |  |  12  |  |  2   | |  3   | |  4   |  |  5   |
             *     |      |  |      |  |      | |      | |      |  |      |
             *     +------+  +------+  +------+ +------+ +------+  +------+
             *     
             *     array i - 1  -> newArray i
             *         0         1         2        3        4 
             *      +------+  +------+  +------+ +------+ +------+ 
             *      |      |  |      |  |      | |      | |      | 
             *      |  1   |  |  2   |  |  5   | |   4  | |  5   | 
             *      |      |  |      |  |      | |      | |      | 
             *      +------+  +------+  +------+ +------+ +------+ 
             *      
             *         0         1        2        3 
             *      +------+  +------+ +------+ +------+ 
             *      |      |  |      | |      | |      | 
             *      |  1   |  |  2   | |  4   | |  5   | 
             *      |      |  |      | |      | |      | 
             *      +------+  +------+ +------+ +------+ 
             */

            /*
             *  AAA
             *  BBB
             *  CCC
             *  DDD
             * -CCC
             */
        }
    }
}
