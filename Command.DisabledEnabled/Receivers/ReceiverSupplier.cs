using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.DisabledEnabled
{
    public class ReceiverSupplier
    {
        private int supplierId;
        private string supplierName;

        public ReceiverSupplier(int supplierId, string supplierName)
        {
            this.supplierId = supplierId;
            this.supplierName = supplierName;
        }

        public void Enable()
        {
            Console.WriteLine("- "+supplierId+" id'li "+supplierName+" adlı supplier aktif edildi.");
        }

        public void Disable()
        {
            Console.WriteLine("- " + supplierId + " id'li " + supplierName + " adlı supplier pasif edildi.");
        }

    }
}
