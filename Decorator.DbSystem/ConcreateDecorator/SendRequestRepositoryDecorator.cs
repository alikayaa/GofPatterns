using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DbSystem
{
    public class SendRequestRepositoryDecorator<T>:DecoratorRepository<T>
    {
        public SendRequestRepositoryDecorator(IRepository<T> repository)
            :base(repository)
        {

        }
        public override void Delete(T value)
        {
            base.Delete(value);
            Console.WriteLine("- '" + typeof(T).FullName + "' adlı entity için delete yapıldıktan sonra CRM veritabanındaki silinme için web servisine istek atıldı.");
        }

        public override void Update(T value)
        {
            base.Update(value);
            Console.WriteLine("- '"+typeof(T).FullName+"' adlı entity için update yapıldıktan sonra CRM veritabanındaki güncelleme için web servisine istek atıldı.");
        }
    }
}
