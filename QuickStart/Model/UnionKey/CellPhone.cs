using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.UnionKey
{
    public class CellPhone
    {
        public virtual CellPhoneKeys Keys { get; set; }

        public virtual decimal Price { get; set; }

        public virtual DateTime SellDate { get; set; }
    }
}
