using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.OnetoOne
{
    public class Profile
    {
        public virtual int? Id { get; set; }
        public virtual string UserName { get; set; }
       public virtual Address Address { get; set; }

        public virtual void SetAddress(Address address)
        {
            this.Address = address;
            address.Profile = this;
        }
    }
}
