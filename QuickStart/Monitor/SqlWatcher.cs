using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Monitor
{
    public class SqlWatcher : EmptyInterceptor
    {
        public override NHibernate.SqlCommand.SqlString OnPrepareStatement(NHibernate.SqlCommand.SqlString sql)
        {
        
            System.Diagnostics.Debug.WriteLine("    " + sql);
            System.Diagnostics.Debug.WriteLine("\n\n");

        
            return base.OnPrepareStatement(sql);
        }


       
    }
}
