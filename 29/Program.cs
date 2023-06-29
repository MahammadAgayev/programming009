using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Person
    {

        public Person(string fullname, int age)
        {
            Fullname = fullname;
            Age = age;
        }

        public string Fullname { get; set; }
        public int Age { get; set; }

        public CarInfo CarInfo { get; set; }

        public Person Copy()
        {
            Person obj =  new Person(Fullname, Age);
            obj.CarInfo = CarInfo;

            return obj;
        }
    }

    class CarInfo
    {
        public int CarAge { get; set; }
        public string CarName { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = Sum(1, 2);
            int sum2 = Sum(1, 2, 3);
            double sum3 = Sum(1, 1.3);
            double sum4 = Sum(1.3, 5.5);

            //method overloading
            //metodlar əlavə yüklənməsi
            //metodların yenidən yüklənməsi

            //polymorphism -> coxolcululuk

            //difference between
            //value and reference type

            //int a = 10;
            //Person p = new Person();
            //p.Age = 20;

            //Person c = p;
            //c.Age = 22;

            //Console.WriteLine(p.Age);
            //Console.WriteLine(c.Age);

            //int b = a;
            //b = 12;

            //Console.WriteLine(a);
            //Console.WriteLine(b
            //
            //string s = "1gb text";
            //string s1 = s;

            /*
             *    Stack        Heap(SOH, LOH)
             *    +----+      +-------------+
             *    |a:10|   h1 |Person:22    |
             *    |p:h1|      |             |
             *    |b:a |      |             |
             *    |c:h1|      |             |
             *    +----+      +-------------+
             *     
             */


            Person p = new Person("Mahammad Agayev", 22);
            p.CarInfo = new CarInfo
            {
                CarAge = 5,
                CarName = "Prius"
            };

            Person c = p.Copy();

            p.Fullname = "Muzeffer Agayev";

            string a = "hello";

            Console.WriteLine(p.Fullname);
            Console.WriteLine(c.Fullname);

            Person p2 = new Person("test", 1);
            Person p3 = p2.Copy();

            /*
             *    Stack        Heap(SOH, LOH)
             *    +----+      +--------------------+
             *    |p:h1|   h1 |Person{Age:22, h2}  |
             *    |c:h3|   h2 |"Mahammad Agayev"   |
             *    |    |   h3 |Person{Age:22, h4}  |
             *    |    |   h4 |"Muzeffer Agayev"   |
             *    +----+      +--------------------+
             *     
             *     32 bit: 4byte
             *     64 bit: 8byte
             */

            //int[] a = new int[3];
            /*
             * Stack           Heap(SOH, LOH)
             * +----+         +--------------------+
             * |a:h1|      h1 |{ 0, 0, 0 }         |
             * |b:h1|      h2 |{ 0, 0, 0 }         |
             * |    |      h3 |                    |
             * |    |      h4 |                    |
             * +----+         +--------------------+
             */

            //int a = 10;
            //string s1 = "Hello";

            //string[] sArr = new string[3];
            //sArr[0] = "1kb text";
            //sArr[1] = "1kb text";
            //sArr[2] = "1kb text";

            string a2 = "Hello World";
            string b = a2 + "!";

            //string interpolation
            string s = $"hello world {1}";

            //ref/out
        }

        //           method signature
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(int a, double b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
