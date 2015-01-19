using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.DisabledEnabled
{
    //Bizim command nesnemiz
    public interface ICommand
    {
        void Execute();
    }
}
