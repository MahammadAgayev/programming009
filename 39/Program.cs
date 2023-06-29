using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _39
{
    class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Salary { get; set; }
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
            //string connectionString = "Data Source=.;Initial Catalog=programming009_StoreManager;Integrated Security=true";

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "programming009_StoreManager";
            builder.IntegratedSecurity = true;

            string connectionString = builder.ConnectionString;

            //CRUD - Create, Read, Update, Delete
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("connected");

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
                            AddNewWorker(connection);
                            break;
                        case ListWorkersCommand:
                            ListWorkers(connection);
                            break;
                        case SearchCommand:
                            Search(connection, commandArgs);
                            break;
                        case DeleteCommand:
                            Delete(connection, commandArgs);
                            break;
                        case UpdateCommad:
                            Update(connection, commandArgs);
                            break;
                        default:
                            throw new InvalidOperationException("Unkown command");
                    }
                }
            }
        }

        private static void AddNewWorker(SqlConnection connection)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            string query = @"
            insert into Workers values(@name, @surname, @salary)";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("surname", surname);
                cmd.Parameters.AddWithValue("salary", salary);

                cmd.ExecuteNonQuery();
            }

            Console.WriteLine("Program inserted new worker to db");
        }


        private static void ListWorkers(SqlConnection connection)
        {
            string query = "select * from workers";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                Console.WriteLine("ID".PadRight(3) + "\tName".PadRight(20) + "\tSurname".PadRight(20));
                while (reader.Read())
                {
                    int id = (int)reader["Id"];
                    string name = (string)reader["Name"];
                    string surname = (string)reader["Surname"];

                    Console.WriteLine($"{id,-3}\t{name,-20}\t{surname,-20}");
                }
            }

        }

        private static void Search(SqlConnection connection, string[] args)
        {
            int id = GetId(args);

            Worker w = GetWorker(connection, id);

            Console.WriteLine($"Name: {w.Name}\nSurname: {w.Surname}\nSalary: {w.Salary}");
        }

        private static Worker GetWorker(SqlConnection connection, int id)
        {
            string query = "select * from workers where id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id", id);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = (string)reader["Name"];
                        string surname = (string)reader["Surname"];
                        decimal salary = (decimal)reader["Salary"];

                        Worker w = new Worker();
                        w.Name = name;
                        w.Surname = surname;
                        w.Salary = salary;

                        return w;
                    }
                }

                return null;
            }
        }

        private static void Delete(SqlConnection connection, string[] args)
        {
            int id = GetId(args);

            string query = "delete from Workers where id = @id";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();
            }
        }

        private static void Update(SqlConnection connection, string[] args)
        {
            int id = GetId(args);

            Worker w = GetWorker(connection, id);

            string query = @"Update workers set name = @name, surname = @surname, salary = @salary 
                           where id = @id";

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

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.Parameters.AddWithValue("surname", surname);
                cmd.Parameters.AddWithValue("salary", salary);

                cmd.ExecuteNonQuery();
            }
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
