using Microsoft.SqlServer.Server;

using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _50
{
    abstract class Animal
    {
        public abstract void Fly();
    }

    class Eagle : Animal
    {
        public override void Fly()
        {
            Console.WriteLine("flying...");
        }
    }

    class Dog : Animal
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }

    //God class/service
    class CreditProvision
    {

    }

    class Worker
    {

        public void DoPaperWork()
        {
        }

        public void MakeTea()
        {

        }

    }

    class Exchange
    {
        public decimal ConvertUsdToAzn(decimal usd)
        {
            return usd * 1.8m;
        }

        public decimal ConvertEuroToAzn(decimal euro)
        {
            return euro * 2m;
        }
    }


    interface IExchange
    {
        decimal Convert(decimal amount);
    }

    public class UsdExchange : IExchange
    {
        public decimal Convert(decimal amount)
        {
            return amount * 1.7m;
        }
    }

    public class EuroExchange : IExchange
    {
        public decimal Convert(decimal amount)
        {
            return amount * 1.8m;
        }
    }

    public interface IPrinter
    {
        void Print();
    }

    public interface IColorPrinter
    {
        void PrintWithColors();
    }

    public interface INetworkPrinter
    {
        void RemotePrint();
    }

    public class SimplePrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("I have print feature, printing...");
        }
    }

    public class ComplexPrinter : IPrinter, IColorPrinter
    {
        public void Print()
        {
            Console.WriteLine("I have print feature, printing...");
        }

        public void PrintWithColors()
        {
            Console.WriteLine("I have print with colors feature, printing...");
        }
    }

    class UnitOfWork :  IUnitOfWork
    {
        public void AddUser(string username, string passwordHash, string email)
        {

        }  
    }

    class TestUnitOfWork : IUnitOfWork
    {
        public void AddUser(string username, string passwordHash, string email)
        {
            throw new NotImplementedException();
        }
    }

    interface IUnitOfWork
    {
        void AddUser(string username, string passwordHash, string email);
    }


    class RegisterCommand
    {
        private IUnitOfWork unitOfWork;

        //Dependency injection
        public RegisterCommand(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Execute(string username, string email, string password)
        {
            string passwordHash = hash(password);

            this.unitOfWork.AddUser(username, passwordHash, email);
        }

        private string hash(string password)
        {
            return "askdjhfghkjasgdfgjaksgdhjf";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //SOLID principles

            /*
             * S -> Single Reponsibility principle
             * O -> Open/Closed principle, close to changes, open to enlargement
             * L -> Liskov's substitution principle
             * I -> Interface segregation principle
             * D -> Dependency inversion
             */


            //Exchange exchange = new Exchange();

            //decimal result = exchange.ConvertUsdToAzn(100);

            //Console.WriteLine(result);

            IExchange exchange = new EuroExchange();
            decimal result = exchange.Convert(100);

            Console.WriteLine(result);

            RegisterCommand cmd = new RegisterCommand(new UnitOfWork());
        }
    }
}
