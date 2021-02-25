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
    public class ProdureTest
    {
        public static void Run()
        {
            try
            {
                using (ISession session = NhibernateHelper.GetCurrentSession())
                {
                    var people = session.GetNamedQuery("persons")
                                .SetInt32("Id", 1)
                                 .SetFirstResult(0)
                                 .SetFetchSize(10)
                                 .SetMaxResults(500)
                                 .List<Person>();
                    var count = people.Count();
                    if (people.Any())
                    {
                        people[0].UserName = "fff";
                        people[0].Gender = 'H';
                        session.Update(people[0]);
                        session.Flush();

                        session.Delete(people[0]);
                        session.Flush();
                    }
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
