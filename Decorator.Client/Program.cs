using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.DbSystem;

namespace Decorator.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            EFRepository<Product> productRepository = new EFRepository<Product>();

            LoggingRepositoryDecorator<Product> updateDeleteLoggingDecorator =
                new LoggingRepositoryDecorator<Product>(productRepository);

            SendRequestRepositoryDecorator<Product> updateDeleteRequestDecorator =
                new SendRequestRepositoryDecorator<Product>(updateDeleteLoggingDecorator);

            UpdateDataWareHouseRepositoryDecorator<Product> updateDataWareHouseDecorator =
                new UpdateDataWareHouseRepositoryDecorator<Product>(updateDeleteRequestDecorator);

            SecurityRepositoryDecorator<Product> securityDecorator =
                new SecurityRepositoryDecorator<Product>(updateDataWareHouseDecorator);


            #region Select işlemi

            Console.WriteLine("--------------------------------------------");

            securityDecorator.Get(3);

            Console.WriteLine("---------------------------------------------\n");

            #endregion

            #region Add işlemi

            Console.WriteLine("--------------------------------------------");

            Product p=new Product(){ ProductId=1, ProductName="Ürünüm 1" };

            securityDecorator.Add(p);

            Console.WriteLine("---------------------------------------------\n");

            #endregion

            #region Update ve Delete İşlemi

            
            Console.WriteLine("---------------------------------------------");

            securityDecorator.Delete(p);

            Console.WriteLine("---------------------------------------------\n");

            Console.WriteLine("---------------------------------------------");

            securityDecorator.Update(p);

            Console.WriteLine("---------------------------------------------\n");

            #endregion

            Console.ReadLine();
        }
    }
}
