using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Kredi
{
    public abstract class CreditRequestBase
    {
        public bool CreditConfirmed;//bu veri bizim nesneler arasında taşımak isteyeceğimiz veri
        //birden fazla da olabilirdi. Genelde öyle olur

        protected CreditRequestBase nextOperation;

        public void setNext(CreditRequestBase operation)
        {
            this.nextOperation = operation;
        }

        public void Execute(Customer c)
        {
            ExecuteProcess(c);
            if (this.nextOperation != null)
            {
                this.nextOperation.CreditConfirmed = this.CreditConfirmed;//her seferinde bir sonrakine aktarılır.
                this.nextOperation.Execute(c);//bir sonraki çalıştırılır.
            }
        }

        public abstract void ExecuteProcess(Customer customer);
    }
}
