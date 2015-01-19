using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    // Alt sistem simülasyonu
    public class WindowSystem
    {
        // Yapıcı metod
        public WindowSystem()
        {

        }

        // Alt sistem metodu
        public string WindowDraw()
        {
            Console.WriteLine("Finder açıldı.");
            return "Mac OSX";
        }
    }
}
