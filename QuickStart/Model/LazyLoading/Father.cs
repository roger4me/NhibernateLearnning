using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.LazyLoading
{
    public class Father
    {
        public virtual int Id { get; set; }

        public virtual string FatherName { get; set; }

        public virtual IList<Child> Children { get; set; }
    }
}
