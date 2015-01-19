using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Dock
    {
        // Statik değişken
        private static Dock _dock;
        // Kilitleme(Lock) objesi
        private static object lockObject = new object();
        // Panel üzerindeki masaüstü öğesi
        private Finder finder;
        // Yapıcı metodu gizli yaparak new ile örneklendirmeyi önlüyoruz.
        private Dock()
        {
            
        }
        // Sınıftan Örnek Alma
        public static Dock Instance()
        {   
            if (_dock == null)
            {
                lock (lockObject)
                {
                    if (_dock == null)
                        _dock = new Dock();
                }
            }

            return _dock;
        }
       
        // Panel üzerine tıklama
        public void ClickDock()
        {
            Console.WriteLine("Panel'e tıklandı.");
            // Tıklanan masaüstü öğesi ise yeni masaüstü öğesi oluştur
            finder = new Finder();
            Console.WriteLine("Finder : " + finder.Title);
        }
    }
}
