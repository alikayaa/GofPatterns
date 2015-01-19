using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Visitor.ConvertToHtml
{
    public class BoldText:DocumentPart
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
