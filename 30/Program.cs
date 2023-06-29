using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _30
{
    class Person
    {
        public Person(int age)
        {
            this.Age = age;
        }

        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = "test";
            //string b = "test" + "a";

            /*
             * a -> "test"
             * b -> "testa"
             */

            //string is immutable type

            //ref/out

            //int a = 10;

            //Console.WriteLine(a);
            //Square(ref a);
            //Console.WriteLine(a);

            /*
             *    Stack        Heap(SOH, LOH)
             *    +------+      +-------------+
             * s1 |a:10  |   h1 |             |
             *    |x:s1  |      |             |
             *    |      |      |             |
             *    |      |      |             |
             *    +------+      +-------------+
             */

            //int a = 1;

            //Console.WriteLine(a);
            //Increase(a);
            //Console.WriteLine(a);
            //Increase(a);
            //Console.WriteLine(a);
            //Increase(a);

            //Console.WriteLine(a);

            //char c = 'A';

            //EncryptChar(ref c);
            //Console.WriteLine(c);

            //int a = 5;

            //Decrease(ref a);

            //Console.WriteLine(a);

            //Person p = new Person(20);

            //IncreaseAge(p);
            //Console.WriteLine(p.Age);

            /*
             *    Stack        Heap(SOH, LOH)
             *    +------+      +-------------+
             * s1 |p:h1  |   h1 |Person       |
             *    |pcopy:h1|    |             |
             *    |      |      |             |
             *    |      |      |             |
             *    +------+      +-------------+
             */

            //Person p = new Person(20);

            //IncreaseAge(p);

            //Console.WriteLine(p.Age);

            /*
             *    Stack        Heap(SOH, LOH)
             *    +------+      +-------------+
             * s1 |p:h1  |   h1 |Person:20    |
             *    |pc:h2 |   h2 |Person:21    |
             *    |      |      |             |
             *    |      |      |             |
             *    +------+      +-------------+
             */

            //Person p = new Person(20);

            //IncreaseAge(ref p);

            //Console.WriteLine(p.Age);

            //Console.WriteLine(p.Age);

            /*
             *    Stack        Heap(SOH, LOH)
             *    +------+      +-------------+
             * s1 |p:h2  |   h1 |Person:20    |
             *    |pc:s1 |   h2 |Person:21    |
             *    |      |      |             |
             *    |      |      |             |
             *    +------+      +-------------+
             */

            //int a = 10;

            //Square(ref a);
            //Console.WriteLine(a);


            //int a;
            //SetValue(out a);

            //Console.WriteLine(a);

            //int age = 15;

            //string password = Console.ReadLine();

            //string errorMessage;
            //bool result = ValidatePassword(password, out errorMessage);

            //if(result)
            //{
            //    Console.WriteLine("Password is correct");
            //}
            //else
            //{
            //    Console.WriteLine(errorMessage);
            //}

            //if(ValidatePassword(password, out string errorMessage) == false)
            //{
            //    Console.WriteLine(errorMessage);
            //}
            //else
            //{
            //    Console.WriteLine("Password is correct");
            //}

            //int a = 5;
            //int b = 0;

            //int result = Divide(a, b);
            //Console.WriteLine(result);

            //if (TryDivide(a, b, out int result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Bölmə əməliyyatı uğursuz oldu");
            //}

            int a = 10;
            int b = 12;

            Swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }


        static bool ValidatePassword(string password, out string errorMessage)
        {
            if(password.Length < 6)
            {
                errorMessage = "Password length should be bigger that 6";
                return false;
            }

            if(password.Contains("@"))
            {
                errorMessage = "Password should not contain @";
                return false;
            }

            bool hasUpperFound = false;
            for (int i = 0;  i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                {
                    hasUpperFound = true;
                }
            }

            if(hasUpperFound == false)
            {
                errorMessage = "Password should contain upper symbol";
                return false;
            }

            errorMessage = null;
            return true;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }

        static bool TryDivide(int a, int b, out int result)
        {
            try
            {
                result =  a / b;
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }

        static void SetValue(out int x)
        {
            x = 10;
        }

        static void Square(ref int x)
        {
            x *= x;
        }

        static void Increase(int a)
        {
            a++;
        }

        static void EncryptChar(ref char c) // char cCopy = 'A';
        {
            int a = c + 5;

            c = (char)a;
        }

        static void Decrease(int a)
        {
            a--;
        }

        static void IncreaseAge(ref Person pCopy)
        {
            //pCopy.Age++;
            pCopy = new Person(pCopy.Age + 1);
        }

        //static void IncreaseAge(ref Person p)
        //{
        //    p = new Person(p.Age + 1);
        //}
    }
}
