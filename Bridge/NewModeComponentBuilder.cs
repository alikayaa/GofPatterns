using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    // Component Oluşturucu
    public class NewModeComponentBuilder:ComponentImplementor
    {
        // Yeni Bilgisayarlara Göre Component'leri Oluştur.
        public override void ComponentBuilder()
        {
            Console.WriteLine("Component'ler Tüm Efektler ile Birlikte Oluşturuldu.");
        }
    }
}
