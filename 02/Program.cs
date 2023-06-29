using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            //integrity

            //floating point numbers -> sürüşkən vergüllü tiplər
            int x = 9;
            float y = 0.2f;

            //bit the smallest one 
            //may contain 1 or 0
            //1 byte consists of 8 bits
            //1 kilobyte = 1024 byte, 2^10 byte
            //1 megabyte = 1024 kilobyte, 1024 * 1024 byte, 2^20 byte
            //1 gigabyte = 1024 megabyte, 1024 * 1024 kilobyte, 1024 * 1024 * 1024 byte, 2^30 byte

            //integrity -> int
            //byte -> 1 byte 0 - 255
            //short -> 2 byte -32k - 32k
            //int  -> 4 byte -2b - 2b
            //long -> 8 byte -4t - 4t

            //byte a = 300; wrong
            //short a = 300;

            //floating point numbers
            //float -> 4 byte
            //double -> 8 byte
            //decimal -> 16 byte

            //int a = 200000;
            //int b = int.MinValue;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //byte bt = -100; wrong
            //sbyte sbt = -100;

            //uint ut = -20000; wrong
            //ushort
            //ulong

            //float f = 5.6f;
            //double d = 6.7d;
            //decimal m = 9.1m;

            //value type, 
            //arithmetic operation
            //logical type: boolean
            bool l = true;
            bool lb = false;

            //mətin tipli məlumat, text type (string is not value type)
            //string text = "It's a good day";
            //Console.WriteLine(text);
            //--
            //Console.WriteLine("It's a good day");

            //Unicode  
            //ASCII A - 65, B - 66, C - 67
            //Encoding

            //int t = 0;
            //char ch = '0';
            //character type:
            //char c = 'A';
            //Console.WriteLine(c);
            //Note: char is value type

            //ASCII - 1 byte
            //Unicode - 2 byte 0 - 65k

            //Console.OutputEncoding = Encoding.UTF8;
            //char ch = 'Ə';
            //Console.WriteLine(ch);

            //int a = 5;
            //int t = 5;
            //int 1a = 5;/ wrong
            //int a-1 = 4; wrong
            //int a 1 = 6; wrong
            //int a_1 = 7;//correct
            //int a1 = 8; //correct

            //type conversion, tip çevrilmələri

            //implicit conversion
            //short s = 5;
            //int a = s;

            //explict conversion
            //int a1 = 6;
            //short s1 = (short)a1;

            //Console.WriteLine(s);
            //Console.WriteLine(a);
            //Console.WriteLine(s1);

            //int a1 = 100_000;
            //short s1 = (short)a1;

            //Console.WriteLine(s1);

            //float f1 = 12.3f;
            //double d1 = f1;
            //decimal m1 = (decimal)f1;

            //Console.WriteLine(f1);
            //Console.WriteLine(d1);
            //Console.WriteLine(m1);

            //type conversion/ type casting

            //operators
            //+

            //int a = 5;
            //int b = 6;
            ////result operand operator operand
            //int sum =   a        +      b;

            //Console.WriteLine(sum);

            //Arithmetic operators
            //+, -, *, /, %
            //int a = 13;
            //int b = 6;
            //int c = 2;
            //int sum = a + b;
            //int multiply = a * b;
            //int division = a / b;
            //int difference = a - b;
            //int remainder = a % b;

            //int result = (a + b) * 2;
            //Console.WriteLine(result);

            //int a = 89;
            //int b = 13;
            //int c = a / b;

            //Console.WriteLine(c);

            //Console.WriteLine("Sum: {0}", sum);
            //Console.WriteLine("Multiple: {0}", multiply);
            //Console.WriteLine("Division: {0}", division);
            //Console.WriteLine("Difference: {0}", difference);
            //Console.WriteLine("Remainder: {0}", remainder);

            //int a = 5 / 2;
            //Console.WriteLine(a);

            //int a = 13;
            //double b = 2;

            //int result = (int)(a / b);

            //Console.WriteLine(result);

            //int a = (int)2.8;
            //Console.WriteLine(a);

            //double a = (double)(13.0m / 2);
            //Console.WriteLine(a);

            //int a = 5;
            //int b = 2;

            //Console.WriteLine(a % b);

            //verilmiş istənilən ədədin sonuncu rəqəmini tapın

            //int a = 1689;
            //int b = a / 10;
            //int c = a % 10;
            ////result: 16, remainder 5

            //Console.WriteLine(c);

            //verilmiş 6 rəqəmli ədədin rəqəmləri cəmini tapan proqram yazın.
            //123456 => 1 + 2 + 3 + 4 + 5 + 6 = 21

            //int a = 123123;
            //Console.WriteLine(a);
        }
    }
}
