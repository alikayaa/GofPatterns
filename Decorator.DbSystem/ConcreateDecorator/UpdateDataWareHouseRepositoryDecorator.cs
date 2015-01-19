using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DbSystem
{
    public class UpdateDataWareHouseRepositoryDecorator<T>:DecoratorRepository<T>
    {
        public UpdateDataWareHouseRepositoryDecorator(IRepository<T> repository)
            :base(repository)
        {

        }
        public override void Update(T value)
        {
            base.Update(value);
            Console.WriteLine(" -"+typeof(T).FullName+"' adlı entity için data ware house da güncelleme yapıldı.");
        }
    }
}
