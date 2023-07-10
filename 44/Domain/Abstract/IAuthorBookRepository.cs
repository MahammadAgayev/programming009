using _44.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44.Domain.Abstract
{
    public interface IAuthorBookRepository
    {
        void Add(AuthorBook authorBook);
        List<AuthorBook> GetByAuthorId(int id);
        List<AuthorBook> GetByBookId(int id);
    }
}
