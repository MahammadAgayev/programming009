using _45.Domain.Abstract;
using _45.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45.SqlServer
{
    public class SqlAuthorRepository : IAuthorRepository
    {
        private readonly string _connectionString;

        public SqlAuthorRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Author author)
        {
            throw new NotImplementedException();
        }

        public void Delete(int authorId)
        {
            throw new NotImplementedException();
        }

        public Author Get(int id)
        {
            using(SqlConnection connection  = new SqlConnection(_connectionString))
            {
                connection.Open();

                const string query = "select * from Authors where id = @id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == false)
                    return null;

                Author author = new Author
                {
                    Id = (int)reader["Id"],
                    Name = (string)reader["Name"],
                    Surname = (string)reader["Surname"]
                };

                return author;
            }
        }

        public List<Author> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(Author author)
        {
            throw new NotImplementedException();
        }
    }
}
