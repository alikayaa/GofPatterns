using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.DisabledEnabled
{
    public abstract class SupplierCommand:ICommand
    {
        protected ReceiverSupplier receiverSupplier;
        public SupplierCommand(ReceiverSupplier receiverSupplier)
        {
            this.receiverSupplier = receiverSupplier;
        }

        public abstract void Execute();
    }
}
