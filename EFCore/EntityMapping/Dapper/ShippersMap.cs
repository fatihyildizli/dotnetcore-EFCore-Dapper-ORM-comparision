using Dapper.FluentMap.Mapping;
using EFCore.EntityMapping.Categories;

namespace EFCore.EntityMapping
{
    public class ShippersMap : EntityMap<Shippers>
    {
        public ShippersMap()
        {
            Map(i => i.Id).ToColumn("ShipperID");
            Map(i => i.CompanyName).ToColumn("CompanyName");
            Map(i => i.Phone).ToColumn("Phone");
        }
    }
}
