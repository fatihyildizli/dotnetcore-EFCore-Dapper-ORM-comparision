using EFCore.EntityMapping.Categories;
using System.Collections.Generic;


namespace EFCore
{
    public class OrdersService : IOrdersService
    {
        private readonly IOrderRepository _orderRepository;
        public OrdersService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;

        }

        public List<Orders> GetOrdersWithEFCore()
        {
            return _orderRepository.GetOrdersWithEFCore();
        }

        public List<Orders> GetOrdersWithDapper()
        {
            return _orderRepository.GetOrdersWithDapper();
        }

        
        public string GetOrdersWithDapperElapsed()
        {

            return _orderRepository.GetOrdersWithDapperElapsed();
        }

        public string GetOrdersWithEFCoreElapsed()
        {

            return _orderRepository.GetOrdersWithEFCoreElapsed();
        }

    }



}
