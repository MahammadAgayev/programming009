using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ASCII 

            //string line = Console.ReadLine();
            //int counter = 0;

            //for (int i = 0; i < line.Length; i++)
            //{
            //    if ((line[i] >= 'A' && line[i] <= 'Z')
            //       || (line[i] >= 'a' && line[i] <= 'z'))
            //    {
            //        counter++;
            //    }
            //}

            //Console.WriteLine(counter);

            //string line = Console.ReadLine();
            //int counter = 0;

            //for (int i = 0; i < line.Length; i++)
            //{
            //    if (char.IsLetter(line[i]))
            //    {
            //        counter++;
            //    }
            //}

            //Console.WriteLine(counter);

            //Hope this will  help us to find words.
            //string line = "  Hope this will  help us to find words.";//Console.ReadLine();

            //bool previouslyWasSymbol = false;
            //int counter = 0;

            //for (int i = 0; i < line.Length; i++)
            //{
            //    if (char.IsLetter(line[i]))
            //    {
            //        previouslyWasSymbol = true;
            //    }
            //    else if (
            //         //(line[i] == ' ' || line[i] == '.' || line[i] == '?' || line[i] == '!')
            //         line[i] == ' ' && previouslyWasSymbol)
            //    {
            //        counter++;
            //        previouslyWasSymbol = false;
            //    }
            //}

            //Console.WriteLine(counter);

            //string line = "It's a some alghorithm for finding test@gmail.com mail address finding.";

            //int indexOf = line.IndexOf("@");
            //string firstPart = line.Substring(0, indexOf + 1);
            //string secondPart = line.Substring(indexOf + 1, line.Length - indexOf - 1);

            //Console.WriteLine(firstPart);
            //Console.WriteLine(secondPart);

            //int lastIndexOfFirst = firstPart.LastIndexOf(" ");
            //int firstIndexOfSecond = secondPart.IndexOf(" ");

            //string firstGmailPart = firstPart.Substring(lastIndexOfFirst + 1, firstPart.Length - lastIndexOfFirst - 1);
            //string secondGmailPart = secondPart.Substring(0, firstIndexOfSecond);

            //string mail = firstGmailPart + secondGmailPart;

            //Console.WriteLine(mail);

            //massivler(arrays)

            //int[] a = new int[5];
            //a[0] = 1;
            //a[1] = 2;
            //a[2] = 3;
            //a[3] = 4;
            //a[4] = 5;

            //Console.WriteLine(a.Length);

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //string immutable type
            //string s = "Hello";
            //s = "Hello World";

            //int[] a = new int[5];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = int.Parse(Console.ReadLine());
            //}


            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int[] b = new int[5] { 1, 2, 3, 4, 5 };
            //int[] b1 = new int[] { 1, 2, 3, 4, 5 };
            //int[] b2 = { 1, 2, 3, 4, 5 };


            //Console.Write("Array Length: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] a = new int[n];

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write($"Input {i + 1}th element: ");
            //    a[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] *= 2;
            //    Console.WriteLine(a[i]);
            //}

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}

            //Given the length of array, get element from console, double each element and print it to screen.

            //char[] a = { 'H', 'e', 'l', 'l', 'o' };
            //string b = "Hello";

            //string s = a.ToString();
            //char[] s1 = b.ToCharArray();

            //Console.WriteLine(a.Length);
            //Console.WriteLine(b.Length);

            //int a = 0;//123AB
            //int[] a = new int[5] { 1, 2, 3, 4, 5 };

            //Console.WriteLine(a[3]);

            // 1 2 3 4 5

            /*
             *  1 2 3 4 5 
             *  6 7 8 9 10
             *  11 12 23 14 15 
             *  
             * 
             */

            //int[,] a = new int[4, 4]
            //{
            //   { 1,2,3,4 },
            //   { 1,2,3,4 },
            //   { 1,2,3,4 },
            //   { 1,2,3,4 }
            //};

            //Console.WriteLine(a[0,0]);
            //Console.WriteLine(a[0,1]);

            //Console.WriteLine(a[2,2]);

            //for (int i = 0; i < a.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= a.GetUpperBound(1); j++)
            //    {
            //        Console.Write(a[i,j] +  " ");
            //    }
            //    Console.WriteLine();
            //}

            //nxm olculu verilmis massivde 

            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //int[,] arr = new int[n, m];

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"arr[{i},{j}] = ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(arr[i,j]);
            //    }
            //    Console.WriteLine();
            //}

            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());

            //int[,] arr1 = new int[n, m];

            //Console.WriteLine("Array 1");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"arr[{i},{j}] = ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //int[,] arr2 = new int[n, m];

            //Console.WriteLine("Array 2");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write($"arr[{i},{j}] = ");
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //int[,] finalArray = new int[n,m]; 
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        finalArray[i, j] = arr1[i, j] + arr2[i, j];

            //        Console.Write(finalArray[i, j]); ;
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}