using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.DisabledEnabled
{
    public class BankDeleteCommand:CommandBank
    {
        public BankDeleteCommand(ReceiverBank receiverBank) :
            base(receiverBank)
        {

        }

        public override void Execute()
        {
            base.receiverBank.Delete();
        }
    }
}
