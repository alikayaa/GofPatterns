using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DbSystem
{
    public class DecoratorRepository<T>:IRepository<T>
    {
        private IRepository<T> repository;

        public DecoratorRepository(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public virtual T Get(int id)
        {
            return repository.Get(id);
        }

        public virtual void Add(T value)
        {
            repository.Add(value);
        }

        public virtual void Update(T value)
        {
            repository.Update(value);
        }

        public virtual void Delete(T value)
        {
            repository.Delete(value);
        }
    }
}
