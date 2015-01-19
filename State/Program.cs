using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Reservation r = new Reservation();
            Thread.Sleep(1500);
            r.NoshowRezervation();//olmayacak
            Thread.Sleep(1500);
            r.ConfirmRezervation();
            Thread.Sleep(1500);
            r.NoshowRezervation();
            Thread.Sleep(1500);
            r.CancelRezervation();
            Thread.Sleep(1500);
            r.PendingRezervation();

            Console.ReadLine();

        }
    }
}
