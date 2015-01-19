using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    //FlyweightFactory
    public class ProductManager
    {
        // Ürün Listesi
        private Dictionary<ProductHelper.ProductType, Product> ProductList;
        public ProductManager()
        {
            // Ürün listesi oluşturma
            ProductList = new Dictionary<ProductHelper.ProductType, Product>();
        }

        public Product GetProduct(ProductHelper.ProductType productType)
        {
            // Daha Önce Oluşturduysak var olan nesneyi dönüyoruz.
            if (ProductList.ContainsKey(productType))
                return ProductList[productType];
            // İlk Defa Oluşturuyorsak Listemize Ekliyor Ve Geri Dönüyoruz.
            Product product;
            // Ürün Tipine Göre Ürünümüzü Oluşturuyoruz.
            if (productType == ProductHelper.ProductType.BestSaller)
                product = new BestSallerProduct("Ürün 1");
            else
                product = new MostViewedProduct("Ürün 1");
            // Listemize Ekliyoruz.
            ProductList.Add(productType, product);
            // Ürünü Geri Dönüyoruz.
            return ProductList[productType];
        }
    }
}
