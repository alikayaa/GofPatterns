using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.IyıOrnek.Bankalar
{
    public class YBank:IBank
    {
        int IBank.TaksitYap()
        {
            return 4;
        }

        public string BankaAdi()
        {
            return "YBANK";
        }

        public decimal Indirim()
        {
            // Burada WebServisleri, veritabanında okuma gibi işlemler yapılabilir. Biz örnek uygulama olduğu için direk değer dönüyoruz.
            return 5;
        }
    }
}
