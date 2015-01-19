using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.OurLogSystem;

namespace Adapter.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new LoggerAdapter();
            logger.LogAt("Loglanacak verimiz");
        }
    }
}
