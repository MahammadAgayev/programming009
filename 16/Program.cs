using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sorting
            //searching

            int maxSize = 500_000_000;
            int[] arr = new int[maxSize];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }

            Console.WriteLine("array is filled up");
            //              0    10     2   3    4    5    6    7
            //                                  i

            //10 20 30 40 50 60 70 80 90 100
            // 0  1  2  3  4  5  6  7  8  9
            // 10 20 30 40 50    60 70 80 90 100
            //
            //10 20 30    40 50   60 70 80   90 100

            //binary search square(n)

            int searchElement = int.Parse(Console.ReadLine());

            Stopwatch sp = Stopwatch.StartNew();
            int indexLinear = LinearIndexOf(arr, searchElement);
            Console.WriteLine($"Linear search finished with result {indexLinear} within {sp.Elapsed.Milliseconds} ms.");

            sp.Restart();
            int indexBinary = BinaryIndexOfRecurse(arr, searchElement);
            Console.WriteLine($"Binary search finished with result {indexBinary} within {sp.Elapsed.Milliseconds} ms.");

            Console.WriteLine("press <ENTER> to stop app");
            Console.ReadKey();
        }

        static int LinearIndexOf(int[] arr, int searchElement)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchElement)
                {
                    return i;
                }

            }

            return -1;
        }

        static int BinaryIndexOf(int[] arr, int searchElement)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int mid = start + end;

                if (mid < 2 || mid % 2 == 0)
                {
                    mid /= 2;
                }
                else
                {
                    mid = mid / 2 + 1;
                }

                if (searchElement == arr[mid])
                {
                    return mid;
                }
                else if (searchElement > arr[mid])
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }
            }

            return -1;
        }

        static int BinaryIndexOfRecurse(int[] arr, int searchElement)
        {
            return BinarySearch(arr, searchElement, 0, arr.Length - 1);
        }

        static int BinarySearch(int[] arr, int searchElement, int start, int end)
        {
            if (start >= end)
                return -1;

            int mid = start + end;

            if (mid < 2 || mid % 2 == 0)
            {
                mid /= 2;
            }
            else
            {
                mid = mid / 2 + 1;
            }

            if (arr[mid] == searchElement)
            {
                return mid;
            }
            else if (arr[mid] > searchElement)
            {
                return BinarySearch(arr, searchElement, start, mid);
            }
            else
            {
                return BinarySearch(arr, searchElement, mid, end);
            }
        }
    }
}
