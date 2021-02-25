using NHibernate;
using QuickStart.HbmHelper;
using QuickStart.Model.OnetoOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    public class OnetoOne2Test
    {
        public static void Run()
        {
            try
            {
                ISession session = NhibernateHelper.GetCurrentSession();

                //Address address = new Address() { 
                // UserAddress="address1",
                //  Profile = new Profile() { 
                //   UserName="eason1"
                //  }
                //};

                Address a1 = new Address() { UserAddress ="Address2" };

                Profile profile = new Profile()
                {
                    UserName = "eason2",
                };
                profile.SetAddress(a1);
        
                var result = session.Save(profile);

                session.Flush();

                session = NhibernateHelper.GetCurrentSession();

                var newProfile = session.Get<Profile>(result);

                newProfile.UserName = "new eason2";

                newProfile.Address.UserAddress = "hello world";

                session.Save(newProfile);

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
