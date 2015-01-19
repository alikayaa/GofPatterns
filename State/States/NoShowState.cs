using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoShowState:ReservationState
    {
        private Reservation res;
        public NoShowState(Reservation res)
        {
            this.res = res;
        }
        public void Confirm()
        {
            Console.WriteLine("Noshow rezervasyon confirm edilemez.");
        }

        public void Cancel()
        {
            Console.WriteLine("Rezervasyon cancel edildi.");
            res.resState = new CancelState(this.res);
        }

        public void NoShow()
        {
            Console.WriteLine("Rezervasyon zaten noshow");
        }

        public void Pending()
        {
            Console.WriteLine("Noshow rezervasyon pending edilemez.");
        }
    }
}
