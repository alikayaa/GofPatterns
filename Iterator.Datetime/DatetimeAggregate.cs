using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Datetime
{
    public class DatetimeAggregate:IAggregate
    {
        public DateTime startDate;
        public DateTime endDate;
        
        public IIterator CreateIterator()
        {
            return new WeekendDatetimeIterator(this);
        }
    }
}
