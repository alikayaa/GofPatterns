using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Finder
    {
        public string Title { get; set; }
        private WindowSystem _winSys = new WindowSystem();
        
        public Finder()
        {
            this.Title = this._winSys.WindowDraw();
        }
    }
}
