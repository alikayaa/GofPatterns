using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sorting
{
    public class BubbleSortStrategy:ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            for (int index = 0; index < list.Count() - 1; index++)
            {
                for (int index2 = 1; index2 < list.Count() - index; index2++)
                {
                    if (list[index2] < list[index2 - 1])
                    {
                        int temp = list[index2 - 1];
                        list[index2 - 1] = list[index2];
                        list[index2] = temp;
                    }
                }
            }
            return list;
        }
    }
}
