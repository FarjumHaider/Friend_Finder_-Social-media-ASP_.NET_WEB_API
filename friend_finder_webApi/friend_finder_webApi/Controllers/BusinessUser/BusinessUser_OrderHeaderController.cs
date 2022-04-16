using BEL.Entity.BusinessEntity;
using BLL.Service.BusinessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace friend_finder_webApi.Controllers.BusinessUser
{
    public class BusinessUser_OrderHeaderController : ApiController
    {
        [Route("api/BusinessUser_OrderHeader/CreateOrderHead")]
        [HttpPost]
        public void Add(OrderInfoModel pro)
        {
            OrderPlaceHeaderService.AddOrderHeader(pro);
        }
    }
}
