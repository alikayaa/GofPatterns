using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactory
{
    public abstract class AbstractGenerateScreen
    {
        public abstract IComponent CreateComponent();
        public abstract IPage CreatePage();
    }
}
