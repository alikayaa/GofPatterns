using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            // Genel Müdürlüğümüz
            CompositeDealers genelMudurluk = new CompositeDealers();
            // Genel Müdürlüğe Bağlı Müdürlüklerimiz
            CompositeDealers icAnadoluMudurlugu = new CompositeDealers();
            // Müdürlüğe bağlı bölgelerimiz
            CompositeDealers ankaraBolgesi = new CompositeDealers();
            CompositeDealers sivasBolgesi = new CompositeDealers();
            // Bölgelere bağlı bayiilerimiz
            CompositeDealers ankara1 = new CompositeDealers();
            CompositeDealers ankara2 = new CompositeDealers();
            CompositeDealers sivas1 = new CompositeDealers();

            // Bayii çalışanlarımız
            ankara1.Add(new WorkingPerson());
            ankara1.Add(new WorkingPerson());
            ankara1.Add(new WorkingPerson());
            ankara1.Add(new WorkingPerson());
            ankara1.Add(new WorkingPerson());

            ankara2.Add(new WorkingPerson());

            
            ankaraBolgesi.Add(ankara1);
            ankaraBolgesi.Add(ankara2);

            sivas1.Add(new WorkingPerson());

            sivasBolgesi.Add(sivas1);

            icAnadoluMudurlugu.Add(ankaraBolgesi);
            icAnadoluMudurlugu.Add(sivasBolgesi);

            genelMudurluk.Add(icAnadoluMudurlugu);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Ankara 1 Bayi Maliyet : " + ankara1.GetCost().ToString());
            Console.WriteLine("Ankara 2 Bayi Maliyet : " + ankara2.GetCost().ToString());
            Console.WriteLine("Ankara Bölge Maliyet : " + ankaraBolgesi.GetCost().ToString());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Sivas 1 Bayi Maliyet : " + sivas1.GetCost().ToString());
            Console.WriteLine("Sivas Bölge Maliyet : " + sivasBolgesi.GetCost().ToString());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("İç Anadolu Müdürlüğü Maliyet : " + icAnadoluMudurlugu.GetCost().ToString());
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Toplam Maliyet : " + genelMudurluk.GetCost().ToString());
            Console.WriteLine("------------------------------------------------");


            Console.Read();


        }
    }
}
