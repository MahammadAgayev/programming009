using _44.Domain.Abstract;
using _44.Options;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _44
{

    class Person
    {
        private Person()
        {
        }

        private static Person _person;

        public static Person Get()
        {
            if(_person == null)
            {
                _person = new Person();
            }

            return _person;
        }

        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //factory pattern
            //singletone pattern

            DbOptions options = new DbOptions
            {
                DatabaseName = "programming009",
                Hostname = ".",
                WindowsAuthentication = true,
                DbType = DbOptions.OracleType
            };

            //IUnitOfWork db = DbFactory.Create(options);

            //singletone
            //1 classdan yalnız 1 obyekt yaradılsın
            //cache
            //Person p = new Person();
            //Person p1 = new Person();
            //Person p2 = new Person();

            //Person p = new Person()
            //{
            //    Name = "Mahammad"
            //};

            //Person p1 = new Person
            //{
            //    Name = "Ilkin",
            //};

            //Person p2 = new Person
            //{
            //    Name = "Murad"
            //};

            //Console.WriteLine(Person.CallCount);

            //Person p = Person.Get();
            //Person p1 = Person.Get();

            //p.Name = "Mahammad";
            //Console.WriteLine(p1.Name);

            //thread safe singletone pattern/parallel programming

            //Bridge/Facade/Decorator
        }
    }
}
