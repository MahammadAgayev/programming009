using _44.Domain.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Oracle
{
    public class OracleUnitOfWork : IUnitOfWork
    {
        public IAuthorRepository AuthorRepository => throw new NotImplementedException();

        public IBookRepository BookRepository => throw new NotImplementedException();

        public IAuthorBookRepository AuthorBookRepository => throw new NotImplementedException();

        public void Commit()
        {
            throw new NotImplementedException();
        }

        public void CreateTransaction()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            throw new NotImplementedException();
        }
    }
}
