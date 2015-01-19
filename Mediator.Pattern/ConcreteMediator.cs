using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Pattern
{
    // Soyut Mediator Sınıfı.
    public class ConcreteMediator:Mediator
    {
        // Aracı olanacak kullanıclar listesi
        public Dictionary<string, Colleague> _user = new Dictionary<string,Colleague>();
        // Kullanıcı mesajları
        public List<string> UserMessage = new List<string>();
        // Kayıt ol
        public override void Register(Colleague colleague)
        {
            // Bu kullanıcı daha önce kayıt edilmediyse kayıt altına al.
            if (!_user.ContainsValue(colleague))
            {
                // Kullanıcı ekle
                _user.Add(colleague.Name,colleague);
            }
            // Aracı nesnenisi atama
            colleague.concreteMediator = this;
        }
        // Aracı ile mesaj gönderme
        public override void SendMessage(string from,string message)
        {
            // Mesaj ekle
            UserMessage.Add(string.Format("{0} : {1}",from,message));
        }
    }
}
