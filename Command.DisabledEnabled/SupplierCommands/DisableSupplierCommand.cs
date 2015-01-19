using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.DisabledEnabled
{
    public class DisableSupplierCommand:SupplierCommand
    {
        public DisableSupplierCommand(ReceiverSupplier receiverSupplier)
            :base(receiverSupplier)
        {

        }

        public override void Execute()
        {
            base.receiverSupplier.Disable();
        }
    }
}
