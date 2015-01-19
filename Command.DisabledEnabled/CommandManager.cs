using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.DisabledEnabled
{
    //bizim invoker sınıfımız
    public class CommandManager
    {
        //bütün commandleri bir kuyrukta tutarız
        public Stack<ICommand> Commands { get; set; }
        public CommandManager()
        {
            Commands = new Stack<ICommand>();
        }

        public void ExecuteAll()
        {
            while(Commands.Count>0)
            {
                Commands.Pop().Execute();
            }
        }



    }
}
