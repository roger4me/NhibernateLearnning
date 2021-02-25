using NHibernate;
using QuickStart.HbmHelper;
using QuickStart.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    public class SecondLevelCacheTest
    {
        public static void Run()
        {
            try
            {
                using (ISession session = NhibernateHelper.GetCurrentSession())
                {
                    var person1 = session.Get<Person>(1);
                    //person1.Gender = 'A';
                    //session.SaveOrUpdate(person1);
                    //session.Flush();
                }

                using (ISession session1 = NhibernateHelper.GetCurrentSession())
                {
                    var person2 = session1.Get<Person>(1);
                }


                Console.WriteLine("finished.....");

            }
            catch (Exception e)
            {

                throw;
            }
            Console.ReadLine();
        }
    }
}
