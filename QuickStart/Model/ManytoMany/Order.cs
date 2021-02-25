using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.ManytoMany
{
    public class Order
    {
        public virtual int Id { get; set; }

        public virtual string OrderName { get; set; }

        public virtual IList<Product> Products { get; set; }
    }
}
