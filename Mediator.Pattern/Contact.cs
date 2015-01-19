using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Pattern
{
    // Haberleşecek olan sınfımız
    public class Contact:Colleague
    {
        // Temel sınıfa isim özelliği geçirilir.
        public Contact(string name):base(name)
        {
                
        }
        // Mediator'u kullanarak mesaj gönder
        public void SendMessage(string from, string message)
        {
            base.concreteMediator.SendMessage(from, message);
        }

    }
}
