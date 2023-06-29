using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //homework#1
            //int n = int.Parse(Console.ReadLine());
            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    sum += i;
            //}

            //Console.WriteLine(sum);

            //homework#2
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    int cube = i * i * i;
            //    Console.WriteLine($"Number is : {i} and cube of the {i} is :{cube}");
            //}

            //homwork#3
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n * 2; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //int n = int.Parse(Console.ReadLine());
            //int counter = 1;
            //int sum = 0;

            //for (int i = 1; counter <= n; i += 2)
            //{
            //    //Console.WriteLine(i);
            //    sum += i;
            //    counter++;
            //}

            //Console.WriteLine(sum);

            //homework#4

            //int n = int.Parse(Console.ReadLine());
            //int result = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    result *= i;
            //}
            //Console.WriteLine(result);

            //homework#5
            //int n = int.Parse(Console.ReadLine());

            //1
            //11 = 10 + 1
            //111 = 100 + 10 + 1
            //1111 = 1000 + 100 + 10 + 1

            //1 
            //11 = 10 + 1
            //111 = 100 + 11
            //1111 = 1000 + 111

            //1
            //11 = 10^1 + 1
            //111 = 10^2 + 11
            //1111 = 10^3 + 111

            //int prevResult = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int num = (int)Math.Pow(10, i) + prevResult; 

            //    Console.WriteLine(num);

            //    prevResult = num;
            //}

            //homework#6

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i < n / 2 + 1; i++)
            //{
            //    if(n % i == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //Verilmis istenilen ededin sade olub olmadigini bildiren proqram yazin

            //int n = int.Parse(Console.ReadLine());

            //bool isPrime = true;

            //for (int i = 2; i < Math.Sqrt(n) + 1; i++)
            //{
            //    if(n % i == 0)
            //    {
            //        isPrime = false;

            //        break;
            //    }
            //}

            //if(isPrime)
            //{
            //    Console.WriteLine("Sadedir");
            //}
            //else
            //{
            //    Console.WriteLine("Sade deyil");
            //}

            /*   * 0 1 2 3 4 5
             *   0 *         *
             *   1 *  *   *  *
             *   2 *    *    *
             *   3 *         *
             *   4 *         *
             *   5 *         *
             */

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if(j == 0 || j == n - 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else if(i == j && i < n / 2)
            //        {
            //            Console.Write("*");
            //        }
            //        else if(i + j == n - 1 && i < n / 2)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //homework
            //vurma cedvelin ekrana cixarin

            //
            /*
             *  1 2 3 4 
             *  1 2 3 4
             *  1 2 3 4
             *  1 2 3 4
             */
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            /*
             * 1
             * 1 2  
             * 1 2 3
             * 1 2 3 4
             */

            /*     1 2 3 4
             *   1 1   
             *   2 1 2  
             *   3 1 2 3 
             *   4 1 2 3 4
             */
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (i >= j)
            //        {
            //            Console.Write(j + " ");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            /*
             * 
             * 1 2 3 4 5
             *   2 3 4 5
             *     3 4 5
             *       4 5 
             *         5
             */

            /*    1 2 3 4 5
             *   1    *
             *   2  * * *
             *   3* * * * *
             *   4 
             */

            //int n = int.Parse(Console.ReadLine());
            //int k = 1;

            //for (int i = 0; i < n - 3; i++)
            //{
            //    for (int j = 0; j < n * 2; j++)
            //    {
            //        int halfOfK = k  / 2;
            //        int center = n / 2 + 1;

            //        // j == 2
            //        if(j == n/2 + 1)
            //        {
            //            Console.Write("*");
            //        }
            //        else if(j  >= center - halfOfK && j <= center + halfOfK)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //    }
            //    Console.WriteLine();

            //    k += 2;
            //}

        }
    }
}
