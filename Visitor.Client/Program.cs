using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.ConvertToHtml;

namespace Visitor.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir doküman oluşturmak için DocumentPart soyut sınıfımız var
            //Bu sınıfların her birinin text özelliği var
            PlainText docPart1 = new PlainText();
            Hyperlink docPart2 = new Hyperlink();
            BoldText docPart3 = new BoldText();

            docPart1.Text = "Tasarım kalıpları, bir tecrübenin ürünü olarak ortaya çıkmış tekniklerdir.";
            docPart2.Text = "Kitap Linki";
            docPart2.Url = "www.charpiletasarimkaliplari.com";
            docPart3.Text = "C# ile tasarım kalıpları";

            //bu sınıflara gerçek manada özellikleri eklemek için
            //visitor sınıfından yardım alıyoruz.

            IVisitor htmlVisitor = new HtmlVisitor();
            docPart1.Accept(htmlVisitor);
            docPart2.Accept(htmlVisitor);
            docPart3.Accept(htmlVisitor);

            Console.WriteLine("Çıktımız: \n"+htmlVisitor.Output);

            Console.ReadLine();
        }
    }
}
