using NHibernate;
using QuickStart.HbmHelper;
using QuickStart.Model.ManytoMany;
using QuickStart.Model.OnetoOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    public class OnetoOneTest
    {
        public static void Run()
        {
            try
            {
                ISession session = NhibernateHelper.GetCurrentSession();

                Product product = new Product()
                {
                    ProductCode = "abc",
                    ProductName = "Product100",
                    Orders = new List<Order>() {
                                        new Order(){ OrderName="Order 100"},
                                        new Order(){ OrderName="Order 200"},
                                    }
                   
                };

                ProductDetail p = new ProductDetail() {
                    Description = "222555",
                    Product = product
                };
                product.ProductDetail = p;

                //session.Save(product);//no need

                session.Save(p);
                session.Flush();
            }
            catch (Exception e)
            {

                throw;
            }
            Console.WriteLine("finish......");
            Console.ReadLine();
        }
    }
}
