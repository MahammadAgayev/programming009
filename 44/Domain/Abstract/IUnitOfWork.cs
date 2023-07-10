using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Domain.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository AuthorRepository { get; }
        IBookRepository BookRepository { get; }
        IAuthorBookRepository AuthorBookRepository { get; }

        void CreateTransaction();
        void Commit();
        void Rollback();
    }
}
