using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Observer.GSMOperator
{
    public class Customer
    {
        private Timer timer = new Timer(TimeSpan.FromSeconds(1).TotalMilliseconds);

        #region properties

        public string TelefonNo { get; set; }
        public string KullaniciAdi { get; set; }
        public DateTime SonKontorYuklemeTarihi { get; set; }

        public List<IObserver> observerListesi;

        #endregion

        #region Yapıcı Metod

        public Customer()
        {
            observerListesi = new List<IObserver>();
            SonKontorYuklemeTarihi = DateTime.Now;
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        #endregion

        public void YeniGozlemciEkle(IObserver observer)
        {
            if(!observerListesi.Contains(observer))
                observerListesi.Add(observer);
        }

        public void GozlemciCikart(IObserver observer)
        {
            if(observerListesi.Contains(observer))
                observerListesi.Remove(observer);
        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //kontör yükleyeli 5 ay olmuşsa gibi algılayabiliriz.
            if (DateTime.Now.Second - SonKontorYuklemeTarihi.Second > 5)
            {
                SonKontorYuklemeTarihi = DateTime.Now;
                ObserverlaraHaberVer();
            }
        }

        private void ObserverlaraHaberVer()
        {
            foreach (var observer in observerListesi)
            {
                observer.notify(this);
            }
        }

        public void KontorYukle()
        {
            SonKontorYuklemeTarihi = DateTime.Now;
        }
    }
}
