using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Sorting;

namespace Strategy.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startingTime, endTime;
            SortingContext sortingContext;
            List<int> sortedList = new List<int>();
            List<int> list = new List<int>
            {
                45,6,87,2,43,6,87,23,54,88,25,13,15,97,34,42,12,52,88,61,40,20,10,50
            };

            //BubbleSort
            sortingContext = new SortingContext(new BubbleSortStrategy());
            sortedList = new List<int>();
            startingTime = DateTime.Now;
            sortedList=sortingContext.Sort(list);
            endTime = DateTime.Now;
            Console.WriteLine("BubbleSort");
            Helper.WriteConsole(sortedList);
            Console.WriteLine("Çalışma Zamanı: "+(endTime.Millisecond-startingTime.Millisecond).ToString()+" ms");

            //QuickSort
            sortingContext = new SortingContext(new QuickSortStrategy());
            
            startingTime = DateTime.Now;
            sortedList = sortingContext.Sort(list);
            endTime = DateTime.Now;
            Console.WriteLine("QuickSort");
            Helper.WriteConsole(sortedList);
            Console.WriteLine("Çalışma Zamanı: " + (endTime.Millisecond - startingTime.Millisecond).ToString() + " ms");

            //InsertionSort
            sortingContext = new SortingContext(new InsertionSortStrategy());

            startingTime = DateTime.Now;
            sortedList = sortingContext.Sort(list);
            endTime = DateTime.Now;
            Console.WriteLine("InsertionSort");
            Helper.WriteConsole(sortedList);
            Console.WriteLine("Çalışma Zamanı: " + (endTime.Millisecond - startingTime.Millisecond).ToString() + " ms");

            Console.ReadLine();

        }
    }
}
