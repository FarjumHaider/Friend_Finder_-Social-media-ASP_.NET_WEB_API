using DAL.Database;
using DAL.Interface.BusinessInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo.BusinessRepo
{
    public class OrderPlaceHeaderRepo : IOrderPlaceHeaderRepository<OrderInfo, int>
    {
        friend_finderEntities _db;

        public OrderPlaceHeaderRepo(friend_finderEntities _db)
        {
            this._db = _db;
        }

        public void Add(OrderInfo e)
        {

            //var value = (from cart in _db.ShoppingCarts where cart.Id == e.cartId select cart.count).Count();
            //var cart = (from c in _db.ShoppingCarts select c).ToList();
            


            var orderHeader = new OrderInfo();

            orderHeader.OrderDate = e.OrderDate;
            orderHeader.ShippingDate = e.ShippingDate;
            orderHeader.OrderStatus = e.OrderStatus;
            orderHeader.PaymentStatus = e.PaymentStatus;
            orderHeader.PaymentDate = e.PaymentDate;
            orderHeader.PaymentDueDate = e.PaymentDueDate;
            orderHeader.TransactionId = e.TransactionId;
            orderHeader.PhoneNo = e.PhoneNo;
            orderHeader.Address = e.Address;
            orderHeader.City = e.City;
            orderHeader.Name = e.Name;

            _db.OrderInfos.Add(orderHeader);
            _db.SaveChanges();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
