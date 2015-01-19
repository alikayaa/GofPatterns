using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class RefinedComponentAbstraction:ComponentAbstraction
    {
        // İstemci taraftan gelen işi yapacak sınıf tipi üst sınıfa gönderilerek set edilir.
        public RefinedComponentAbstraction(ComponentImplementor _builder):base(_builder)
        {

        }
        // Üst sınıfta set etmiş olduğumuz iş yapıcı sınıf fonksiyonu çağırılır.
        public override void ComponentBuilder()
        {
            _componentBuilder.ComponentBuilder();
        }
    }
}
