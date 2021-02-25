using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.ManyToOne
{
    public class Class
    {
        public virtual int Id { get; set; }

        public virtual string ClassName { get; set; }

        public virtual IList<Student> Students { get; set; }
    }
}
