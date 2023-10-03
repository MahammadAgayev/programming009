using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _60
{
    interface ISwimmable
    {
        void Swim();
    }
    
    interface IFlyable
    {
        void Fly();
    }

    interface IRunnable
    {
        void Run();
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }

    class Fish : Animal, ISwimmable
    {
        public void Swim()
        {
            Console.WriteLine("swimming...");
        }
    }

    class Dog : Animal, IRunnable
    {
        public void Run()
        {
            Console.WriteLine("runnning.....");
        }
    }

    class Lion : Animal, IRunnable
    {
        public void Run() 
        {
            Console.WriteLine("running......");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //as is

            List<Animal> animals = new List<Animal>
            {
                new Dog(),
                new Fish(),
                new Dog(),
                new Lion()
            };

            foreach (Animal animal in animals)
            {
                if (animal is IRunnable runnable)//is + as
                {
                    //IRunnable dog = animal as IRunnable;

                    runnable.Run();
                }
            }


            List<int> ints = new List<int>()
            {
                1,2,3,4,5
            };

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}
