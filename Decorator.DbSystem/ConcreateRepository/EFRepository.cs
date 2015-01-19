using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.DbSystem
{
    public class EFRepository<T> :IRepository<T> where T : class
    {
        private Context<T> context;
        public EFRepository()
        {
            context = new Context<T>();
            //TODO
            //bu constructer ın bağımlılığı azaltmak için 
            //context def soyutlanarak
            //buraya paramtre olarak gönderilebilir.
        }

        public T Get(int id)
        {
            return context.Get(id);
        }

        public void Add(T value)
        {
            context.Add(value);
        }

        public void Update(T value)
        {
            context.Update(value);
        }

        public void Delete(T value)
        {
            context.Delete(value);
        }
    }
}
