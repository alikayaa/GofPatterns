using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Entity;

namespace Worker
{
    public class XMLWorker
    {
        public WebRequest PrepareWebSearchRequestToSupplier(RequestData requestData)
        { 
            //requestin içindeki varilere göre supplierımızın isteyebileceği formatta
            //web request hazırlanır
            return new WebRequest();
        }

        public string SendSearchRequest(WebRequest webRequest)
        { 
            //burada ilgili requestin web servisine geçildiği varsayılıyor.
            return "<response>hede</response>";//gelen cevap xml formatta

        }
    }
}
