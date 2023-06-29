using System;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            //quicksort
            //n^2, n * logn

            //int[] arr = { 2, 1, 4, 5, 3 };

            int[] arr = { 9, 7, 5, 11, 12, 2, 14, 3, 10, 6 };

            //QuickSort(arr);
            //PrintArr(arr);

            QuickSort(arr);

            PrintArr(arr);
        }

        static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        static void QuickSort(int[] arr, int start, int end)
        {
            if (end <= start)
                return;

            int pivotIndex = Partition(arr, start, end);
            PrintArr(arr);

            QuickSort(arr, start, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, end);
        }

        static int Partition(int[] arr, int start, int end)
        {
            int iBefore = start - 1;
            int pivot = arr[end];

            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    iBefore++;

                    int temp1 = arr[i];
                    arr[i] = arr[iBefore];
                    arr[iBefore] = temp1;
                }
            }

            iBefore++;
            int temp = arr[iBefore];
            arr[iBefore] = pivot;
            arr[end] = temp;

            return iBefore;
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