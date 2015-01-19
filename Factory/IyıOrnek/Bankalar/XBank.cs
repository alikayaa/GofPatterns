using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.IyıOrnek.Bankalar
{
    public class XBank:IBank
    {
        public int TaksitYap()
        {
           return 5;
        }

        public string BankaAdi()
        {
            return "XBANK";
        }

        public decimal Indirim()
        {
            // Burada WebServisleri, veritabanında okuma gibi işlemler yapılabilir. Biz örnek uygulama olduğu için direk değer dönüyoruz.
            return 10;
        }
    }
}
