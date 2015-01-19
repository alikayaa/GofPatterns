using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.OurLogSystem
{
    public class FileLogger:ILogger
    {
        public FileLogger()
        {

        }
        public void LogAt(string loglanacakVeri)
        {
            //burada dosyaya log atıldığını düşünün
        }
    }
}
