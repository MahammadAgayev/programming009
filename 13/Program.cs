using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 4, 5, 3, 10, 4 };

            //SelectionSort(arr);
            //BubbleSort(arr);
            //CountingSort(arr);
            //InsertionSort(arr);

            //Print(arr);

            //f(x) = 0; until 10
            //f(x) = f(x) + 1 = 0 + 1 = 1
            //f(x) = f(x) + 1 = 1 + 1 = 2

            //f(1) = 1;
            //f(x) = x * f(x - 1)

            //f(5) = 5 * f(4) = 5 * 24 = 120
            //f(4) = 4 * f(3) = 4 * 6  = 24
            //f(3) = 3 * f(2) =  3 * 2 = 6
            //f(2) = 2 * f(1) = 2 * 1 = 2

            //int result = Factorial(5);
            //Console.WriteLine(result);

            //int result2 = 1;
            //for (int i = 1; i <=5 ; i++)
            //{
            //    result2 *= i;
            //}

            //Console.WriteLine(result2);

            //int sum = Sum(100);
            //Console.WriteLine(sum);
        }

        static int Factorial(int x)
        {
            if (x == 1)
                return 1;

            return x * Factorial(x - 1);
        }

        static int Sum(int x)
        {
            if (x == 0)
                return 0;

            return x + Sum(x - 1);
        }

        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = Min(arr, i);

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;

                Print(arr);
            }
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool isSorted = true;

                Console.Write($"{i}# ");
                Print(arr);

                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;

                        isSorted = false;
                    }
                }

                if (isSorted)
                {
                    break;
                }
            }
        }

        static int Min(int[] arr, int start)
        {
            int minIndex = start;
            for (int i = start + 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }

            return minIndex;
        }

        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
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
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static int Max(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write($"{i}_{j}# ");
                    Print(arr);

                    if (arr[j] < arr[j - 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                }
            }
        }
    }
}
