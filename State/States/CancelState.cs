using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CancelState:ReservationState
    {
        private Reservation res;
        public CancelState(Reservation res)
        {
            this.res = res;
        }

        public void Confirm()
        {
            Console.WriteLine("Cancel reservasyon confirm edilemez.");
        }

        public void Cancel()
        {
            Console.WriteLine("Reservasyon zaten cancel.");
        }

        public void NoShow()
        {
            Console.WriteLine("Cancel rezervasyon noshow state' ine geçemez.");
        }

        public void Pending()
        {
            Console.WriteLine("Cancel rezervasyon pending state' ine geçemez.");
        }
    }
}
