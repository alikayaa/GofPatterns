using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class PendingState:ReservationState
    {
        private Reservation res;
        public PendingState(Reservation res)
        {
            this.res = res;
        }

        public void Confirm()
        {
            Console.WriteLine("Rezervasyon Confirm Edildi.");
            res.resState = new ConfirmState(this.res);
        }

        public void Cancel()
        {
            Console.WriteLine("Rezervasyon Cancel edildi.");
            res.resState = new CancelState(this.res);
        }

        public void NoShow()
        {
            Console.WriteLine("Pending rezervasyon noshow state' ine geçirilemez.");
        }

        public void Pending()
        {
            Console.WriteLine("Rezervasyon zaten pending.");
        }
    }
}
