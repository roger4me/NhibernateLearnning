using NHibernate;
using QuickStart.HbmHelper;
using QuickStart.Model.UnionKey;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    public class UnionKeysTest
    {
        public static void Run()
        {
            try
            {
                ISession session = NhibernateHelper.GetCurrentSession();
                CellPhone c = new CellPhone() { Keys = new CellPhoneKeys() { Brand = "Xiaomi", ModelType = "mi12" }, Price=2528, SellDate=DateTime.Now };
                session.Save(c);
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
