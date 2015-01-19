using Factory.IyıOrnek.Bankalar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.IyıOrnek
{
    public class BankaFabrikasi
    {
        // istemci tarafından gelen ödeme tipine göre ödeme nesnesi döner.
        public IBank BankaNesnesiOlustur(string banka)
        {
            // Banka tipi XBANK ise
            if (banka == Factory.Cons.Bankalar.XBANK)
                return new XBank();
            // Banka tipi YBANK ise
            if (banka == Factory.Cons.Bankalar.YBANK)
                return new YBank();

            // varsayılan banka 
            return new XBank();
        }
    }
}
