using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Datetime
{
    public class WeekendDatetimeIterator:IIterator
    {
        private DatetimeAggregate datetimeRange;
        private DateTime currentDay;

        public WeekendDatetimeIterator(DatetimeAggregate datetimeList)
        {
            this.datetimeRange = datetimeList;
            this.currentDay = datetimeList.startDate;
        }

        public DateTime Current()
        {
            return currentDay;
        }

        public bool ReadNext()
        {
            if (currentDay.DayOfWeek == DayOfWeek.Sunday || currentDay.DayOfWeek == DayOfWeek.Saturday)
            {
                int daysCount =currentDay.DayOfWeek == DayOfWeek.Saturday ? 1 : 6;
                currentDay=currentDay.AddDays(daysCount);
            }
            else
            {
                int dayno = (int)currentDay.DayOfWeek;
                int daysToWeekend = 6 - dayno;
                currentDay = currentDay.AddDays(daysToWeekend);
                return true; 
            }
            return currentDay < datetimeRange.endDate;
        }
    }
}
