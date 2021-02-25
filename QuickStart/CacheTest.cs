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
    public class CacheTest
    {
        public static void Run()
        {
            try
            {
                ISession session = NhibernateHelper.GetCurrentSession();

                var specificPerson = session.Get<Person>(1);

                if (specificPerson != null)
                {
                    specificPerson.Gender = 'S';
                    session.SaveOrUpdate(specificPerson);
                    session.Flush();
                }

                specificPerson = session.Get<Person>(1);

                if (specificPerson != null)
                {
                    session.Delete(specificPerson);
                    session.Flush();
                }

                specificPerson = session.Get<Person>(1);

                Console.WriteLine("finished.....");


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

