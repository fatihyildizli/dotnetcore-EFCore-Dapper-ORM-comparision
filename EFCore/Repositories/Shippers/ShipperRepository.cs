using Dapper;
using EFCore.EntityMapping.Categories;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;


namespace EFCore.Repositories
{
    public class ShipperRepository : BaseRepository, IShipperRepository
    {
        public ShipperRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public List<Shippers> GetShippersWithEFCore()
        {
            List<Shippers> shippers = new List<Shippers>();
            using (var entity = new ShippersContext())

            {

                shippers = entity.ShippersSet.ToList();

            }

            return shippers ?? new List<Shippers>();

        }

        public string GetShippersWithEFCoreElapsed()
        {

            var result = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            GetShippersWithEFCore();
            stopwatch.Stop();
            result = string.Format("Elapsed time with EFCore: {0}", stopwatch.Elapsed);
            return result;
        }



        public List<Shippers> GetShippersWithDapper()
        {
            List<Shippers> shippers = new List<Shippers>();

            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();

                shippers = dbConnection.Query<Shippers>(@"select * From Shippers(nolock)").AsList();

            }

            return shippers ?? new List<Shippers>();


        }

        public string GetShippersWithDapperElapsed()
        {

            var result = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            GetShippersWithDapper();
            stopwatch.Stop();
            result = string.Format("Elapsed time with Dapper: {0}", stopwatch.Elapsed);
            return result;
        }

       
    }



}
