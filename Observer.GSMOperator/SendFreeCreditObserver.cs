using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.GSMOperator
{
    public class SendFreeCreditObserver:IObserver
    {
        public void notify(Customer customer)
        {
            Console.WriteLine(customer.TelefonNo + " numarasına sahip " + customer.KullaniciAdi + " adlı kullanıcıya bedava kontör gönderildi.");
        }
    }
}
