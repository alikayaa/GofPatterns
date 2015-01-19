using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DbSystem
{
    public interface IRepository<T>
    {
        T Get(int id);
        void Add(T value);
        void Update(T value);
        void Delete(T value);
    }
}
