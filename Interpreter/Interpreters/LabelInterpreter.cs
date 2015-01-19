using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interpreter.Interpreters
{
    // Label Yorumlayıcı
    public class LabelInterpreter:IExpression
    {
        public void BuildControl(Context context)
        {
            // Context'ten veri okuma
            XmlNode labelNode = context.ControlInput;
            // Context'ten alınan bilgilere göre Label oluşturma
            Label newLabel = new Label();
            newLabel.Text = labelNode.Attributes["Text"].Value;
            newLabel.Name = labelNode.Attributes["Name"].Value;
            newLabel.Left = Convert.ToInt32(labelNode.Attributes["Margin-Left"].Value);
            newLabel.Top = Convert.ToInt32(labelNode.Attributes["Margin-Top"].Value);
            context.ScreenOutputData.Controls.Add(newLabel);
        }
    }
}
