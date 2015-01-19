using AbstractFactory.WinFormScreenGenerate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactory
{
    public class GenerateWinFormScreen : AbstractGenerateScreen
    {

        public override IPage CreatePage()
        {
            return new WinForm();
        }

        public override IComponent CreateComponent()
        {
            return new  WinFormComponent();
        }
    }

    public class CopyOfGenerateWinFormScreen : AbstractGenerateScreen
    {

        public override IPage CreatePage()
        {
            return new WinForm();
        }

        public override IComponent CreateComponent()
        {
            return new WinFormComponent();
        }
    }
}
