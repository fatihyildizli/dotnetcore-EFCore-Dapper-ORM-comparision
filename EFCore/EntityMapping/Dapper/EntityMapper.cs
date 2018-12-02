using Dapper.FluentMap;


namespace EFCore.EntityMapping.Dapper
{
    public class EntityMapper : IEntityMapper
    {
        public EntityMapper()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new ShippersMap());
                config.AddMap(new OrdersMap());
               
            });
        }

    }
}
