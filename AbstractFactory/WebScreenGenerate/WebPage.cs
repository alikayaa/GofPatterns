using AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.WebScreenGenerate
{
    public class WebPage:IPage
    {
        // Gerçek uygulamımızda burada veritabanımızdaki bilgilere göre sayfalar oluşturulacaktır.
        public void BuildPage()
        {
            Console.WriteLine("Web Sayfası Oluşturuldu.");
        }
    }
}
