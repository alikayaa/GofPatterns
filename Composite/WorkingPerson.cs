using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    // Çalışan İnsan
    public class WorkingPerson:Worker
    {
        // Çalışan ücreti.
        public override int GetCost()
        {
            return 25;
        }
    }
}
