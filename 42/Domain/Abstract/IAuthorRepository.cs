using _42.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.Domain.Abstract
{
    public interface IAuthorRepository
    {
        void Add(Author author);
        void Update(Author author);
        Author Get(int id);
        List<Author> Get();
        void Delete(int authorId);
    }
}
