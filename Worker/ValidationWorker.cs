using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    public class ValidationWorker
    {
        public bool SearchRequestIsValid(HttpWebRequest request)
        { 
            //burada gelen requestte ilgili alanların olup olmadığı
            //varsa istenen formatta olup olmadığının kontrolü yapılır.
            return true;
        }

        public bool SearchResponseIsValid(string response)
        {
            //burada gelen response da ilgili alanların olup olmadığı
            //varsa istenen formatta olup olmadığının kontrolü yapılır.
            return true;
        }
    }
}
