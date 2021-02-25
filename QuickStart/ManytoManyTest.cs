using NHibernate;
using QuickStart.HbmHelper;
using QuickStart.Model.ManytoMany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
   public class ManytoManyTest
    {
        public static void Run()
        {
            try
            {
                ISession session = NhibernateHelper.GetCurrentSession();

                Product product = new Product() {
                                    ProductCode = "abc",
                                    ProductName = "Product1",
                                    Orders = new List<Order>() {
                                        new Order(){ OrderName="Order 1"},
                                        new Order(){ OrderName="Order 2"},
                                    }
                };

                Order order = new Order()
                {
                    OrderName = "Order 3",
                    Products = new List<Product>
                    {
                     new Product(){ ProductCode="efg",ProductName="Product2" },
                     new Product(){ ProductCode="gee",ProductName="Product3" },
                    }
                };
                session.Save(product);
                session.Save(order);

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
