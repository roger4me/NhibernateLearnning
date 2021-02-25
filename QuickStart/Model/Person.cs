using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model
{
    public class Person
    {
        public virtual int Id { get; set; }

        public virtual string UserName { get; set; }

        public virtual string Pwd { get; set; }

        public virtual DateTime BirthDay { get; set; }

        public virtual char Gender { get; set; }

        public override string ToString()
        {
            return $"my name is {UserName},thank you all";
        }
    }
}
