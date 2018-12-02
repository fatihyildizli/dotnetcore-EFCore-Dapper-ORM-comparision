using EFCore.EntityMapping.Categories;
using Microsoft.EntityFrameworkCore;


namespace EFCore
{
    class ShippersContext : BaseContext
    {
        public DbSet<Shippers> ShippersSet { get; set; }
      

    }

}
