using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.ConvertToHtml
{
    public class HtmlVisitor:IVisitor
    {
        public override void Visit(PlainText docPart)
        {
            base.Output += "<p>"+docPart.Text+"</p>";
        }

        public override void Visit(BoldText docPart)
        {
            base.Output += "<b>" + docPart.Text + "</b>";
        }

        public override void Visit(Hyperlink docPart)
        {
            base.Output += "<a href=\"" + docPart.Url + "\">" + docPart.Text + "</a>";
        }
    }
}
