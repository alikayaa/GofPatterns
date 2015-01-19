using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter._3rdPartyLogSystem;

namespace Adapter.OurLogSystem
{
    public class LoggerAdapter:ILogger
    {
        private ThirdPartyLogger otherLogger;
        public void LogAt(string loglanacakVeri)
        {
            LogItem logItem = new LogItem();
            logItem.LogId = new Guid();
            logItem.LogDescription = loglanacakVeri;
            otherLogger = new ThirdPartyLogger();
            otherLogger.LoglamaYap(logItem);
        }
    }
}
