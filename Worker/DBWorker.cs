using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Entity;

namespace Facade.Worker
{
    public class DBWorker
    {
        public RequestData GetRequestData(ClientRequest request)
        {
            //burada gelen SearchRequest sınıfındaki parametrelere göre
            //veritabanına ilgili sorgunun atılıp geriye dönen cevabı
            //RequestData sınıfına eklediğimiz düşünülüyor
            return new RequestData();
        }

        public int SaveResponseData(WebResponse response)
        { 
            //buradaki response da gelen datalar veritabanına kaydediliyor.
            //en sonunda geriye veritabanında oluşturulan id dönülüyor
            return 10;//rastgele bir sayı
        }
    }
}
