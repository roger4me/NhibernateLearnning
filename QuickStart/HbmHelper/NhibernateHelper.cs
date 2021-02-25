using NHibernate;
using NHibernate.Cfg;
using QuickStart.Monitor;


namespace QuickStart.HbmHelper
{
    public class NhibernateHelper
    {
        private static readonly ISessionFactory SqlServerSessionFactory;
        private static readonly ISessionFactory MySqlSessionFactory;
        private static readonly string DataBase = System.Configuration.ConfigurationManager.AppSettings["DataBase"];

        static NhibernateHelper()
        {
            var cfg = new Configuration();
            cfg.DataBaseIntegration(x => { x.LogSqlInConsole = true; x.LogFormattedSql = true; });
            MySqlSessionFactory = cfg.Configure("Nhibernate_Mysql.xml").BuildSessionFactory();
            //SqlServerSessionFactory = cfg.Configure("Nhibernate_SqlServer.xml").BuildSessionFactory();
        }

        public static ISession GetCurrentSession()
        {
            ISession currentSession = null;

            if (DataBase.Equals("S"))
            {
                currentSession = SqlServerSessionFactory.OpenSession(new SqlWatcher());
            }
            else if(DataBase.Equals("M"))
            {
                currentSession = MySqlSessionFactory.OpenSession(new SqlWatcher());
            }
            
            return currentSession;
        }
        public static void CloseSession()
        {
            if (DataBase.Equals("S"))
            {
                SqlServerSessionFactory.GetCurrentSession().Close();
            }
            else if (DataBase.Equals("M"))
            {
                MySqlSessionFactory.GetCurrentSession().Close();
            }
        }

        public static void CloseSessionFactory()
        {
            if (DataBase.Equals("S"))
            {
                SqlServerSessionFactory.Close();
            }
            else if (DataBase.Equals("M"))
            {
                MySqlSessionFactory.Close();
            }
        }
    }
}
