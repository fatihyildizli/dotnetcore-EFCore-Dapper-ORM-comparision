using System.Collections.Generic;
using EFCore.EntityMapping.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace EFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipperController : ControllerBase
    {

        readonly IShippersService _shipperService;
        IConfiguration _iconfiguration;

        public ShipperController(IShippersService shipperService, IConfiguration iconfiguration)
        {
            _shipperService = shipperService;
            _iconfiguration = iconfiguration;
        }


        [Route("GetShipperWithEFCore")]
        [HttpGet]
        public List<Shippers> GetShippersWithEFCore()
        {

            return _shipperService.GetShippersWithEFCore();
        }

        [Route("GetShipperWithEFCoreElapsed")]
        [HttpGet]
        public string GetShippersWithEFCoreElapsed()
        {

            return _shipperService.GetShippersWithEFCoreElapsed();
        }


        [Route("GetShipperWithDapper")]
        [HttpGet]
        public List<Shippers> GetShippersWithDapper()
        {

            return _shipperService.GetShippersWithDapper();
        }

        [Route("GetShipperWithDapperElapsed")]
        [HttpGet]
        public string GetShippersWithDapperElapsed()
        {

            return _shipperService.GetShippersWithDapperElapsed();
        }


    }
}


