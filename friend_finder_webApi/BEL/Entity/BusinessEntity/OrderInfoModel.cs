using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity.BusinessEntity
{
    public class OrderInfoModel
    {
        public int Id { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime ShippingDate { get; set; }
        public int OrderTotal { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public Nullable<System.DateTime> PaymentDueDate { get; set; }
        public string TransactionId { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Name { get; set; }
        public int cartId { get; set; }

        public virtual ShoppingCartModel ShoopingCart { get; set; }
    }
}
