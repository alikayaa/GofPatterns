using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    // Flyweight
    public abstract class Product
    {
        // intrinsic özellikler
        public string Name;
        // extrinsic özellikler
        public int Price;
        // Yapıcı metod
        public Product(string ProductName)
        {
            this.Name = ProductName;
        }
        // Soyut Ürün Gösterme 
        public abstract void ProductView(int price);
    }
}
