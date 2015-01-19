using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    // Çalışan Akışı.
    public class CalisanAkisi:AkisBaslatma
    {
        // Kullanıcı Bilgisi Çalışan Adıdır.
        public string CalisanAdi = "Serdar";
        // Akış İçin Bilgileri Oluşturma
        public override void AkisBilgileriOlustur()
        {
            Console.WriteLine("Çalışan Akışı - Çalışan Bilgileri : " + CalisanAdi);
        }
        // Akış Başlatma
        public override void AkisBaslat()
        {
            Console.WriteLine(CalisanAdi + " isimli çalışan için uzaktan internet yetkisi istenmiştir.");
        }
    }
}
