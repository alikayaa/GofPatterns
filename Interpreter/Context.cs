using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Interpreter
{
    // Context Sınıfımız
    public class Context
    {
        // Yorumlanacak veri
        public XmlDocument ScreenInputData { get; set; }
        public XmlNode ControlInput { get; set; }
        // Yorumlanan veri çıktısı
        public Form ScreenOutputData = new Form();
    }
}
