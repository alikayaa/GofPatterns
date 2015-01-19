using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public interface ReservationState
    {
        void Confirm();
        void Cancel();
        void NoShow();
        void Pending();
    }
}
