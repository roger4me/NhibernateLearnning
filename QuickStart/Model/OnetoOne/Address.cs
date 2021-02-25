using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.OnetoOne
{
    public class Address
    {
        public virtual int Id { get; set; }

        public virtual string UserAddress { get; set; }

        public virtual Profile Profile { get; set; }

    }
}
