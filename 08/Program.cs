using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vurma cedveli
            //int n = 9;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if(j > 3)
            //        {
            //            break;
            //        }

            //        Console.Write($" {j} * {i} = {i * j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (j <= 3 || j > 6)
            //        {
            //            continue;
            //        }

            //        Console.Write($" {j} * {i} = {i * j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (j <= 6)
            //        {
            //            continue;
            //        }

            //        Console.Write($" {j} * {i} = {i * j}\t");
            //    }
            //    Console.WriteLine();
            //}
            /*
             * 1 * 1 = 1    2 * 1 = 2   
             * 1 * 2 = 2    2 * 2 = 4
             * 1 * 3 = 3    2 * 3 = 6
             * 1 * 4 = 4    2 * 4 = 8
             * 1 * 5 = 5    2 * 5 = 10
             * 1 * 6 = 6    2 * 6 = 12
             * 1 * 7 = 7    2 * 7 = 14
             * 1 * 8 = 8    2 * 8 = 16
             * 1 * 9 = 9    2 * 9 = 18
             * 
             * 3 * 1 = 3
             * 
             * -------
             */

            //int n = 9;
            //int maxColumnLimit = 5;

            //int columnStart = 1;
            //int columnEnd = maxColumnLimit;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if (j >= columnStart && j <= columnEnd)
            //        {
            //            Console.Write($" {j} * {i} = {i * j}\t");
            //        }
            //    }

            //    Console.WriteLine();

            //    if (i == n && columnEnd < n)
            //    {
            //        columnStart += maxColumnLimit;
            //        columnEnd += maxColumnLimit;

            //        i = 1;
            //        Console.WriteLine();
            //    }
            //}

            //strings
            //string a = "Hello this is test";
            //Console.WriteLine(a);

            //Console.WriteLine("The value is {0}", 1);

            //string x = string.Format("The values are {0} and {1}", 1, 2);
            //Console.WriteLine(x);

            //string helloText = "Hello, {0}";

            //string formatted = string.Format(helloText, "Mahammad Agayev");
            //Console.WriteLine(formatted);

            //Console.OutputEncoding = Encoding.UTF8;
            //CultureInfo.CurrentCulture = new CultureInfo("tr-TR");

            //decimal moneyOnAccount = decimal.Parse(Console.ReadLine());

            //string s = string.Format("The money on your account is {0:C2}", moneyOnAccount);
            //Console.WriteLine(s);

            //https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            //12000 12.000

            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());

            //string s = string.Format("The value: {0,-10:N0}{1:N0}", a, b);
            //Console.WriteLine(s);

            //string s = Console.ReadLine();

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == 'A')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //TESTFORPROGRAMMING009
            //0,3

            //string s = Console.ReadLine();

            //int index = s.IndexOf('A');
            ////int index2 = s.IndexOf("ABCD");
            //int lastIndex = s.LastIndexOf('A');

            //Console.WriteLine(index);
            //Console.WriteLine(lastIndex);

            //string s = "Today is rainy, but yesterday was sunny";//Console.ReadLine();

            //int index = s.IndexOf("day");
            //int lastIndex = s.LastIndexOf("day");

            //Console.WriteLine(index);
            //Console.WriteLine(lastIndex);

            //Console.WriteLine(s[index]);
            //Console.WriteLine(s[lastIndex]);

            //string s = "Today is rainy, but yesterday was sunny";//Console.ReadLine();

            //int index = s.IndexOfAny(new char[] { 'y', 'a', });
            //Console.WriteLine(index);

            //string s = "Today is rainy, but yesterday was sunny";//Console.ReadLine();

            //s = s.Replace("yesterday", "tomorrow");
            //s = s.Replace("was", "will be");

            //Console.WriteLine(s);

            //string a = "It a shiny product, created by a popular company";

            //a = a.Replace("a", "the");

            //Console.WriteLine(a);
            //                  123456789
            //string a = "This is the value for test";
            //          012345679
            //string b = a.Substring(8, 9);
            //Console.WriteLine(b);

            //somethinga
            //0123456789

            //string a = "somethinga";
            //Console.WriteLine(a.Substring(4,5));

            //string s = "Today is rainy, but yesterday was sunny";
            //int index = s.IndexOf(',');


            ////first part
            //Console.WriteLine(s.Substring(0, index));

            ////second part
            //Console.WriteLine(s.Substring(index + 1, s.Length - index - 1));


            //verilmis cumlede olan herflerin sayini tapin.
            //verilmis cumlede olan sozlerin sayini tapin.

            //remove and subtring
            //string s = "Today is rainy, but yesterday was sunny";
            //int index = s.IndexOf(",");

            ////s = s.Remove(index);
            //Console.WriteLine(s.Substring(index + 1, s.Length - index - 1));
            //Console.WriteLine(s.Remove(index + 1, s.Length - index - 1));

            //string s = "This is my phonenumber 51911661, I will cal you later";

            //int firstIndex = s.IndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
            //int lastIndex = s.LastIndexOfAny(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });

            //Console.WriteLine(s.Substring(firstIndex, lastIndex - firstIndex + 1));

            //verilmis istenilen cumlede mail unvanini tapan proqram yazin.

            //Cumle: Men bugun test@gmail.com adresine melumat gonderdim.

            //padding
            //string name1 = "Mahammad";
            //string surname1 = "Agayev";
            //string name2 = "Cavid";
            //string surname2 = "Aliyev";

            //Console.WriteLine(name1.PadRight(10, 'X') + " " + surname1);
            //Console.WriteLine(name2.PadRight(10, 'X') + " " + surname2);

            string s = "+994519110661-";

            //s = s.TrimEnd();
            //s = s.TrimStart();

            s = s.Trim();
            s = s.TrimEnd('-');
            s = s.TrimStart('+');

            Console.WriteLine(s);
        }
    }
}
