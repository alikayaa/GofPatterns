using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Manager;

namespace Facade.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchManager searchManager = new SearchManager();
            int referanceKey=searchManager.SearchTransfer(null);
            Console.WriteLine(referanceKey);
        }
    }
}
