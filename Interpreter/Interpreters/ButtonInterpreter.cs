using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interpreter.Interpreters
{
    // Button Yorumlayıcı
    public class ButtonInterpreter : IExpression
    {
        public void BuildControl(Context context)
        {
            // Context'ten veri okuma
            XmlNode buttonNode = context.ControlInput;
            // Context'ten alınan bilgilere göre Button oluşturma
            Button newButton = new Button();
            newButton.Text = buttonNode.Attributes["Text"].Value;
            newButton.Name = buttonNode.Attributes["Name"].Value;
            newButton.Left = Convert.ToInt32(buttonNode.Attributes["Margin-Left"].Value);
            newButton.Top = Convert.ToInt32(buttonNode.Attributes["Margin-Top"].Value);
            newButton.Size = new System.Drawing.Size(Convert.ToInt32(buttonNode.Attributes["Width"].Value),Convert.ToInt32(buttonNode.Attributes["Height"].Value));
            newButton.UseVisualStyleBackColor = true;
            newButton.Click +=newButton_Click;
            context.ScreenOutputData.Controls.Add(newButton);
        }

        void newButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login Olundu!");
        }
    }
}

