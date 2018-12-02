using Dapper.FluentMap.Mapping;
using EFCore.EntityMapping.Categories;


namespace EFCore.EntityMapping.Dapper
{
    public class OrdersMap : EntityMap<Orders>
    {
        public OrdersMap()
        {
            Map(i => i.Id).ToColumn("OrderID");
            Map(i => i.CustomerID).ToColumn("CustomerID");
            Map(i => i.EmployeeID).ToColumn("EmployeeID");
            Map(i => i.OrderDate).ToColumn("OrderDate");
            Map(i => i.RequiredDate).ToColumn("RequiredDate");
            Map(i => i.ShippedDate).ToColumn("ShippedDate");
            Map(i => i.ShipVia).ToColumn("ShipVia");
            Map(i => i.Freight).ToColumn("Freight");
            Map(i => i.ShipName).ToColumn("ShipName");
            Map(i => i.ShipAddress).ToColumn("ShipAddress");
            Map(i => i.ShipCity).ToColumn("ShipCity");
            Map(i => i.ShipRegion).ToColumn("ShipRegion");
            Map(i => i.ShipPostalCode).ToColumn("ShipPostalCode");
            Map(i => i.ShipCountry).ToColumn("ShipCountry");
        }
    }
}
