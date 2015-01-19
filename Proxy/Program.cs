using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] arg)
        {
            ProxyUserInformation proxy = new ProxyUserInformation();
            Console.WriteLine(proxy.GetUserInformation());

            Console.ReadLine();
        }
    }
}
