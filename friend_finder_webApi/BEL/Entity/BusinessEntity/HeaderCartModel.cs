using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity.BusinessEntity
{
    public class HeaderCartModel
    {
        public virtual OrderInfoModel OrderHeader { get; set; }
        public virtual ShoppingCartModel Cart { get; set; }
    }
}
