using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Kredi
{
    public class CheckGuarantorIsFine:CreditRequestBase
    {
        public override void ExecuteProcess(Customer customer)
        {
            if (base.CreditConfirmed)//bir önceki adımdan geçtiyse bu adımı çalıştır
            {
                //müşterinin varsa kefilinin sağlam olup olmadığına bakılıyor diye düşünülebilir.
                bool guarantorIsFine = true;
                if (guarantorIsFine)
                    base.CreditConfirmed = true;
                else
                    base.CreditConfirmed = false;
            }
        }
    }
}
