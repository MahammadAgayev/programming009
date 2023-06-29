using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //data types
            //strings
            //arrays
            //method

            //int a = int.Parse(Console.ReadLine());
            //a *= 2;

            //int b = int.Parse(Console.ReadLine());
            //b *= 2;

            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");

            //SayHello();
            //SayHello();
            //SayHello();

            //for (int i = 0; i < 3; i++)
            //{
            //    SayHello();
            //}

            //PrintMessageThreeTimes();

            //int x = 10;
            //Square(x);

            //Square(10);

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //Sum(a, b);

            //Mod(-100);
            //Mod(150);

            //int moduled = Mod(-200);
            //Console.WriteLine(moduled);

            //string message = GetMessage("Mahammad");

            //Console.WriteLine(message);

            //double val = Mod(-199);
            //Console.WriteLine(val);

            //int[] arr = { 4, 1, 122, 12, 4 };

            //int max = MaxInArray(arr);

            //Console.WriteLine(max);


            //int a = Sum(1, 2, 3);
            //int b = Sum(1, 2);
            //double c = Sum(1.2, 1.7);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);

            //int a = Sum(1, 2, 3);
            //int b = Sum(1, 2);
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int[] arr = { 4, 34, 1 };

            //int max = Max(arr);
            //Console.WriteLine(max);

            //int max = Max(4, 3, 1);
            //Console.WriteLine(max);

            //verilmis massivde en cox tekrarlanan elementi tapin

            //int m = FindMostRepeatedNumber(1, 1, 2, 2, 4, 4, 4, 4);
            //Console.WriteLine(m);

            int[] arr1 = { 1, 2, 5, 10 };
            int[] arr2 = { 3, 1, 2, 6, 9 };

            int[] arr1Reversed = Reverse(arr1);
            int[] arr2Reversed = Reverse(arr2);

            //for (int i = 0; i < arr1Reversed.Length; i++)
            //{
            //    Console.Write(arr1Reversed[i] + " ");
            //}

            //Console.WriteLine();

            //for (int i = 0; i < arr2Reversed.Length; i++)
            //{
            //    Console.Write(arr2Reversed[i] + " ");
            //}

            //Console.WriteLine();

            Console.Write("Arr1: ");
            PrintArray(arr1);
            Console.Write("Reversed Arr1: ");
            PrintArray(arr1Reversed);

            Console.Write("Arr2: ");
            PrintArray(arr2);
            Console.Write("Reversed Arr2: ");
            PrintArray(arr2Reversed);

            //PrintArray(arr1Reversed);
            //PrintArray(arr2Reversed);
        }

        //static datetype(void) MethodName
        //static void SayHello()
        //{
        //    Console.WriteLine("Hello World");
        //}

        //static void PrintMessageThreeTimes()
        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (i == 1)
        //        {
        //            return;
        //        }

        //        Console.WriteLine("Hello, This is message");
        //    }
        //}

        //static void Square(int x)
        //{
        //    Console.WriteLine(x * x);
        //}

        //static void Sum(int x, int y)
        //{
        //    Console.WriteLine("Sum:" + (x + y));
        //}

        //static void Mod(int x)
        //{
        //    int result = x;

        //    if (x < 0)
        //        result *= -1;

        //    Console.WriteLine(result);
        //}

        //static int Mod(int x)
        //{
        //    int result = x;

        //    if (x < 0)
        //        result *= -1;

        //    return result;
        //}

        //static double Mod(double x)
        //{
        //    return 1;

        //    if (x < 0)
        //    {
        //        return -1 * x;
        //    }

        //    return x;
        //}

        //static string GetMessage(string nameOfCustomer)
        //{
        //    string message = $"Hello, {nameOfCustomer}";
        //    return message;
        //    //return $"Hello, {nameOfCustomer}";
        //}

        //static int MaxInArray(int[] arr)
        //{
        //    int max = arr[0];

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }

        //    return max;
        //}

        //method overloading.

        //static int Sum(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //static int Sum(int x, int y)
        //{
        //    return x + y;
        //}

        //static double Sum(double x, double y)
        //{
        //    return x + y;
        //}

        //method overloading technique
        //static int Sum(int x, int y, int z)
        //{
        //    return x + y + z;
        //}

        //static int Sum(int x, int y)
        //{
        //    return Sum(x, y, 0);
        //}

        //optional parameters
        //static int Sum(int x, int y, int z = 0)
        //{
        //    return x + y + z;
        //}

        //params
        static int Max(params int[] arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        static int IndexOfMax(params int[] arr)
        {
            int index = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[index])
                {
                    index = i;
                }
            }

            return index;
        }

        static int FindMostRepeatedNumber(params int[] arr)
        {
            int maxInArray = Max(arr);

            int[] counts = new int[maxInArray + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                counts[num]++;
            }

            int maxRepetition = IndexOfMax(counts);

            return maxRepetition;
        }

        static int[] Reverse(int[] arr)
        {
            int[] reversedArr = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reversedArr[i] = arr[arr.Length - i - 1]; 
            }

            return reversedArr;
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}