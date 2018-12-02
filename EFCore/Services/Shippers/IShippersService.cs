using EFCore.EntityMapping.Categories;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    public interface IShippersService
    {
        List<Shippers> GetShippersWithEFCore();

        string GetShippersWithEFCoreElapsed();

        List<Shippers> GetShippersWithDapper();

        string GetShippersWithDapperElapsed();
    }

   
}
