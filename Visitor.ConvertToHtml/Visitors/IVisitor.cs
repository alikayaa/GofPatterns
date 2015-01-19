using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.ConvertToHtml
{
    public abstract class IVisitor
    {
        private string _output = "";
        public string Output
        {
            get { return this._output; }
            protected set { this._output = value; }
        }

        public abstract void Visit(PlainText docPart);
        public abstract void Visit(BoldText docPart);
        public abstract void Visit(Hyperlink docPart);
    }
}
