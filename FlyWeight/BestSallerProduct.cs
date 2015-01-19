using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    // Somut FlyWeight Sınıfı
    public class BestSallerProduct : Product
    {
        // Base Sınıfa Gönderilir.
        public BestSallerProduct(string productName)
            : base(productName) 
        {
        }

        // Soyut metod ezilerek işlem gerçekleştirilir.
        public override void ProductView(int price)
        {
            this.Price = price;
            Console.WriteLine("En Çok Satılan Ürünler");
            Console.WriteLine("Ürün : " + base.Name);
            Console.WriteLine("Fiyatı : " + this.Price);
            Console.WriteLine("\n");
        }
    }
}