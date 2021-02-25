using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickStart.Model.UnionKey
{
    public class CellPhoneKeys
    {
       public virtual string Brand { get; set; }

       public virtual string ModelType { get; set; }

       public override bool Equals(object obj)
        {
            var entity = obj as CellPhoneKeys;
            if (entity == null)
            {
                return false;
            }

            return entity.Brand == this.Brand
                && entity.ModelType == this.ModelType;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
