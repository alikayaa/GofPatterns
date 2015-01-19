using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Kredi
{
    public class CheckKreditCardPaymentTime:CreditRequestBase
    {
        public override void ExecuteProcess(Customer customer)
        {
            if (base.CreditConfirmed)//bir önceki adımdan geçtiyse bunu çalıştır.
            {
                //burada daha önce kredi kartı borcunu geciktirip gecirtirmediği
                //bilgisi alınarak geciktirdiyse kaç ay geciktirdiği verisi getiriliyor
                int paymetDelayTime = 1;
                if (paymetDelayTime > 3)//eğer 3 aydan fazla bir gecikme süresi varsa red
                    base.CreditConfirmed = false;
                else
                    base.CreditConfirmed = true;
            }
        }
    }
}
