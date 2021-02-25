using NHibernate;
using QuickStart.HbmHelper;
using QuickStart.Model.LazyLoading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    public class LazyLoadingTest
    {
        public static void Run()
        {
            try
            {
                ISession session = NhibernateHelper.GetCurrentSession();

                Father father = new Father()
                {
                    FatherName = "SuperMan"

                };

                var Children = new List<Child>() {
                     new Child(){ ChildName ="Son 1", Father = father },
                     new Child(){ ChildName ="Son 2", Father = father },
                     new Child(){ ChildName ="Son 3", Father = father }

                 };

                father.Children = Children;
                session.Save(father);
                session.Flush();



                //Father father = session.Get<Father>(1);
                //NHibernate.NHibernateUtil.Initialize(father.Children);
                //session.Close();

                //var childen = father.Children.ToList();

                //var aaa = childen[0];

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
