using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Sorting
{
    public class InsertionSortStrategy:ISortingStrategy
    {
        public List<int> Sort(List<int> list)
        {
            int temp, inserted;

            for (int index = 1; index < list.Count; index++)
            {
                inserted = list[index]; //listenin ilk elemanının değerini al
                temp = index; //listenin ilk elemanının indexini sakla

                while (temp > 0 && list[temp - 1] > inserted)
                {
                    list[temp] = list[temp - 1];
                    temp--; 
                }
                list[temp] = inserted; //Yeri değiştirilen elemanı listeye ekle..
            }
            return list;
        }
    }
}
