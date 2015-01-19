using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ConfirmState:ReservationState
    {
        private Reservation res;
        public ConfirmState(Reservation res)
        {
            this.res = res;
        }
        public void Confirm()
        {
            Console.WriteLine("Rezervasyon zaten confirm.");
        }

        public void Cancel()
        {
            Console.WriteLine("Rezervasyon cancel edildi.");
            res.resState = new CancelState(this.res);
        }

        public void NoShow()
        {
            Console.WriteLine("Rezervasyon noshow statüsüne getirildi.");
            res.resState = new NoShowState(this.res);
        }

        public void Pending()
        {
            Console.WriteLine("Confirm rezervasyon pending yapılamaz.");
        }
    }
}
