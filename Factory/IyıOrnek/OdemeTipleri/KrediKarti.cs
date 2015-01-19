using Factory.IyıOrnek.Bankalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.IyıOrnek
{
    public class KrediKarti:IOdeme
    {
        public bool OdemeYap()
        {
            return this.KrediKartıCekimYap();
        }

        private bool KrediKartıCekimYap()
        {
            // Kullanıcı Seçimine Göre İşlem Yapılır. Session'daki kullanıcı seçimine bakılır.
            // Taksit seçildiyse
            if (SessionManager.GetInstance().GetKrediKartiOdemeTipi() == KrediKartiOdemeTipi.Taksit)
                return this.TaksitYap();
            // Tek çekim seçildiyse
            else if (SessionManager.GetInstance().GetKrediKartiOdemeTipi() == KrediKartiOdemeTipi.TekCekim)
                return this.TekCekimYap();
            // varsayılan ödeme tek çekim
            else
                return this.TekCekimYap();
        }

        private bool TekCekimYap()
        {
            Console.WriteLine("Kredi kartı ile tek çekim yapıldı");
            return true;
        }

        private bool TaksitYap()
        {
            // Kullanıcı Seçimine Göre İşlem Yapılır. Session'daki kullanıcı seçimine bakılır.
            // Banka Fabrikasi Oluşturulur.
            BankaFabrikasi bankaFabrikasi = new BankaFabrikasi();
            // Kullanıcının seçtiği bankaya göre banka nesnesi oluşturulur.
            IBank banka = bankaFabrikasi.BankaNesnesiOlustur(SessionManager.GetInstance().GetBanka());
            banka.TaksitYap();
            Console.WriteLine("Kredi kartı ile " + banka.BankaAdi() + " bankasına " + banka.TaksitYap() + " taksit yapıldı.");
            return true;
        }
    }
}
