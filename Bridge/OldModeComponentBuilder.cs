using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Component Oluşturucu
    public class OldModeComponentBuilder:ComponentImplementor
    {
        // Eski Bilgisayarlara Göre Component'ler Oluşturuldu
        public override void ComponentBuilder()
        {
            Console.WriteLine("Component'ler Efekt Olmadan Çalıştırıldı");
        }
    }
}
