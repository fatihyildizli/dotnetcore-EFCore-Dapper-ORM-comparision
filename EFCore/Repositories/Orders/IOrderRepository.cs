using EFCore.EntityMapping.Categories;
using System.Collections.Generic;


namespace EFCore
{

    public interface IOrderRepository
    {
        List<Orders> GetOrdersWithEFCore();
        string GetOrdersWithEFCoreElapsed();
        List<Orders> GetOrdersWithDapper();
        string GetOrdersWithDapperElapsed();
    }
}


