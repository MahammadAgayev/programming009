using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _41
{
    //abstract class Animal
    //{
    //    public abstract void MakeSound();
    //}

    //class Bird : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Bird sound");
    //    }
    //}

    //class Dog : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Dog sound");
    //    }
    //}

    //class Snake : Animal
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine("Snake sound");
    //    }
    //}

    //abstract class MoneyConverter
    //{
    //    public MoneyConverter(decimal amount)
    //    {
    //        Amount = amount;
    //    }

    //    public decimal Amount { get; set; }

    //    protected abstract decimal ExchangeRate { get; }

    //    public virtual decimal Convert()
    //    {
    //        return Amount * ExchangeRate;
    //    }
    //}

    //sealed class AznToUsdConverter : MoneyConverter
    //{
    //    public AznToUsdConverter(decimal amount) : base(amount) { }

    //    protected override decimal ExchangeRate => 0.6m;
    //}

    //sealed class UsdToAznConverter : MoneyConverter
    //{
    //    public UsdToAznConverter(decimal amount) : base(amount) { }

    //    protected override decimal ExchangeRate => 1.7m;
    //}

    //sealed class AznToEuroConverter : MoneyConverter
    //{
    //    public AznToEuroConverter(decimal amount) : base(amount)
    //    {
    //    }

    //    protected override decimal ExchangeRate => 1.98m;
    //}

    //not workin because AznToEuroConverter is sealed
    //class FakeAznToUsdConverter : AznToEuroConverter
    //{

    //}

    abstract class Shape
    {
        public abstract void RequireParameters();
        public abstract double CalculateArea();
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override void RequireParameters()
        {
            Console.Write("Width: ");
            Width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            Height = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public override void RequireParameters()
        {
            Console.Write("A: ");
            A = double.Parse(Console.ReadLine());


            Console.Write("B: ");
            B = double.Parse(Console.ReadLine());


            Console.Write("C: ");
            C = double.Parse(Console.ReadLine());
        }

        public override double CalculateArea()
        {
            //heron formula
            double p = (A + B + C) / 2;

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal l = new Animal();

            ////#1
            //Animal a = new Dog();
            //Animal b = new Bird();
            //Snake s = new Snake();

            //a.MakeSound();
            //b.MakeSound();
            //s.MakeSound();

            //#2
            //Animal[] animals = { a, b, s};
            //foreach (var item in animals)
            //{
            //    item.MakeSound();
            //}

            //Console.WriteLine("Amount: ");
            //decimal amount = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("Conversion: ");
            //string conversion = Console.ReadLine();

            //MoneyConverter converter = null;

            //switch (conversion)
            //{
            //    case "ussdtoazn":
            //        converter = new UsdToAznConverter(amount);
            //        break;
            //    case "azntoussd":
            //        converter = new AznToUsdConverter(amount);
            //        break;
            //    case "azntoeuro":
            //        converter = new AznToUsdConverter(amount);
            //        break;
            //}

            //decimal convertedAmount = converter.Convert();

            //Console.WriteLine(convertedAmount);

             ;

            Console.WriteLine("Shape: ");
            string shapeType = Console.ReadLine();

            switch (shapeType)
            {
                case "rectangle":
                    shape = new Rectangle();
                    break;
                case "triangle":
                    shape = new Triangle();
                    break;
            }

            shape.RequireParameters();
            double area = shape.CalculateArea();

            Console.WriteLine(area);
        }
    }
}
