using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.GSMOperator
{
    public interface IObserver
    {
        void notify(Customer customer);
    }
}
