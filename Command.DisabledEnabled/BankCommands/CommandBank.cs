using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.DisabledEnabled
{
    public abstract class CommandBank:ICommand
    {
        protected ReceiverBank receiverBank;
        public CommandBank(ReceiverBank receiverBank)
        {
            this.receiverBank = receiverBank;
        }

        public abstract void Execute();
    }
}
