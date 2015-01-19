using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Datetime;

namespace Iterator.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            DatetimeAggregate dateTimeRange = new DatetimeAggregate();
            dateTimeRange.startDate = new DateTime(2014, 05, 14);
            dateTimeRange.endDate = new DateTime(2014, 10, 14);

            IIterator iterator = dateTimeRange.CreateIterator();
            while (iterator.ReadNext())
            {
                Console.WriteLine(iterator.Current().ToString("yyyy.MM.dd"));
            }

            Console.ReadLine();
        }
    }
}
