using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sorting
{
    public class QuickSortStrategy:ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            QuickSort(ref list, 0, list.Count - 1);
            return list;
        }

        private void QuickSort(ref List<int> list,int startIndex,int endIndex)
        {
            int index;
            if (startIndex < endIndex)
            {
                index = GetPartitionIndex(list, startIndex, endIndex);
                QuickSort(ref list, startIndex, index - 1);
                QuickSort(ref list, index + 1, endIndex);
            }
        }

        private int GetPartitionIndex(List<int> list, int startIndex, int endIndex)
        {
            int temp;
            int lastValue = list[endIndex];
            int index = startIndex - 1;

            for (int j = startIndex; j <= endIndex - 1; j++)
            {
                if (list[j] <= lastValue)
                {
                    index++;
                    temp = list[index];
                    list[index] = list[j];
                    list[j] = temp;
                }
            }
            temp = list[index + 1];
            list[index + 1] = list[endIndex];
            list[endIndex] = temp;
            return index + 1;
        }

    }
}
