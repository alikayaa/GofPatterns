using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.DisabledEnabled
{
    public class ReceiverBank
    {
        private string bankName;

        public ReceiverBank(string bankName)
        {
            this.bankName = bankName;
        }

        public void Add()
        {
            Console.WriteLine(bankName+" adlı banka sisteme eklendi.");
        }

        public void Delete()
        {
            Console.WriteLine(bankName + " adlı banka sistemden silindi.");
        }
    }
}
