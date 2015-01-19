using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Facade.Entity;
using Facade.Worker;
using Worker;

namespace Facade.Manager
{
    public class SearchManager
    {
        private ValidationWorker validationWorker=new ValidationWorker();
        private ConvertToClassWorker convertToClassWorker = new ConvertToClassWorker();
        private DBWorker dbWorker = new DBWorker();
        private XMLWorker xmlWorker = new XMLWorker();

        public int SearchTransfer(HttpWebRequest request)
        {
            if (validationWorker.SearchRequestIsValid(request))//valid bir istekse
            {
                //request sınıfa cast edilir
                ClientRequest searchRequest = convertToClassWorker.ConvertRequestToClass(request);
                //gelen requeste göre web servisine bizim yollayacağımız request için gerekli
                //veriler çekiliyor
                RequestData requestData=dbWorker.GetRequestData(searchRequest);
                //web servisine yollayacağımız istek hazırlanıyor
                Entity.WebRequest webRequest=xmlWorker.PrepareWebSearchRequestToSupplier(requestData);
                //istek yollanıp cevap alınıyor
                string responseString = xmlWorker.SendSearchRequest(webRequest);
                //dönen cevap valid mi
                if (validationWorker.SearchResponseIsValid(responseString))
                {
                    //dönen cevap sınıfa cast ediliyor
                    Facade.Entity.WebResponse webResponse = convertToClassWorker.ConvertResponseToClass(responseString);
                    //dönen cevap veritabanına kaydedilip referans anahtar clientımıza dönülüyor.
                    int referenceKey = dbWorker.SaveResponseData(webResponse);
                    return referenceKey;
                }
                else//response hatalı
                {
                    return -1;//buralarda log felan da atıldığını düşünebiliriz.
                }
            }
            else
            {
                return -1;//buralarda log felan da atıldığını düşünebiliriz.
            }
        }
    }
}
