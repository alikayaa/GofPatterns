using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Facade.Entity;

namespace Worker
{
    public class ConvertToClassWorker
    {
        public ClientRequest ConvertRequestToClass(HttpWebRequest request)
        { 
            //burada client'tan gelen istekteki alanlar tek tek işlenerek sınıflara çevriliyor
            return new ClientRequest();
        }

        public Facade.Entity.WebResponse ConvertResponseToClass(string request)
        {
            //burada web servisinden gelen cevaptaki alanlar tek tek işlenerek sınıflara çevriliyor
            return new Facade.Entity.WebResponse();
        }
    }
}
