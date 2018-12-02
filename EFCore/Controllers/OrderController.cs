using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.EntityMapping.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


namespace EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        readonly IOrdersService _orderService;
        IConfiguration _iconfiguration;

        public OrderController(IOrdersService orderService, IConfiguration iconfiguration)
        {
            _orderService = orderService;
            _iconfiguration = iconfiguration;
        }


        [Route("GetOrderWithEfCore")]
        [HttpGet]
        public List<Orders> GetOrdersWithEFCore()
        {

            return _orderService.GetOrdersWithEFCore();
        }
        [Route("GetOrderWithDapper")]
        [HttpGet]
        public List<Orders> GetOrdersWithDapper()
        {

            return _orderService.GetOrdersWithDapper();
        }

        [Route("GetOrderWithDapperElapsed")]
        [HttpGet]
        public string GetOrdersWithDapperElapsed()
        {

            return _orderService.GetOrdersWithDapperElapsed();
        }

        [Route("GetOrderWithEFCoreElapsed")]
        [HttpGet]
        public string GetOrderWithEFCoreElapsed()
        {

            return _orderService.GetOrdersWithEFCoreElapsed();
        }


    }
}


