using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.ConvertToHtml
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }
        public abstract void Accept(IVisitor visitor);
    }
}
