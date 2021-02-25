using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.Concurrent
{
    public class Dog
    {
        public virtual int Id{ get; set; }

        public virtual string DogName { get; set; }

        public virtual int Version { get; set; }
    }
}
