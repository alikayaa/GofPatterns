using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Bayi,Bölgelik,Müdürlük,Genel Müdürlük Yerine Geçecek Composite Sınıf
    public class CompositeDealers:Worker
    {
        List<Worker> workerList;
        public CompositeDealers()
        {
            // Çalışan Listesi
            workerList = new List<Worker>();
        }

        public void Add(Worker person)
        {
            workerList.Add(person);
        }
        public override int GetCost()
        {
            int result = 0;
            foreach (Worker worker in workerList)
            {
                result += worker.GetCost();
            }

            return result;
        }
    }
}
