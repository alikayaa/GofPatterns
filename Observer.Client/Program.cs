using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Observer.GSMOperator;

namespace Observer.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer musteri = new Customer();
            musteri.KullaniciAdi = "Engin Bulut";
            musteri.TelefonNo = "1234567890";
            musteri.YeniGozlemciEkle(new MakeCampaignObserver());
            musteri.YeniGozlemciEkle(new SendFreeCreditObserver());

            //Thread.Sleep(5);

            //musteri.KontorYukle();


            Console.ReadLine();
        }
    }
}
