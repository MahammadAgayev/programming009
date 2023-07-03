using _43.Domain.Abstract;
using _43.Domain.Entities;
using _43.SqlServer;

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _43
{
    internal class Program
    {
        const string NewBookCommand = "/new";

        static void Main(string[] args)
        {
            //unit of work

            string connectionString = GetConnectionString();

            using (IUnitOfWork unitOfWork = new SqlUnitOfWork(connectionString))
            {
                Console.Write("command: ");
                string command = Console.ReadLine();

                if (command != NewBookCommand)
                {
                    return;
                }

                Book b = new Book();

                Console.Write("Name: ");
                b.Name = Console.ReadLine();

                Console.Write("Page number: ");
                b.PageNumber = int.Parse(Console.ReadLine());

                Console.Write("Author Id: ");
                int id = int.Parse(Console.ReadLine());

                unitOfWork.CreateTransaction();

                Author author = unitOfWork.AuthorRepository.Get(id);

                if (author == null)
                {
                    Console.WriteLine("Author not found");
                    return;
                }

                unitOfWork.BookRepository.Add(b);

                AuthorBook ab = new AuthorBook();
                ab.Book = b;
                ab.Author = author;

                unitOfWork.AuthorBookRepository.Add(ab);

                unitOfWork.Commit();
            }
        }

        static string GetConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = ".";
            builder.InitialCatalog = "programming009";
            builder.IntegratedSecurity = true;

            string connectionString = builder.ConnectionString;


            return connectionString;
        }
    }
}
