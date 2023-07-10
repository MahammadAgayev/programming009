using _45.Domain.Abstract;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.SqlServer
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private readonly string _connectionString;

        private SqlContext _context;

        public SqlUnitOfWork(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IAuthorRepository AuthorRepository => new SqlAuthorRepository(_connectionString);

        public IBookRepository BookRepository => new SqlBookRepository(_connectionString, _context);

        public IAuthorBookRepository AuthorBookRepository => new SqlAuthorBookRepository(_connectionString, _context);


        public void Commit()
        {
            _context.Transaction.Commit();
        }

        public void CreateTransaction()
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            sqlConnection.Open();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

            _context = new SqlContext(sqlConnection, sqlTransaction);
        }

        public void Dispose()
        {
            _context.Connection.Dispose();
        }

        public void Rollback()
        {
            _context.Transaction.Rollback();
        }
    }
}
