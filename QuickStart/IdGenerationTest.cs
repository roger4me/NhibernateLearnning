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
    public class IdGenerationTest
    {
        public static void Run()
        {
           
           
                try
                {
                ISession session = NhibernateHelper.GetCurrentSession();
                Model.IdGeneration p = new Model.IdGeneration { UserName = "haha", BirthDay = DateTime.Now, Gender = 'M', Pwd = "abc" };
                session.Save(p);
                session.Flush();
                }
                catch (Exception e)
                {

                    throw;
                }

              
                
            

            //var specificPerson = session.Query<Person>().Where(x => x.UserName.Equals("angel"));

            //var specificPerson2 = session.Query<Person>().Where(x => x.UserName.Equals("angel"));

            //Console.WriteLine(specificPerson == specificPerson2);

            Console.ReadLine();

        }
    }
}
