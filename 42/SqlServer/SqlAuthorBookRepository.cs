﻿using _42.Domain.Abstract;
using _42.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace _42.SqlServer
{
    public class SqlAuthorBookRepository : IAuthorBookRepository
    {
        private readonly string _connectionString;

        public SqlAuthorBookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(AuthorBook authorBook)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                const string query = "insert into AuthorBooks(AuthorId, BookId) values(@AuthorId, @BookId)";
                
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("AuthorId", authorBook.Author.Id);
                cmd.Parameters.AddWithValue("BookId", authorBook.Book.Id);

                cmd.ExecuteNonQuery();
            }
        }

        public List<AuthorBook> GetByAuthorId(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                const string query = @"
select 
ab.Id, ab.BookId, b.Name as BookName, b.PageNumber as BookPageNumber,
ab.AuthorId, a.Name as AuthorName, a.Surname as AuthorSurname
from AuthorBooks ab
join Authors a on a.Id = ab.AuthorId
join Books b on b.Id = ab.BookId
where ab.AuthorId = @Id";

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                List<AuthorBook> authorBooks = new List<AuthorBook>();

                while (reader.Read())
                {
                    AuthorBook a = ReadFromReader(reader);

                    authorBooks.Add(a);
                }

                return authorBooks;
            }
        }

        public List<AuthorBook> GetByBookId(int id)
        {
            throw new NotImplementedException();
        }


        private AuthorBook ReadFromReader(SqlDataReader reader)
        {
            return new AuthorBook
            {
                Id = (int)reader["Id"],
                Book = new Book
                {
                    Id = (int)reader["BookId"],
                    Name = (string)reader["BookName"],
                    PageNumber = (int)reader["BookPageNumber"]
                },
                Author = new Author
                {
                    Name = (string)reader["AuthorName"],
                    Surname = (string)reader["AuthorSurname"],
                    Id = (int)reader["AuthorId"],
                }
            };
        }
    }
}
