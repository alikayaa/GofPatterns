using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    // Template Method'un uygulanacağı soyut sınıf.
    // Algoritma bu sınıf içerisinde belirlenir.
    public abstract class AkisBaslatma
    {
        // Algoritma Adımı
        public abstract void AkisBilgileriOlustur();
        // Algoritma Adımı
        public abstract void AkisBaslat();
        // Algoritma
        public void TemplateMethod()
        {
            AkisBilgileriOlustur();
            AkisBaslat();
        }
    }
}
