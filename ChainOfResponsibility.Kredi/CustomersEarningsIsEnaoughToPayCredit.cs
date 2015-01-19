using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Kredi
{
    public class CustomersEarningsIsEnoughToPayCredit : CreditRequestBase
    {
        public override void ExecuteProcess(Customer customer)
        {
            if (base.CreditConfirmed)//bir önceki adımdan geçiyorsa
            {
                //gelen müşteri bilgilerinden yola çıkılarak maaşının 
                //kredi taksitlerini ödemeye yeterli olup olmadığı kontrolü yapılır.
                bool isEnoughToPay = true;
                if (isEnoughToPay)//yeterliyse
                    base.CreditConfirmed = true;
                else
                    base.CreditConfirmed = false;
            }
        }
    }
}
