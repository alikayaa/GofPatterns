using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Kredi
{
    public class CheckCompanyCustomerWork:CreditRequestBase
    {
        public override void ExecuteProcess(Customer customer)
        {
            if (base.CreditConfirmed)//bir önceki adımdan geçtiyse
            { 
                //burada müşterinin çalıştığı firmanın iyi bir firma olup
                //olmadığının kontrolü yapılıyor.
                bool companyIsFine = true;
                if (companyIsFine)//firma da iyiyse krediyi ver
                    base.CreditConfirmed = true;
                else
                    base.CreditConfirmed = false;
            }
        }
    }
}
