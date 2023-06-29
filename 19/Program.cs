using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _19
{

    class Person
    {
        public Person(int age, string name, string email)
        {
            this.age = age;
            this.email = email;
            this.name = name;
        }

        //field
        private int age;
        private string name;
        private string email;

        //getter/setter
        //property
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 60 || value <= 6)
                {
                    Console.WriteLine("The person is too young or too old to be in system");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        //auto property
        public string Email { get; set; }
        //public string Email
        //{
        //    get
        //    {
        //        return this.email;
        //    }
        //    set
        //    {
        //        this.email = value;
        //    }
        //}

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Person name cannot be empty");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        //public string GetName()
        //{
        //    return name;
        //}

        //public void SetName(string name)
        //{
        //    this.name = name;
        //}

        //public void SetEmail(string email)
        //{
        //    this.email = email;
        //}

        //public string GetEmail()
        //{
        //    return email;
        //}   
    }

    class Person2
    {
        //auto property
        public string Email { get; set; }
    }

    class Person3
    {
        public string Email { get; set; }

        //public string Email
        //{
        //    get
        //    {
        //        return email;
        //    }
        //    set
        //    {
        //        email = value;
        //    }
        //}
    }

    public class Person4
    {
        public string Name { get; set; }
        public string Surname { get; set; }


        public string Fullname
        {
            get
            {
                return Name.PadRight(10) + "  " + Surname;
            }
        }
    }


    public class Order
    {
        public Order(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Amount { get; set; }

        public string Address { get; set; }

        public int TaxPercentage { get; set; }

        public decimal TotalAmount
        {
            get
            {
                return this.Amount + ((this.Amount * TaxPercentage) / 100);
            }
        }

        public decimal TaxAmount
        {
            get
            {
                return this.TotalAmount - this.Amount;
            }
        }
    }

    public class Astronaut
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IQ { get; set; }
        public double HeightInSantimeter { get; set; }
        public double WeightInKilo { get; set; }
        public int ExperienceYears { get; set; }

        public string Branch { get; set; }
        public bool IsVeteran
        {
            get
            {
                return this.ExperienceYears > 20;
            }
        }

        public void Print()
        {
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("Surname: " + this.Surname);
            Console.WriteLine("Branch: " + this.Branch);
            Console.WriteLine("Veteran: " + this.IsVeteran);
            Console.WriteLine("Height: " + this.HeightInSantimeter);
            Console.WriteLine("Weight: " + this.WeightInKilo);
        }
    }

    class ManatToDollarConverter
    {
        public ManatToDollarConverter(decimal amount)
        {
            this.amount = amount;
        }

        private decimal amount;
        private decimal course = 1.7m;

        public decimal ConvertedAmount
        {
            get
            {
                return amount * course;
            }
        }
    }

    class ManatToEuroConverter
    {
        public ManatToEuroConverter(decimal amount)
        {
            this.amount = amount;
        }

        public decimal amount;

        public decimal ConvertedAmount
        {
            get
            {
                return amount * 2;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person(22, "Mahammad", "mahammad@gmail.com");

            //p.SetEmail("mahammad2@gmail.com");
            //p.SetName("Rauf");

            ////read&write
            //Console.WriteLine(p.GetAge());
            //Console.WriteLine(p.GetName());
            //Console.WriteLine(p.GetEmail());

            //encapsulation
            //p.Age = 65;
            //p.Email = "myemail@test.com";
            //p.Name = "Rauf";

            //Console.WriteLine(p.Age);
            //Console.WriteLine(p.Email);

            //Person4 p1 = new Person4();
            //Person4 p2 = new Person4();
            //Person4 p3 = new Person4();
            //Person4 p4 = new Person4();

            //p1.Name = "Mahammad";
            //p1.Surname = "Agayev";

            //p2.Name = "Teyyub";
            //p2.Surname = "Ismayilov";

            //p3.Name = "Shamil";
            //p3.Surname = "Ismayilov";

            //p4.Name = "Ilkin";
            //p4.Surname = "Sardarov";

            //Console.WriteLine(p1.Fullname);
            //Console.WriteLine(p2.Fullname);
            //Console.WriteLine(p3.Fullname);
            //Console.WriteLine(p4.Fullname);
            //comment: ctrl + k,c
            //uncomment: ctrl + k,u

            //Order o = new Order(100);

            //o.Address = "Iceriseher metrosunun yani";
            //o.TaxPercentage = 2;
            //o.Amount = 156;
            ////Console.WriteLine(o.Amount + ((o.Amount * o.TaxPercentage) / 100));

            //Console.WriteLine("Original amount: ".PadRight(25) + o.Amount);
            //Console.WriteLine("Tax amount: ".PadRight(25) + o.TaxAmount);
            //Console.WriteLine("Total amount: ".PadRight(25) + o.TotalAmount);

            //Astronaut a = new Astronaut();

            //a.Name = "Yuri";
            //a.Surname = "Qaqarin";
            //a.IQ = 110;
            //a.ExperienceYears = 15;
            //a.HeightInSantimeter = 185;
            //a.WeightInKilo = 80;
            //a.Branch = "Pilot";

            //a.Print();


            Console.Write("Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.Write("Convertion Type: ");
            string convertionType = Console.ReadLine();

            switch (convertionType)
            {
                case "manattodollar":
                    ManatToDollarConverter conv = new ManatToDollarConverter(amount);
                    Console.WriteLine(conv.ConvertedAmount);

                   break;
                case "manattoeuro":
                    ManatToEuroConverter convEuro = new ManatToEuroConverter(amount);
                    Console.WriteLine(convEuro.ConvertedAmount);

                        break;
            }

            //listler
            int[] arr = new int[10];
            /*
             * 
             */
        }
    }
}
