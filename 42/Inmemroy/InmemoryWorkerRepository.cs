using _42.Domain.Entities;
using _42.Repositories.Abstract;

using System.Collections.Generic;
using System.Linq;

namespace _42.Inmemroy
{
    public class InmemoryWorkerRepository : IWorkerRepository
    {
        private List<Worker> _workers = new List<Worker>();
        private int _counter = 0; 

        public void Add(Worker worker)
        {
            _counter++;

            worker.Id = _counter;
            _workers.Add(worker);
        }

        public void Delete(int workerId)
        {
            _workers.RemoveAll(x => x.Id == workerId);
        }

        public Worker Get(int id)
        {
            return _workers.FirstOrDefault(x => x.Id == id);
        }

        public List<Worker> Get()
        {
            return _workers;
        }

        public void Update(Worker worker)
        {
            Worker w = _workers.FirstOrDefault(x => x.Id == worker.Id);

            if (w == null)
                return;

            w.Name = worker.Name;
            w.Surname = worker.Surname;
            w.Salary = worker.Salary;
        }
    }
}
