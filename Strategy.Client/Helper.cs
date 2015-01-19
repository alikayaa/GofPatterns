using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Client
{
    public class Helper
    {
        public static void WriteConsole(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item.ToString()+"-");
            }
            Console.WriteLine("");
        }

    }
}
