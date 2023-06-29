using _42.Domain.Abstract;
using _42.Domain.Entities;

using System.Collections.Generic;
using System.Data.SqlClient;

namespace _42.SqlServer
{
    public class SqlBookRepository : IBookRepository
    {
        private readonly string _connectionString;

        public SqlBookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Book book)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                const string query = "insert into Books(Name, PageNumber) values(@Name, @PageNumber)";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("Name", book.Name);
                cmd.Parameters.AddWithValue("PageNumber", book.PageNumber);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int bookId)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                const string query = "delete from books where id = @id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("id", bookId);

                cmd.ExecuteNonQuery();
            }
        }

        public Book Get(int id)
        {
            using(SqlConnection connection = new SqlConnection())
            {
                connection.Open();

                const string query = "select * from books where id = @id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == false)
                    return null;

                return ReadFromReader(reader);
            }
        }

        public List<Book> Get()
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.Open();

                const string query = "select * from books";

                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                List<Book> books = new List<Book>();

                while(reader.Read())
                {
                    Book b = ReadFromReader(reader);

                    books.Add(b);
                }

                return books;
            }
        }

        public void Update(Book book)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "update books set name = @name, pagenumber = @pagenumber where id = @id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("id", book.Id);
                cmd.Parameters.AddWithValue("name", book.Name);
                cmd.Parameters.AddWithValue("pagenumber", book.PageNumber);

                cmd.ExecuteNonQuery();
            }
        }


        private Book ReadFromReader(SqlDataReader reader)
        {
            return new Book
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                PageNumber = (int)reader["PageNumber"]
            };
        }
    }
}
