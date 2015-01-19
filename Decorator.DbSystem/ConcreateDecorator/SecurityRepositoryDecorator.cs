using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DbSystem
{
    public class SecurityRepositoryDecorator<T>:DecoratorRepository<T>
    {
        public SecurityRepositoryDecorator(IRepository<T> repository)
            :base(repository)
        {

        }

        public override T Get(int id)
        {
            Console.WriteLine("- '"+typeof(T).FullName+"' adlı entity için security controlü yapıldı.");
            return base.Get(id);
        }
    }
}
