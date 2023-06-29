using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //alghorithms
            //pesuedecode
            /*
             *  for i from 1 to 10 {
             *     show i
             *  }
             * 
             */

            //system design

            //sorting
            //search
            //tree

            //{ 2, 1, 3 }
            //{ 1, 2, 3 }

            //2 1 3
            //1 2 3
            //2 1 3
            //2 3 1

            //second try
            //2 1 3
            //1 2 3
            //1 2 3
            //1 2 3

            //selection sort
            //{ 4, 2, 23, 12, 3, 12, 1, 22, 1, 21, 2, 5, 4, 10, 32, 32 }
            //


            //int[] arr = { 4, 2, 23, 12, 3, 12, 1, 22, 1, 21, 2, 5, 4, 10, 32, 32 };

            //SelectionSort(arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Console.WriteLine();

            //Stopwatch sw = Stopwatch.StartNew();

            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //}

            //Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(int.MaxValue);

            //O(n) O(n*logn)

            //O(n)

            //int[] arr = { 2, 1, 3 };

            //CountingSort(arr);

            int[] arr = { 4, 1, 3, 7, 5, 2 };

            //BubbleSort(arr);
            InsertionSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            //premature optimization
            //insertion sort
        }

        //n^2 O(n^2)
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void CountingSort(int[] arr)
        {
            int max = Max(arr);

            int[] counts = new int[max + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                int element = arr[i];

                counts[element]++;
            }

            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int Max(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static void BubbleSort(int[] arr)
        {
            int totalLoops = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isReplaceHappened = false;

                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;

                        isReplaceHappened = true;
                    }

                    totalLoops++;
                }

                if (isReplaceHappened == false)
                {
                    break;
                }
            }

            Console.WriteLine("Total loops: " + totalLoops);
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for(int j = i; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}
