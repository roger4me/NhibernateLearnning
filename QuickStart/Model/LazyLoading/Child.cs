using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.LazyLoading
{
    public class Child
    {
        public virtual int Id { get; set; }

        public virtual string ChildName { get; set; }

        public virtual Father Father { get; set; }
    }
}
