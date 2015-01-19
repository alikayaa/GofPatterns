using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.OurLogSystem
{
    public class DatabaseLogger:ILogger
    {
        public void LogAt(string loglanacakVeri)
        {
            //burada ilgili verinin db ye kaydedildiğini düşünüyoruz.
        }
    }
}
