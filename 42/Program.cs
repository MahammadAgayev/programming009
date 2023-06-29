using _42.Domain.Entities;
using _42.Inmemroy;
using _42.Repositories.Abstract;
using _42.SqlServer;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _42
{
    abstract class Animal
    {
    }

    interface IMovable
    {
        void Move();
    }

    interface IPayment
    {
        void Transfer(string fromUserId, string toUserId, decimal amount);
    }

    class Bird : Animal, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bird moves");
        }
    }

    class Fish : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Fish swim");
        }
    }

    class Robot : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Robot moves");
        }
    }

    class DollarPayment : IPayment
    {
        public void Transfer(string fromUserId, string toUserId, decimal amount)
        {
            Console.WriteLine($"${amount} succesfully transferred form {fromUserId} to {toUserId}");
        }
    }

    internal class Program
    {
        const string ExitCommand = "/close";
        const string NewWorkerCommand = "/new";
        const string ListWorkersCommand = "/list";
        const string SearchCommand = "/search";
        const string ClearCommand = "/clear";
        const string DeleteCommand = "/delete";
        const string UpdateCommad = "/update";

        static void Main(string[] args)
        {
            //abstraction
            //inheritence, abstract/virtual class, interface

            ////first part
            //IMovable a = new Robot();

            ////second part
            //a.Move();

            //abstract və interface arasındakı fərqlər, (hər birinə aid nümunə yazın və fərqləndirməyə çalışın)

            //IPayment payment = new DollarPayment();

            //payment.Transfer("mahammad", "tesla", 1000);

            //design patterns - qəliblər

            //repository
            //unitofwork
            //singletone
            //factory

            IWorkerRepository repository = CreateSqlRepository();

            while (true)
            {
                Console.Write("Command: ");
                string commandLine = Console.ReadLine();

                // "/search 3"
                // arr = ["/search", "3", "2", "4"]
                // command = arr[0]
                // commandArgs = arr[1..]

                string[] commandParts = commandLine.Split(' ');
                string command = commandParts[0];

                string[] commandArgs = new string[commandParts.Length - 1];
                for (int i = 1; i < commandParts.Length; i++)
                {
                    commandArgs[i - 1] = commandParts[i];
                }

                if (command == ExitCommand)
                {
                    break;
                }

                switch (command)
                {
                    case ClearCommand:
                        Console.Clear();
                        break;
                    case NewWorkerCommand:
                        AddNewWorker(repository);
                        break;
                    case ListWorkersCommand:
                        ListWorkers(repository);
                        break;
                    case SearchCommand:
                        Search(repository, commandArgs);
                        break;
                    case DeleteCommand:
                        Delete(repository, commandArgs);
                        break;
                    case UpdateCommad:
                        Update(repository, commandArgs);
                        break;
                    default:
                        throw new InvalidOperationException("Unkown command");
                }
            }

        }

        static IWorkerRepository CreateSqlRepository()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "programming009_StoreManager";
            builder.IntegratedSecurity = true;

            string connectionString = builder.ConnectionString;


            return new SqlWorkerRepository(connectionString);
        }

        private static void AddNewWorker(IWorkerRepository repository)
        {
            Worker worker = new Worker();

            Console.Write("Name: ");
            worker.Name = Console.ReadLine();

            Console.Write("Surname: ");
            worker.Surname = Console.ReadLine();

            Console.Write("Salary: ");
            worker.Salary = decimal.Parse(Console.ReadLine());

            repository.Add(worker);

            Console.WriteLine("Program inserted new worker to db");
        }


        private static void ListWorkers(IWorkerRepository repository)
        {
            List<Worker> workers = repository.Get();
            Console.WriteLine("ID".PadRight(3) + "\tName".PadRight(20) + "\tSurname".PadRight(20));

            foreach (var item in workers)
            {
                Console.WriteLine($"{item.Id,-3}\t{item.Name,-20}\t{item.Surname,-20}");
            }
        }

        private static void Search(IWorkerRepository repository, string[] args)
        {
            int id = GetId(args);

            Worker w = repository.Get(id);

            Console.WriteLine($"Name: {w.Name}\nSurname: {w.Surname}\nSalary: {w.Salary}");
        }

        private static void Delete(IWorkerRepository repository, string[] args)
        {
            int id = GetId(args);

            repository.Delete(id);
        }

        private static void Update(IWorkerRepository repository, string[] args)
        {
            int id = GetId(args);

            Worker w = repository.Get(id);

            Console.Write($"New Name({w.Name}): ");
            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                name = w.Name;
            }

            Console.Write($"New Surname({w.Surname}): ");
            string surname = Console.ReadLine();

            if (string.IsNullOrEmpty(surname))
            {
                surname = w.Surname;
            }

            Console.Write($"New Salary({w.Salary}): ");
            string salaryText = Console.ReadLine();
            decimal salary = 0;

            if (string.IsNullOrEmpty(salaryText))
            {
                salary = w.Salary;
            }
            else
            {
                salary = decimal.Parse(salaryText);
            }

            repository.Update(w);
        }

        private static int GetId(string[] args)
        {
            int id = 0;

            if (args.Length > 0)
            {
                id = int.Parse(args[0]);
            }
            else
            {
                Console.Write("Id: ");
                id = int.Parse(Console.ReadLine());
            }

            return id;
        }
    }
}
