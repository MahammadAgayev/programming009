using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //merge sort

            //divide & conquer
            int[] arr = { 12, 3, 15, 8, 10, 6, 4, 9, 2, 11, 7, 14, 5, 13, 1 };

            int[] sortedArr = Merge(arr);
            PrintArr(sortedArr);

            //Merge n logn

            //Array.Sort(arr);
        }

        static int[] Merge(int[] arr)
        {
            PrintArr(arr);

            if (arr.Length == 1)
                return arr;

            int mid = arr.Length / 2;

            int[] arrLeft = new int[mid];
            int[] arrRight = new int[arr.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                arrLeft[i] = arr[i];
            }

            int j = 0;
            for (int i = mid; i < arr.Length; i++)
            {
                arrRight[j] = arr[i];

                j++;
            }

            int[] sortedLeft = Merge(arrLeft);
            int[] sortedRight = Merge(arrRight);

            int[] merged = MergeSortedArrays(sortedLeft, sortedRight);
            PrintArr(merged);

            return merged;
        }

        static int[] MergeSortedArrays(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];

            int leftIter = 0;
            int rightIter = 0;
            int resultIter = 0;

            while (resultIter < result.Length)
            {
                if (leftIter == left.Length)
                {
                    result[resultIter] = right[rightIter];
                    resultIter++;
                    rightIter++;
                }
                else if (rightIter == right.Length)
                {
                    result[resultIter] = left[leftIter];
                    resultIter++;
                    leftIter++;
                }
                else if (left[leftIter] < right[rightIter])
                {
                    result[resultIter] = left[leftIter];
                    resultIter++;
                    leftIter++;
                }
                else
                {
                    result[resultIter] = right[rightIter];
                    resultIter++;
                    rightIter++;
                }
            }

            return result;
        }

        static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
