using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Reservation
    {
        public ReservationState resState;

        public Reservation()
        {
            this.resState = new PendingState(this);
            Console.WriteLine("Rezervayon yeni oluşturuldu. Varsayılan state' i pending.");
        }

        public void ConfirmRezervation()
        {
            this.resState.Confirm();
        }

        public void CancelRezervation()
        {
            this.resState.Cancel();
        }

        public void PendingRezervation()
        {
            this.resState.Pending();
        }

        public void NoshowRezervation()
        {
            this.resState.NoShow();
        }

    }
}
