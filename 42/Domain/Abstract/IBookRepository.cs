using _42.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Domain.Abstract
{
    public interface IBookRepository
    {
        void Add(Book book);
        void Update(Book book);
        Book Get(int id);
        List<Book> Get();
        void Delete(int bookId);
    }
}
