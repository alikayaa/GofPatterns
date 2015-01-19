using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class BTKUserInformation:IUserInformation
    {
        public string GetUserInformation()
        {
            return "Merve";
        }
    }
}
