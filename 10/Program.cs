using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("n: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Input arr[{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Array in reverse order:");
            //for (int i = arr.Length - 1; i >= 0 ; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.Write("n: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write("Input arr[{0}]: ", i);
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine(sum);

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 1, 2, 3 };

            /*
             * { 1, 2, 3 | }; a1
             * { 1, 2, |3 }; a2
             * 
             * result: { 1, 1, 2, 2, 3, 3 }
             */

            /*
             *   { 1, 5, 8 }
             *   { 2, 3, 10 }
             *   
             *   { 1, 2, 3, 5, 8, 10 }
             */

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 1, 2, 3 };

            //int[] arrResult = new int[arr1.Length + arr2.Length];
            //int arr1Index = 0;
            //int arr2Index = 0;
            //int arrResultIndex = 0;

            //while (arr1Index != arr1.Length
            //    || arr2Index != arr2.Length)
            //{
            //    if (arr1Index == arr1.Length)
            //    {
            //        arrResult[arrResultIndex] = arr2[arr2Index];

            //        arr2Index++;
            //        arrResultIndex++;
            //    }
            //    else if (arr2Index == arr2.Length)
            //    {
            //        arrResult[arrResultIndex] = arr1[arr1Index];

            //        arr1Index++;
            //        arrResultIndex++;
            //    }
            //    else if (arr1[arr1Index] <= arr2[arr2Index])
            //    {
            //        arrResult[arrResultIndex] = arr1[arr1Index];

            //        arr1Index++;
            //        arrResultIndex++;
            //    }
            //    else
            //    {
            //        arrResult[arrResultIndex] = arr2[arr2Index];

            //        arr2Index++;
            //        arrResultIndex++;
            //    }
            //}

            //for (int i = 0; i < arrResult.Length; i++)
            //{
            //    Console.WriteLine(arrResult[i]);
            //}


            //5
            //int[] arr = { 1, 2, 4, 4, 5, 9, 7, 8, 13 };

            //int even = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        even++;
            //    }
            //}

            //int[] evens = new int[even];
            //int[] odds = new int[arr.Length - even];
            //int evenIndex = 0;
            //int oddIndex = 0;

            ////int[] arr = { 1, 2, 4, 4, 5, 9, 7, 8 };
            ////two pointer technique

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        evens[evenIndex] = arr[i];
            //        evenIndex++;
            //    }
            //    else
            //    {
            //        odds[oddIndex] = arr[i];
            //        oddIndex++;
            //    }
            //}

            //Console.WriteLine("evens");
            //for (int i = 0; i < evens.Length; i++)
            //{
            //    Console.WriteLine(evens[i]);
            //}

            //Console.WriteLine("odds");
            //for (int i = 0; i < odds.Length; i++)
            //{
            //    Console.WriteLine(odds[i]);
            //}

            //4
            // { 2, 5, 3, 1, 10, 4}

            //int[] arr = { 2, 5, 3, 1, 10, 4 };
            //int max = arr[0];
            //int min = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }

            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}

            //Console.WriteLine(max);
            //Console.WriteLine(min);

            //int[] arr = { 2, 5, 3, 1, 10, 4 };
            //int min = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}

            //int min2 = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == min)
            //        continue;

            //    if (arr[i] < min2)
            //    {
            //        min2 = arr[i];
            //    }
            //}

            //Console.WriteLine(min2);

            //int[] arr = { 2, 5, 3, 1, 10, 4 };
            //int min = arr[0];
            //int min2 = arr[1];

            //if(min > min2)
            //{
            //    int temp = min;
            //    min = min2;
            //    min2 = min;
            //}
            ////3-cu deyisen istifade etmeden verilen int deyisenlerin yerlerini deyisin.

            //for (int i = 2; i < arr.Length; i++)
            //{
            //    if (arr[i] < min)
            //    {
            //        min2 = min;
            //        min = arr[i];
            //    }
            //    else if (arr[i] < min2)
            //    {
            //        min2 = arr[i];
            //    }
            //}

            //Console.WriteLine(min);
            //Console.WriteLine(min2);

            //verilmis massivde maximum ve 2-ci maximum elementi tapan proqram yazin.

            //int[] arr = { 2, 5, 3, 1, 10, 4 };
            //int[] reversedArr = new int[arr.Length];
            //int indexReverse = 0;

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    //reversedArr[indexReverse] = arr[i];
            //    //indexReverse++;

            //    reversedArr[arr.Length - 1 - i] = arr[i];
            //}

            //for (int i = 0; i < reversedArr.Length; i++)
            //{
            //    Console.WriteLine(reversedArr[i]);
            //}

            /*
             * { 2, 5, 3, 1, 10, 4 }
             * { 4, 5, 3, 1, 10, 2 }
             * { 4, 10, 3, 1, 5, 2 }
             * { 4, 10, 1, 3, 5, 2 }
            */

            //verilmis massivde tekrarlanmalarin sayini gosteren kod yazin.

            int[] arr = { 1, 2, 2, 3, 5, 5, 5, 10, 10, 10, 15 };
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            /*
             * 1: 1
             * 2: 2
             * 3: 1,
             * 5: 3, 
             * 10: 3,
             * 15: 1
             */

            //int[] counts = new int[max + 1];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int element = arr[i];

            //    counts[element]++;
            //}

            //for (int i = 0; i < counts.Length; i++)
            //{
            //    if (counts[i] > 0)
            //    {
            //        Console.WriteLine($"{i}: {counts[i]}");
            //    }
            //}

            /*
             *  counts[1]++
             *  counts[2]++
             * 
             *  counts[15]
             */
        }
    }
}
