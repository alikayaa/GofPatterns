using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.ConvertToHtml
{
    public class LatexVisitor:IVisitor
    {
        public override void Visit(PlainText docPart)
        {
            base.Output += docPart.Text;
        }

        public override void Visit(BoldText docPart)
        {
            base.Output += "\\textbf{" + docPart.Text + "}";
        }

        public override void Visit(Hyperlink docPart)
        {
            base.Output += "\\href{" + docPart.Url + "}{" + docPart.Text + "}";
        }
    }
}
