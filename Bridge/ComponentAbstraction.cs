using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    
    public abstract class ComponentAbstraction
    {
        // Uygulayıcı sınıf arayüzü.
        protected ComponentImplementor _componentBuilder;
        // Uygulayıcı sınıf ayarlama
        public ComponentAbstraction(ComponentImplementor _builder)
        {
            this._componentBuilder = _builder;
        }
        public abstract void ComponentBuilder();
    }
}
