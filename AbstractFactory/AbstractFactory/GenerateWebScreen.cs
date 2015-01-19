using AbstractFactory.WebScreenGenerate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactory
{
    public class GenerateWebScreen : AbstractGenerateScreen
    {
        // Sayfa Oluşturma
        public override IPage CreatePage()
        {
            return new WebPage();
        }
        // Component Oluşturma
        public override IComponent CreateComponent()
        {
            return new WebComponent();
        }
    }
}
