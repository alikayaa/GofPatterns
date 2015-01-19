using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DbSystem
{
    public class LoggingRepositoryDecorator<T>:DecoratorRepository<T>
    {
        public LoggingRepositoryDecorator(IRepository<T> repository)
            :base(repository)
        {

        }

        public override void Add(T value)
        {
            base.Add(value);
            Console.WriteLine("- '" + typeof(T).FullName + "' adlı entity için add log atıldı.");
        }

        public override void Update(T value)
        {
            base.Update(value);
            Console.WriteLine("- '"+typeof(T).FullName+"' adlı entity için update log atıldı.");
        }

        public override void Delete(T value)
        {
            base.Delete(value);
            Console.WriteLine("- '" + typeof(T).FullName + "' adlı entity için delete log atıldı.");
        }
    }
}
