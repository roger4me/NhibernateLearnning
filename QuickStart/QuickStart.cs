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
    public class QuickStart
    {
        public static void Run()
        {
            ISession session = NhibernateHelper.GetCurrentSession();

            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    var person = new Person()
                    {
                        UserName = "heihei",
                        BirthDay = DateTime.Now,
                        Gender = 'M',
                        Pwd = "xxxxxx"
                    };
                    var person2 = new Person()
                    {
                        UserName = "eason",
                        BirthDay = DateTime.Now,
                        Gender = 'M',
                        Pwd = "uuuuuuuu"
                    };
                    session.Save(person);
                    session.Save(person2);
                    tx.Commit();
                }

                var allPerson = session.Query<Person>();

                foreach (var person in allPerson)
                {
                    Console.WriteLine(person.ToString());
                }

                var specificPerson = session.Query<Person>().Where(x => x.UserName.Equals("eason"));

                foreach (var person in specificPerson)
                {
                    Console.WriteLine(person.ToString());

                    person.Pwd = person.UserName + DateTime.Now.ToString();

                    session.SaveOrUpdate(person);

                    session.Delete(person);

                    session.Flush();

                }
            }
            catch (Exception e)
            {

                throw;
            }

            Console.ReadLine();
        }
    }
}
