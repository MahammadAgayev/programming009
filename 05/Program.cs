﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int.parse, convert.toint32

            //long l = 2;
            //int a = int.Parse("2");
            //int b = int.Parse(l);

            //int a1 = Convert.ToInt32("2");
            //int b1 = Convert.ToInt32(l);

            //int a = int.Parse(Console.ReadLine());

            //if (a % 40 == 0 && a % 9 == 0 && a % 7 == 0)
            //{
            //    Console.WriteLine("It's divided by 40,9,7");
            //}
            //else if (a % 40 == 0 && a % 9 == 0)
            //{
            //    Console.WriteLine("It's divided by 40,9");
            //}
            //else if (a % 40 == 0)
            //{
            //    Console.WriteLine("It's divided by 40");
            //}

            //if(a % 40 == 0)
            //{
            //    if(a % 9 == 0)
            //    {
            //        if(a % 7 == 0)
            //        {
            //            Console.WriteLine("It's divided by 40,9,7");
            //        }
            //        else
            //        {
            //            Console.WriteLine("It's divided by 40,9");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("It's divided by 40");
            //    }
            //}

            //char a = char.Parse(Console.ReadLine());

            //int aAfterInt = (int)a + 1;
            //int aBeforeInt = (int)a - 1;

            //if (aAfterInt > (int)'Z' && aAfterInt < 'a')
            //{
            //    aAfterInt = 'A';
            //}
            //else if (aAfterInt > 'z')
            //{
            //    aAfterInt = 'a';
            //}

            //if (aBeforeInt < 'A')
            //{
            //    aBeforeInt = 'Z';
            //}
            //else if (aBeforeInt < 'a' && aBeforeInt > 'Z')
            //{
            //    aBeforeInt = 'z';
            //}

            //Console.WriteLine((char)aBeforeInt);
            //Console.WriteLine((char)aAfterInt);

            //switch case

            //if result of some operation equals to x do this

            //int a = int.Parse(Console.ReadLine());

            //1 -> one
            //2 -> two
            //......

            //if (a == 1)
            //{
            //    Console.WriteLine("one");
            //}
            //else if (a == 2)
            //{
            //    Console.WriteLine("two");
            //}
            //else if (a == 3)
            //{
            //    Console.WriteLine("three");
            //}
            //else
            //{
            //    Console.WriteLine("unkown number");
            //}

            //switch (a)
            //{
            //    case 1: //a == 1
            //        Console.WriteLine("one");
            //        break;
            //    case 2:
            //        Console.WriteLine("two");
            //        break;
            //    case 3:
            //        Console.WriteLine("three");
            //        break;
            //    case 4:
            //        Console.WriteLine("four");
            //        break;

            //    default://susmaya görə
            //        Console.WriteLine("Unkown number");
            //        break;
            //}

            //int a = int.Parse(Console.ReadLine());

            //switch (a)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;

            //    default:
            //        Console.WriteLine("Matching day not found");
            //        break;
            //}

            //char a = char.Parse(Console.ReadLine());

            //switch(a)
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //        Console.WriteLine("saitdir");
            //        break;
            //    case 'm':
            //        Console.WriteLine("samitdir");
            //        break;
            //}

            //loops
            //int a = 1;

            //Console.WriteLine(a++);
            //Console.WriteLine(a++);
            //Console.WriteLine(a++);
            //Console.WriteLine(a++);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //int a = 1;
            //if a < 10 
            //do cw(a); a++;
            //go to if and repeat

            //for
            //i comes from iterator
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //ctrl + enter
            //Console.WriteLine(1423);

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (byte i = 1; i > 0; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //a^2

            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(i * i);
            //}

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    double sqrt = Math.Sqrt(i);

            //    Console.WriteLine(sqrt);
            //}


            //for (int i = 0; i < n; i++)
            //{
            //    double pow = Math.Pow(i, 4);

            //    Console.WriteLine(pow);
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    double pow = Math. (i, 4);

            //    Console.WriteLine(pow);
            //}

            //Console.WriteLine(Math.PI);

            //double result = Math.Floor(2.62314234);
            //Console.WriteLine(result);

            //double result2 = Math.Round(2.67314234, 1);
            //Console.WriteLine(result2);

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(Math.Log(i, 2));
            //}

            //int n = 10;
            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    //sum = sum + i;
            //    sum += i;
            //}

            //Console.WriteLine(sum);

            /*
             * 
             * f(10) = 10 + f(9)
             */

            //int n = 10;
            //int result = 1;

            //for (int i = 1; i < n; i++)
            //{
            //    result *= i;
            //}

            //Console.WriteLine(result);

            //fibonacci
            //1, 1, 2, 3, 5, 8, 13, 21, 34
            //1-den n-e qeder ededlerin ekrana cixarin

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine(i);
            //}

            //for (int i = 0; i < 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
