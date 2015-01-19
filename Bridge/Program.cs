using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // İlk açılışta varsayılan mod eski mod olsun.
            ComponentAbstraction compBuilder = new RefinedComponentAbstraction(new OldModeComponentBuilder());
            compBuilder.ComponentBuilder();

            // Kullanıcı yeni moda geçti.
            compBuilder = new RefinedComponentAbstraction(new NewModeComponentBuilder());
            compBuilder.ComponentBuilder();

            Console.ReadLine();
        }
    }
}
