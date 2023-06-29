using _42.Domain.Entities;

using System.Collections.Generic;

namespace _42.Repositories.Abstract
{
    public interface IWorkerRepository
    {
        void Add(Worker worker);
        void Update(Worker worker);

        Worker Get(int id);
        List<Worker> Get();

        void Delete(int workerId);
    }
}
