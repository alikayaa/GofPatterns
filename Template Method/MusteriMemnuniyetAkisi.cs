using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    // Müşteri Memnuniyet Akışı.
    public class MusteriMemnuniyetAkisi:AkisBaslatma
    {
        // Kullanıcı Bilgisi Müşteri Adıdır.
        public string MusteriAdi = "Merve";
        // Akış İçin Bilgileri Oluşturma
        public override void AkisBilgileriOlustur()
        {
            Console.WriteLine("Memnuniyet Akışı - Müşteri Adı : " + MusteriAdi);
        }
        // Akış Başlatma
        public override void AkisBaslat()
        {
            Console.WriteLine("Müşteri Memnuniyeti Akışı Başlatıldı.");
        }
    }
}
