using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Instrumentation;
using System.Net.Http.Headers;

namespace _20
{
    public class Person
    {
        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Fullname
        {
            get
            {
                return Name.PadRight(10) + " " + Surname;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //list

            //ArrayList l = new ArrayList();

            //l.Add(1);
            //l.Add(2);
            //l.Add(3);
            //l.Add(4);
            //l.Add(5);
            //l.Add(6);

            //for (int i = 0; i< l.Count; i++) 
            //{
            //    Console.WriteLine(l[i]);
            //}

            //ArrayList l = new ArrayList();
            //for (int i = 0; i < 10_000; i++)
            //{
            //    l.Add(i);
            //}

            //for (int i = 0; i < l.Count; i++)
            //{
            //    Console.WriteLine(l[i]);
            //}

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("Test");
            //arrayList.Add(true);
            //arrayList.Add('A');
            //arrayList.Add(12415.23425m);
            //arrayList.Add(12.5d);

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}

            //box/unboxing
            //int a = 1143;
            //object b = a;
            //int c = (int)b;

            //Class a = new Class()

            //int a = 12;
            //int c = a;
            //Person b = new Person();
            //Person c = b;
            /*
             *   Stack       Heap
             *   +----+      +--------------+
             * a | 12 |   ha |              |
             * b | hb |   hb | Person{  }   |
             * c | hb |   hc |              |
             *   |    |      |              |
             *   |    |      |              |
             *   |    |      |              |
             *   +----+      +--------------+
             */

            int a = 35;
            //boxing
            object b = a;
            //unboxing
            int c = (int)b;
            /*
             *   Stack       Heap
             *   +----+      +--------------+
             * a | 35 |   ha |              |
             * b | hb |   hb | { int: 35}   |
             * c | 35 |   hc |              |
             *   +----+      +--------------+
             */

            //generic
            //List<int> l = new List<int>();
            //l.Add(1);
            //l.Add(2);
            //l.Add(3);
            //l.Add(5);

            //l.Insert(3, 4);
            ////if (l.Contains(5))
            ////{
            ////    Console.WriteLine("5 is in the list");
            ////}

            ////l.Clear();
            //l.Remove(3);

            //for (int i = 0; i < l.Count; i++)
            //{
            //    Console.WriteLine(l[i]);
            //}

            //foreach (var item in l)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] arr = new int[3] { 1, 2, 3 };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //arr[i] = arr[i] + 1;
            //    arr[i]++;
            //}

            //foreach (var item in arr)
            //{
            //    //item = item + 1;
            //    //item++;
            //    //item = nese olmaz
            //}

            //List<string>  strings= new List<string>(); ;
            //strings.Add("Test");
            //strings.Add("Test1");
            //strings.Add("Test2");
            //strings.Add("Test3");
            //strings.Add("Test4");
            //strings.Add("Test5");

            //foreach (var item in strings)
            //{
            //    Console.WriteLine(item);
            //}

            //List<Person> persons = new List<Person>();

            //persons.Add(new Person("Kamal", "Jalilov"));
            //persons.Add(new Person("Jamila", "Huseynli"));
            //persons.Add(new Person("Javid", "Javidov"));

            //foreach (var item in persons)
            //{
            //    Console.WriteLine(item.Fullname);
            //}


            ////dotnet memory management
            //List<int> l = new List<int>();
            //l.Add(1);// [1]
            //l.Add(2);//[1,2]
            //l.Add(3);//[1,2,3,0]
            //l.Add(4); //[1,2,3,4]
            //l.Add(5);//[1,2,3,4,5,0,0,0]
            ////int                |
            ////Capacity, Count

            //Console.WriteLine("Count: " + l.Count);
            //Console.WriteLine("Capaticy: " + l.Capacity);

            //foreach (var item in l)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(int.MaxValue);

            //int -> 4 byte
            //2 000 000 000 * 4 byte 
            //8 000 000 000 byte -> 8 000 000 kb -> 8 000 mb -> 8 gb

            //List<int> l = new List<int>();

            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    l.Add(i);
            //}

            //Console.WriteLine("Count: " + l.Count);
            //Console.WriteLine("Capaticy: " + l.Capacity);

            //List<int> ints = new List<int>(10);

            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //ints.Add(4);
            //ints.Add(5);
            //ints.Add(6);
            //ints.Add(7);
            //ints.Add(8);
            //ints.Add(9);
            //ints.Add(10);
            //ints.Add(11);

            //Console.WriteLine("Count: " + ints.Count);
            //Console.WriteLine("Capaticy: " + ints.Capacity);


            LinkedList<int> l = new LinkedList<int>();

            l.AddLast(1);
            l.AddLast(2);
            l.AddLast(3);

            foreach (var item in l)
            {
                Console.WriteLine(item);
            }

            object o = 1;

            /*
             *   Stack       Heap
             *   +----+      +-------------------+
             * l | ha |   ha |  { 1: Next: hb }  |
             * b |    |   hb |  { 2: Next: hc }  |
             * c |    |   hc |  { 3: }           |
             *   +----+      +-------------------+
             */
        }
    }
}
