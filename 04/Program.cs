﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //?: ternary operator

            //int sum = 3 + 5;

            //int a = 3;
            //int b = 5;

            //int sum = a + b;

            //bool bl = false;

            //int a = 3;
            //int b = 5;
            ////       
            //int result = bl ? a : b;

            //Console.WriteLine(result);

            //int a = 5;
            //int b = 6;
            //bool bl = a > b;

            //string text1 = "a is bigger than b";
            //string text2 = "a is smaller than b";

            //string resultText = bl ? text1 : text2;
            //Console.WriteLine(resultText);

            //option 1
            //int a = int.Parse(Console.ReadLine());

            //option 2
            //int a = Convert.ToInt32(Console.ReadLine());

            ////investigate differnce between option 1 and option 2

            //int b = a % 10;
            //Console.WriteLine(b);

            //homework#2
            //int a = int.Parse(Console.ReadLine());

            //bool b = a % 6 == 0;

            //bool b1 = a % 2 == 0;
            //bool b2 = a % 3 == 0;

            //bool result = b1 && b2;

            //Console.WriteLine(result);

            //homework#3
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //int c = int.Parse(Console.ReadLine());

            //Console.WriteLine("a + b + c = {0}", a + b + c);


            //homework#4
            //char ch = char.Parse(Console.ReadLine());

            //int num = (int)ch;
            //int numBefore = num - 1;
            //int numAfter = num + 1;

            //char chBefore = (char)numBefore;
            //char chAfter = (char)numAfter;

            //Console.WriteLine(chBefore);
            //Console.WriteLine(chAfter);

            //homework, fix A, Z input bug
            //edge case

            //homework#5
            //ceaser cipher

            //char ch = char.Parse(Console.ReadLine());
            //int key = 3;

            //Console.WriteLine("encrypting...");

            //int num = ch;
            //num += key;

            //char encryptedCh = (char)num;
            //Console.WriteLine(encryptedCh);

            //linear
            //int a = 1;
            //int b = 2;

            //operations

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //bool r = a > b;

            //if (a > b)
            //{
            //    Console.WriteLine("a is bigger than b");

            //    Console.WriteLine("a");
            //    Console.WriteLine("test");
            //    Console.WriteLine("hello world");
            //}

            //if (a > b)
            //    Console.WriteLine("a is bigger than b");

            //Console.WriteLine("a");
            //Console.WriteLine("test");
            //Console.WriteLine("hello world");

            //if (a > b)
            //{
            //    Console.WriteLine("a is bigger than b");
            //}
            //else
            //{
            //    Console.WriteLine("a is smaller than b");
            //}

            //if (a < b)
            //{
            //    Console.WriteLine("a is smaller than b");
            //}

            //if(true)
            //{
            //    Console.WriteLine("Hello from true world");
            //}
            //else
            //{
            //    Console.WriteLine("Hello from false world");
            //}

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //if (a == b)
            //{
            //    Console.WriteLine("a is equal to b");
            //}
            //else
            //{
            //    Console.WriteLine("a is not equal to b");
            //}

            //Console.WriteLine("Program finished.");

            //int a = int.Parse(Console.ReadLine());

            //if(a % 6 == 0)
            //{
            //    Console.WriteLine("a is dividable to 6");
            //}
            //else
            //{
            //    Console.WriteLine("a is not dividable to b");
            //}

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //if (a % b == 0)
            //{
            //    Console.WriteLine($"{a} is dividable to {b}");
            //}
            //else
            //{
            //    Console.WriteLine($"{a} is not dividable to {b}");
            //}

            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //int c = int.Parse(Console.ReadLine());

            ////a > b > c
            //if (a > b && b > c)
            //{
            //    Console.WriteLine("a > b > c");
            //}
            //else
            //{
            //    Console.WriteLine("decision statement is negative");
            //}
            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("c = ");
            //int c = int.Parse(Console.ReadLine());

            ////a > b > c
            //if (a > b && b > c)
            //{
            //    Console.WriteLine("a > b > c");
            //}
            //else
            //{
            //    Console.WriteLine("decision statement is negative");
            //}

            //&&, ||, !, &, |

            //int a = 15;

            //if (a % 4 == 0 && a++ > 10)
            //{
            //    Console.WriteLine(a);
            //}

            //if (a % 4 == 0 & a++ > 10)
            //{
            //    Console.WriteLine(a);
            //}

            //Console.WriteLine(a);

            //int a = 15;

            //if (a % 3 == 0 || a++ > 10)
            //{
            //    Console.WriteLine(a);
            //}

            //if (a % 3 == 0 | a++ > 10)
            //{
            //    Console.WriteLine(a);
            //}

            //if
            //else
            //else if

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //if (a > b)
            //{
            //    Console.WriteLine("a is bigger than b");
            //}
            //else if (a == b)
            //{
            //    Console.WriteLine("a is equal to b");
            //}
            //else
            //{
            //    Console.WriteLine("a is smaller than b");
            //}

            //Console.Write("a1 = ");
            //int a1 = int.Parse(Console.ReadLine());

            //Console.Write("a2 = ");
            //int a2 = int.Parse(Console.ReadLine());

            //Console.Write("Operator = ");
            //char ch = char.Parse(Console.ReadLine());
            //int result = 0;

            //if(ch == '+')
            //{
            //    result = a1 + a2;
            //}
            //else if(ch == '-')
            //{
            //    result = a1 - a2;
            //}
            //else if(ch == '*')
            //{
            //    result = a1 * a2;
            //}
            //else if(ch == '/')
            //{
            //    result = a1 / a2;
            //}
            //else
            //{
            //    Console.WriteLine("Error: This operator is unkown");
            //}

            //Console.WriteLine(result);

            //int a = int.Parse(Console.ReadLine());

            //if(a % 2 == 1)
            //{
            //    Console.WriteLine("A is odd");
            //}

            //if (a % 2 != 0)
            //{
            //    Console.WriteLine("A is odd");
            //}

            //int a = int.Parse(Console.ReadLine());

            //if(a % 2 == 0 || a % 3 ==0)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    Console.WriteLine("a cannot be divided to 2 or 3'");
            //}


            //int a = int.Parse(Console.ReadLine());
            // false || true => true

            //if (a % 2 != 0 || a % 3 != 0)
            //{
            //    Console.WriteLine("Solution 1 correct");
            //}

            //if (!(a % 2 == 0 || a % 3 == 0))
            //{
            //    Console.WriteLine("Solution 2 correct");
            //}

            //if (a % 2 != 0 && a % 3 != 0)
            //{
            //    Console.WriteLine("Solution 3 correct");
            //}

            //if( (a % 2 == 0 || a % 3 == 0) == false )
            //{
            //    Console.WriteLine("Solution 4 correct");
            //}

            //nested ifs

            //if()
            //{
            //    if ()
            //    {
            //        if ()
            //        {

            //        }
            //    }
            //}

            //int a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0 || a % 3 == 0)
            //{
            //    Console.WriteLine(a);

            //    if (a % 2 == 0)
            //    {
            //        Console.WriteLine("It's printed because it can be divided by 2");
            //    }
            //    else
            //    {
            //        Console.WriteLine("It's printed because it can be divided by 3");
            //    }
            //}

            //int a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0)
            //{
            //    Console.WriteLine(a);

            //    if(a % 3 == 0)
            //    {
            //        Console.WriteLine("It's printed because it can be divided by 2 and 3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("It's printed because it can be divided by 2");
            //    }
            //}
            //else if(a % 3 == 0)
            //{
            //    Console.WriteLine(a);
            //    Console.WriteLine("It's printed because it can be divided by 3");
            //}

            //verilmis ededin(ekrandan daxil edilsin) 4-e ve ya 5-e bolunmesini yoxlayin, 
            //1. Hem 4-e hem 5-e bolunurse 4 ve 5-e bolunduyun ekrana yazin
            //2. Yalniz 4-e bolunurse 4-e bolunduyun ekrana yazin
            //3. Yalniz 5-e bolunurse 5-e bolunduyun ekrana yazin

            //Daxil edilmiş ədəd 40-a bölünürsə 9-a bölünməsini yoxla həmçinin 9-a bölünürsə 7-yə bölünməsini yoxla
        }
    }
}
