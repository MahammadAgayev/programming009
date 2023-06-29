using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17
{
    class Person
    {
        //constructor
        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        //access modifier
        private string firstname;
        //field
        private string lastname;

        private string phonePassword;

        public void Show()
        {
            Console.WriteLine(firstname + " " + lastname);
        }
    }

    class Computer
    {
        string model;
        string mark;

        int ram;
        int disksize;
    }

    class ClassRoom
    {
        int size;
        int sittingPlaceCount;
        bool haveProjector;
    }

    class School
    {
        int studentCount;
        int schoolId;
        int classRoomCount;
    }

    class Product
    {
        string barcode;
        decimal price;
        bool isKilo;
        decimal discount;
    }

    class Car
    {
        public Car(string model, string mark, int maxSpeed, int maxHorsePower, int accelaration)
        {
            this.model = model;
            this.mark = mark;
            this.maxSpeed = maxSpeed;
            this.maxHorsePower = maxHorsePower;
            this.accelaration = accelaration;
        }

        private string model;
        private string mark;

        private int maxSpeed;
        private int maxHorsePower;

        private int accelaration;
        private int currentSpeed = 0;

        private int healthPoint = 100;

        private int roadWentInKm = 0;

        public void PrintCarInfo()
        {
            Console.WriteLine($"Car: {model} {mark}\nMax Speed: {maxSpeed}\nMax horsepower: {maxHorsePower}");
        }

        public void Move()
        {
            currentSpeed += accelaration;

            if (currentSpeed > maxSpeed)
            {
                currentSpeed = maxSpeed;
            }

            roadWentInKm += currentSpeed / 60;
        }

        public void SlowDown()
        {
            currentSpeed -= 5 * accelaration;
        }

        public int RoadWent()
        {
            return roadWentInKm;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Object oriented programming

            //int a = 6;
            //Person mahammad = new Person();
            //Person asef = new Person();
            //Person orxan = new Person();

            //Computer computerA = new Computer();

            //inheritence
            //polymorphism
            //abstract
            //encapsulation

            //int a = 6;
            //dot notation

            Person a = new Person("Mahammad", "Agayev");
            //a.Firstname = "Mahammad";
            //a.Lastname = "Agayev";

            //Person b = new Person("Orxan", "Qurbanov");

            //ShowPerson(a);
            //ShowPerson(b);

            //a.Show();
            //b.Show();

            //int i = 6;
            //object o = new object();

            //Console.WriteLine(a.Firstname  + " " + a.Lastname);
            //Console.WriteLine(a.Firstname);

            Car c1 = new Car("CLA", "Mercedes", 298, 200, 15);
            Car c2 = new Car("R8", "Audi", 300, 150, 15);

            Console.WriteLine("Racing cars: ");
            c1.PrintCarInfo();
            c2.PrintCarInfo();

            Random rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int r = rand.Next(1, 4);

                if (r == 1)
                {
                    c1.SlowDown();
                }
                else if (r == 2)
                {
                    c2.SlowDown();
                }

                c1.Move();
                c2.Move();

                Thread.Sleep(5);

                if (i % 2 == 0)
                {
                    Console.Write("\r..");
                }
                else
                {
                    Console.Write("\r....");
                }
            }

            if (c1.RoadWent() > c2.RoadWent())
            {
                Console.WriteLine("C1 won");
            }
            else if (c1.RoadWent() < c2.RoadWent())
            {
                Console.WriteLine("C2 won");
            }
            else
            {
                Console.WriteLine("Photo finish");
            }
        }

        //static void ShowPerson(Person p)
        //{
        //    Console.WriteLine(p.Firstname + " " + p.Lastname);
        //}
    }
}
