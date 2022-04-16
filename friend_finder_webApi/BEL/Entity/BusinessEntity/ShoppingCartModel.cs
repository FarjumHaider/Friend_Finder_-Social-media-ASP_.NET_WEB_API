using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity.BusinessEntity
{
    public class ShoppingCartModel
    {
        public ShoppingCartModel()
        {
            count = 1;
        }
        public int Id { get; set; }
        public int productId { get; set; }
        public int count { get; set; }
        public int price { get; set; }

        public virtual ProductModel Product { get; set; }
    }
}
