using EFCore.EntityMapping.Categories;
using System.Collections.Generic;


namespace EFCore
{

    public interface IShipperRepository
    {
        List<Shippers> GetShippersWithEFCore();

        string GetShippersWithEFCoreElapsed();

        List<Shippers> GetShippersWithDapper();

        string GetShippersWithDapperElapsed();
    }
}


