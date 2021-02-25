using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.ManyToOne
{
    public class Student
    {
        public virtual int Id { get; set; }

        public virtual string StudentName { get; set; }

        public virtual Class Class { get; set; }
    }
}
