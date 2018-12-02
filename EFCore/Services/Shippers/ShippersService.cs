using EFCore.EntityMapping.Categories;
using System.Collections.Generic;


namespace EFCore
{
    public class ShippersService : IShippersService
    {
        private readonly IShipperRepository _shipperRepository;
        public ShippersService(IShipperRepository shipperRepository)
        {
            _shipperRepository = shipperRepository;

        }

        public List<Shippers> GetShippersWithEFCore()
        {
            return _shipperRepository.GetShippersWithEFCore();
        }


        public string GetShippersWithEFCoreElapsed()
        {

            return _shipperRepository.GetShippersWithEFCoreElapsed();
        }


        public List<Shippers> GetShippersWithDapper()
        {
            return _shipperRepository.GetShippersWithDapper();
        }

        public string GetShippersWithDapperElapsed()
        {

            return _shipperRepository.GetShippersWithDapperElapsed();
        }

       
    }



}
