using AutoMapper;
using BEL.Entity.BusinessEntity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.BusinessService
{
    public class OrderPlaceHeaderService
    {
        public static void AddOrderHeader(OrderInfoModel pro)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<OrderInfoModel, OrderInfo>();
                //c.CreateMap<ShoppingCart, ShoppingCartModel>();
                

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<OrderInfo>(pro);
            DataAccessFactory.OrderInfoDataAccess().Add(data);
        }
    }
}
