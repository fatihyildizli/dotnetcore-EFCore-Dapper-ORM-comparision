using System.Collections.Generic;
using EFCore.EntityMapping.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompareController : ControllerBase
    {

        readonly IShippersService _shipperService;
        readonly IOrdersService    _orderService;
        IConfiguration _iconfiguration;

        public CompareController(IShippersService shipperService,IOrdersService orderService, IConfiguration iconfiguration)
        {
            _shipperService = shipperService;
            _orderService = orderService;
            _iconfiguration = iconfiguration;
        }


        [Route("OrdersEFCoreVersusDapper")]
        [HttpGet]
        public string OrdersEFCoreVersusDapper()
        {

            return string.Format("{0}\n{1}",_orderService.GetOrdersWithEFCoreElapsed(), _orderService.GetOrdersWithDapperElapsed()); 
        }

        [Route("ShippersEFCoreVersusDapper")]
        [HttpGet]
        public string ShippersEFCoreVersusDapper()
        {

            return string.Format("{0}\n{1}", _shipperService.GetShippersWithEFCoreElapsed(),_shipperService.GetShippersWithDapperElapsed());
        }


       


    }
}


