using NHibernate;
using QuickStart.HbmHelper;
using QuickStart.Model.Concurrent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    public class ConcurrentTest
    {
        public static void Run()
        {
            try
            {
                using (ISession session = NhibernateHelper.GetCurrentSession())
                {
                    Dog dog = new Dog() { DogName="hahaha"};
                    session.Save(dog);
                    session.Flush();
                }

                using (ISession session = NhibernateHelper.GetCurrentSession())
                {
                    Dog dog1 = session.Get<Dog>(1);
                    Dog dog2 = session.Get<Dog>(1);
                    dog1.DogName = "heiheihei";
                    dog2.DogName = "xixixi";
                    session.Update(dog1);
                    session.Flush();
                    session.Update(dog2);
                    session.Flush();
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
