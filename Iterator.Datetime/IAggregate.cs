using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Datetime
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
