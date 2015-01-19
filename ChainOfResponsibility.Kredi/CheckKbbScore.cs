using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Kredi
{
    public class CheckKbbScore:CreditRequestBase
    {
        public override void ExecuteProcess(Customer customer)
        {
            //burada Kbb skorunun kontrol edildiğini düşünün. Yani bu veriyi bir yerden aldık
            int kbbScore = 1200;
            if (kbbScore > 1000)
                base.CreditConfirmed = true;
            else
                base.CreditConfirmed = false;
        }
    }
}
