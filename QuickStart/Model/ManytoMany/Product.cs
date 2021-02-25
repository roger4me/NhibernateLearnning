using QuickStart.Model.OnetoOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.ManytoMany
{
    public class Product
    {
        public virtual int Id { get; set; }

        public virtual string ProductCode { get; set; }

        public virtual string ProductName { get; set; }

        public virtual IList<Order> Orders { get; set; }

        public virtual ProductDetail ProductDetail { get; set; }
    }
}
