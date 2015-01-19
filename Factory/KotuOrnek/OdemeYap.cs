using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.KotuOrnek
{
    public class OdemeYap
    {
        public bool odemeYap(string urun, string sepet, string odemeTipi)
        {
            bool result = false;
            string UrunAdi = string.Empty;
            string UrunSepeti = string.Empty;

            // Ödeme tipine göre ödeme al.
            // Kredi Kartı İle Ödeme Seçildiyse
            if (odemeTipi == "KrediKartı")
            {
                UrunAdi = urun;
                UrunSepeti = sepet;
                result = this.KrediKartıCekimYap();

            }
            // Banka Havalesi ile Ödeme Seçildiyse
            else if (odemeTipi == "BankaHavalesi")
            {
                UrunAdi = urun;
                UrunSepeti = sepet;
                result = this.BankaHavalesiIleOdeme();
            }
            // Varsayılan Ödeme Tipi Olarak Kredi Kartı
            else
            {
                UrunAdi = urun;
                UrunSepeti = sepet;
                result = this.KrediKartıCekimYap();
            }
            return result;

        }
        private bool KrediKartıIleOdeme()
        {
            // Kredi Kartından Para Çek.
            return this.KrediKartıCekimYap();
        }
        private bool KrediKartıCekimYap()
        {
            Console.WriteLine("Kredi kartı ile ödeme yapıldı");
            return true;
        }

        private bool BankaHavalesiIleOdeme()
        {
            // Banka hesabını kontrol et para gelmişmi.
            return this.BankaHavalesiKontrolEt();
        }
        private bool BankaHavalesiKontrolEt()
        {
            Console.WriteLine("Banka hesabı kontrol edildi, havale gelmiş.");
            return true;
        }
    }
}
