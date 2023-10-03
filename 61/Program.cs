using System;
using System.Globalization;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;

namespace _61
{
    class Animal
    {
        public string Name { get; set; }
        public void Eat()
        {

        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking....");
        }
    }

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }
    }

    class Author
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    class RandomData
    {
        public int P1 { get; set; }
        public char P2 { get; set; }
        public string P3 { get; set; }
        public bool P4 { get; set; }
        public decimal P5 { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //Person person = new Person();
            //person.Age = 10;

            //as, is

            //Reflection

            //int a = 12;
            //Animal animal = Get();

            //if(animal is Dog dog)
            //{
            //    dog.Bark();
            //}
            //else
            //{
            //    Console.WriteLine("no need to bark");
            //}

            //Animal animal = Get();

            ////#1
            //Type type = animal.GetType();

            ////#2
            //Type type2 = typeof(Animal);

            //Console.WriteLine(animal);

            //object o = Get();

            //Book b = new Book()
            //{
            //    Name = "Tst",
            //    PageCount = 50
            //};

            //Print(b);


            //Type t = o.GetType();
            //Console.WriteLine(t.Name);
            //Console.WriteLine(t.FullName);

            //PropertyInfo[] props = t.GetProperties();

            //foreach (PropertyInfo p in props)
            //{
            //    Console.WriteLine(p.Name);
            //}

            Book[] books =
            {
                new Book()
                {
                    Name= "Test1",
                    PageCount = 100
                },
                new Book()
                {
                    Name = "Test2",
                    PageCount = 200
                }
            };

            Author[] authors =
            {
                new Author
                {
                    Name = "Test",
                    Surname  = "Test"
                },
                new Author
                {
                    Name = "Test2",
                    Surname = "Teeeest2"
                }
            };

            RandomData[] datas = new RandomData[]
            {
                new RandomData { P1 = 1, P2 =  'A', P3 = "Test_1", P4 = true, P5 = 132.5454m },
                new RandomData { P1 = 2, P2 =  'B', P3 = "Test_2", P4 = false, P5 = 13452.12m },
                new RandomData { P1 = 3, P2 =  'D', P3 = "Test_3", P4 = true, P5 = 1754.30m }
            };


            Console.Write("List to show: ");
            string listType = Console.ReadLine();

            switch (listType)
            {
                case "authors":
                    Print(authors);
                    break;
                case "books":
                    Print(books);
                    break;
                case "randomdata":
                    Print(datas); 
                    break;
            }
        }

        static Animal GetAnimal()
        {
            return new Dog();
        }

        static object Get()
        {
            return new Dog();

            return new Person
            {
                Age = 20,
                Name = "Mahammad",
                Surname = "Agayev"
            };
        }

        static void Print(Book b)
        {
            Console.WriteLine($"{b.Name}, {b.PageCount}");
        }

        static void PrintBooks(Book[] books)
        {
            Console.WriteLine($"{"Name".PadRight(10)}\tPageCount");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Name.PadRight(10)}\t{book.PageCount}");
            }
        }

        static void PrintAuthors(Author[] authors)
        {
            Console.WriteLine($"{"Name".PadRight(10)}\tSurname");
            foreach (Author author in authors)
            {
                Console.WriteLine($"{author.Name.PadRight(10)}\t{author.Surname}");
            }
        }

        static void Print(object[] objects)
        {
            if (objects.Length == 0)
            {
                return;
            }

            object obj = objects[0];

            Type t = obj.GetType();

            PropertyInfo[] props = t.GetProperties();

            string header = "";

            foreach (var prop in props)
            {
                header += prop.Name.PadRight(10) + "\t";
            }

            Console.WriteLine(header);

            foreach (var o in objects)
            {
                string line = "";

                foreach (var p in props)
                {
                    line += p.GetValue(o).ToString().PadRight(10) + "\t";
                }

                Console.WriteLine(line);
            }
        }
    }
}
