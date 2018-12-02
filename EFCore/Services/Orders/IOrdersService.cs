using EFCore.EntityMapping.Categories;
using System.Collections.Generic;


namespace EFCore
{
    public interface IOrdersService
    {
        List<Orders> GetOrdersWithEFCore();

        string GetOrdersWithEFCoreElapsed();
        List<Orders> GetOrdersWithDapper();

        string GetOrdersWithDapperElapsed();
    }

   
}
