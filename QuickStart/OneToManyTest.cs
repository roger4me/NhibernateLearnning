using NHibernate;
using QuickStart.HbmHelper;
using QuickStart.Model.ManyToOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart
{
    public class OneToManyTest
    {
        public static void Run()
        {
            try
            {
                ISession session = NhibernateHelper.GetCurrentSession();

                Class c2 = new Class() { ClassName = "Class 2" };
                Student s2 = new Student() { StudentName = "Student 2" };
                Student s3 = new Student() { StudentName = "Student 3" };

                c2.Students = new List<Student>();
                c2.Students.Add(s2);
                c2.Students.Add(s3);

               //观察数据库Student表
                s2.Class = c2;

                session.Save(c2);

        
                session.Flush();

             

                //c2.Students.Clear();
                //session.Delete(s2);
                //session.Flush();
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
