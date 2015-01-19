using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri Memnuniyet Akışı Oluşturma
            AkisBaslatma musteri = new MusteriMemnuniyetAkisi();
            // Akışı Başlatma
            musteri.TemplateMethod();

            // Çalışan İçin Yönetimsel Akış Oluşturma
            AkisBaslatma calisan = new CalisanAkisi();
            // Akışı Başlatma
            calisan.TemplateMethod();

            Console.Read();
        }
    }
}
