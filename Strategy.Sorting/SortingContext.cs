using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sorting
{
    public class SortingContext
    {
        private ISortingStrategy sortingStrategy;
        public SortingContext(ISortingStrategy sortingStrategy)
        {
            this.sortingStrategy = sortingStrategy;
        }

        public List<int> Sort(List<int> list)
        {
            return sortingStrategy.Sort(list);
        }

    }
}
