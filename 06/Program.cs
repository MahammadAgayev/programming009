using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //homeworkd#1
            //int a = int.Parse(Console.ReadLine());

            //int a1 = a / 100;
            //int a2 = a / 10 % 10;
            //int a3 = a % 10;

            //a1 front
            //a1 > a2 > a3
            //a1 > a3 > a2

            //a2 front
            //a2 > a1 > a3
            //a2 > a3 > a1

            //a3 front
            //a3 > a1 > a2
            //a3 > a2 > a1

            //if (a1 > a2 && a2 > a3)
            //{
            //    Console.WriteLine($"{a1} > {a2} > {a3}");
            //}
            //else if(a1 > a3 && a3 > a2)
            //{
            //    Console.WriteLine($"{a1} > {a3} > {a2}");
            //}
            //else if (a2 > a1 && a1 > a3)
            //{
            //    Console.WriteLine($"{a2} > {a1} > {a3}");
            //}
            //else if (a2 > a3 && a3 > a1)
            //{
            //    Console.WriteLine($"{a2} > {a3} > {a1}");
            //}
            //else if (a3 > a1 && a1 > a2)
            //{
            //    Console.WriteLine($"{a3} > {a1} > {a2}");
            //}
            //else if (a3 > a2 && a2 > a1)
            //{
            //    Console.WriteLine($"{a3} > {a2} > {a1}");
            //}


            //a1 front
            //a1 > a2 > a3
            //a1 > a3 > a2

            //a2 front
            //a2 > a1 > a3
            //a2 > a3 > a1

            //a3 front
            //a3 > a1 > a2
            //a3 > a2 > a1

            //213
            //if (a1 > a2)
            //{
            //    if(a2 > a3)
            //    {
            //        Console.WriteLine("a1 > a2 > a3");
            //    }
            //    else if(a3 > a1)
            //    {
            //        Console.WriteLine("a3 > a1 > a2");
            //    }
            //    else
            //    {
            //        Console.WriteLine("a1 > a3 > a2");
            //    }
            //}
            //else // a2 > a1
            //{
            //    if(a1 > a3)
            //    {
            //        Console.WriteLine("a2 > a1 > a3");
            //    }
            //    else if(a3 > a2)
            //    {
            //        Console.WriteLine("a3 > a2 > a1");
            //    }
            //    else
            //    {
            //        Console.WriteLine("a2 > a3 > a1");
            //    }
            //}

            //homework#3
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());

            //int apow2 = a * a;
            //int bpow2 = b * b;
            //int cpow2 = c * c;

            //if(apow2 + bpow2 == cpow2)
            //{
            //    Console.WriteLine("Pifaqor ededleridir");
            //}
            //else if(apow2 + cpow2 == bpow2)
            //{
            //    Console.WriteLine("Pifaqor ededleridir");
            //}
            //else if(bpow2 + cpow2 == apow2)
            //{
            //    Console.WriteLine("Pifaqor ededleridir");
            //}
            //else
            //{
            //    Console.WriteLine("Pifaqor ededleri deyil");
            //}

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for
            //while
            //do while


            //DO NOT WRITE THIS WITH WHILE
            //int n = int.Parse(Console.ReadLine());

            //int i = 0;
            //while(i < n)
            //{
            //    Console.WriteLine(i);

            //    i++;
            //}

            //string password = Console.ReadLine();
            //string correctPassword = "12345";

            //if(password != correctPassword)
            //{
            //    Console.WriteLine("Password is not correct, Please type password again");

            //    password = Console.ReadLine();
            //}

            //while (password != correctPassword)
            //{
            //    Console.WriteLine("Password is not correct, Please type password again");

            //    password = Console.ReadLine();
            //}

            //for (;password != correctPassword;)
            //{
            //    Console.WriteLine("Password is not correct, Please type password again");

            //    password = Console.ReadLine();
            //}

            //Console.WriteLine("Login success");

            //char a1 = '-';
            //char a2 = '\\';
            //char a3 = '|';
            //char a4 = '/';

            //int i = 0;
            //bool gameIsReady = false;

            //while(gameIsReady == false)
            //{
            //    if(i % 2 == 0)
            //    {
            //        Console.Write("\rloading..." + a1);
            //    }
            //    else if(i % 3 == 0)
            //    {
            //        Console.Write("\rloading..." + a2);
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.Write("\rloading..." + a3);
            //    }
            //    else if (i % 7 == 0)
            //    {
            //        Console.Write("\rloading..." + a4);
            //    }

            //    i++;
            //}

            //do while

            //do
            //{
            //    Console.WriteLine("Test...");
            //}
            //while (true);

            //int n = int.Parse(Console.ReadLine());
            //int i = 0;

            //do
            //{
            //    Console.WriteLine(i);

            //    i++;
            //} while (i < n);

            //while(i < n)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //for(true)
            //{
            //    Console.WriteLine("test");
            //}

            //while(true)
            //{

            //}

            //nested loops

            //int a = 6;
            //int b = 5;
            //int c = 4;

            //if (a > b)
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine("a > b > c");
            //    }
            //}

            //int n = 10;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.WriteLine($"i = {i}, j = {j}");
            //    }
            //}

            //break
            //continue

            //int n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(i);

            //    if (i >= 50)
            //        break;
            //}

            //Console.WriteLine("loop finished");

            //string password = Console.ReadLine();
            //string correctPassword = "12345";

            //int retryCount = 3;

            //while(password != correctPassword)
            //{
            //    retryCount--;

            //    if(retryCount == 0)
            //    {
            //        Console.WriteLine("Your account is blocked");
            //        break;
            //    }

            //    Console.WriteLine($"Your password is not correct, Your remaining attempt: {retryCount}, Please enter password again.");

            //    password = Console.ReadLine();
            //}            //string password = Console.ReadLine();
            //string correctPassword = "12345";

            //int retryCount = 3;

            //while(password != correctPassword)
            //{
            //    retryCount--;

            //    if(retryCount == 0)
            //    {
            //        Console.WriteLine("Your account is blocked");
            //        break;
            //    }

            //    Console.WriteLine($"Your password is not correct, Your remaining attempt: {retryCount}, Please enter password again.");

            //    password = Console.ReadLine();
            //}

            //continue

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 5 != 0)
            //        Console.WriteLine(i);
            //}

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 5 == 0)
            //        continue;

            //    Console.WriteLine(i);
            //}

            //nested loops
            int n = 10;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //j == 4
                    if (i == j)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
