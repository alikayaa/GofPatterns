using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductHelper.ProductType[] ProductTypes = { ProductHelper.ProductType.BestSaller,ProductHelper.ProductType.MostViewed };
            ProductManager productManager = new ProductManager();
            int price = 20;

            foreach (ProductHelper.ProductType item in ProductTypes)
            {
                Product product = productManager.GetProduct(item);
                product.ProductView(price);
                Console.WriteLine("----------------");
            }
           
            Console.ReadKey();
        }
    }
}
