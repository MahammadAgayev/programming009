using _42.Domain.Entities;
using _42.Repositories.Abstract;

using System.Collections.Generic;
using System.Data.SqlClient;

namespace _42.SqlServer
{
    public class SqlWorkerRepository : IWorkerRepository
    {
        private readonly string _connectionString;

        public SqlWorkerRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(Worker worker)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "insert into workers(name, surname, salary) values(@name, @surname, @salary)";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("name", worker.Name);
                cmd.Parameters.AddWithValue("surname", worker.Surname);
                cmd.Parameters.AddWithValue("salary", worker.Salary);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int workerId)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "delete from workers where id = @id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("id", workerId);

                cmd.ExecuteNonQuery();
            }
        }

        public Worker Get(int id)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "Select * from workers where id = @id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == false)
                    return null;

                Worker v = ReadFromReader(reader);

                return v;
            }
        }

        public List<Worker> Get()
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "select * from workers";

                SqlCommand cmd = new SqlCommand(query, connection);

                List<Worker> workers = new List<Worker>();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Worker v = ReadFromReader(reader);

                    workers.Add(v);
                }

                return workers;
            }
        }

        public void Update(Worker worker)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                string query = "update workers set name=@name, surname=@surname, salary=@salary where id = @id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("id", worker.Id);
                cmd.Parameters.AddWithValue("name", worker.Name);
                cmd.Parameters.AddWithValue("surname", worker.Surname);
                cmd.Parameters.AddWithValue("salary", worker.Salary);

                cmd.ExecuteNonQuery();
            }
        }


        private Worker ReadFromReader(SqlDataReader reader)
        {
            Worker v = new Worker
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"],
                Surname = (string)reader["Surname"],
                Salary = (decimal)reader["Salary"]
            };

            return v;
        }
    }
}
