using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Pattern
{
    // Soyut Mediator Sınıfı
    public abstract class Mediator
    {
        public abstract void Register(Colleague colleague);
        public abstract void SendMessage(string to, string message);
    }
}
