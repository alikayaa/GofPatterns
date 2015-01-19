using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interpreter.Interpreters
{
    // TextBox Yorumlayıcı
    public class TextboxInterpreter : IExpression
    {
        public void BuildControl(Context context)
        {
            // Context'ten veri okuma
            XmlNode textBoxNode = context.ControlInput;
            // Context'ten alınan bilgilere göre TextBox oluşturma
            TextBox newTextBox = new TextBox();
            newTextBox.UseSystemPasswordChar = textBoxNode.Attributes["Type"].Value == "Password";
            newTextBox.Name = textBoxNode.Attributes["Name"].Value;
            newTextBox.Left = Convert.ToInt32(textBoxNode.Attributes["Margin-Left"].Value);
            newTextBox.Top = Convert.ToInt32(textBoxNode.Attributes["Margin-Top"].Value);
            context.ScreenOutputData.Controls.Add(newTextBox);
        }
    }
}
