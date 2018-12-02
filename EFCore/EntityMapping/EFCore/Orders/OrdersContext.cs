using EFCore.EntityMapping.Categories;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    class OrdersContext :BaseContext
    {
        public DbSet<Orders> OrdersSet { get; set; }
      

    }

}
