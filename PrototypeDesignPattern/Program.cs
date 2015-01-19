using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Prototype.Entity;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product() { Name = "Sony D60001", ProductID = 1 };
            product.Brand = new Brand() { BrandID = 101, BrandName = "Sony" };

            //manuel copy/clone
            Product manuelDeepCopyProduct = new Product() { Name = product.Name, ProductID = product.ProductID };
            Product shallowCopyProduct = product;//sadece referanslar ortak data aynı
            Product cloneCopyProduct = (Product)product.Clone();//bizim deep copy
            cloneCopyProduct.Brand.BrandName = "Deneme";
            Product deepCopyProduct = (Product)product.Copy();//memberwiseclone kullanarak

        }
    }
}
