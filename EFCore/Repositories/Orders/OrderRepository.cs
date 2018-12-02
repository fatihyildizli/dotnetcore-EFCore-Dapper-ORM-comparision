using Dapper;
using EFCore.EntityMapping.Categories;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;


namespace EFCore.Repositories
{
   public class OrderRepository : BaseRepository, IOrderRepository
    {
        public OrderRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public List<Orders> GetOrdersWithEFCore()
        {
            List<Orders> orders = new List<Orders>();

            using (var entity = new OrdersContext())

            {

                orders = entity.OrdersSet.ToList();

            }


            return orders ?? new List<Orders>();

        }

        public string GetOrdersWithEFCoreElapsed()
        {

            var result = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            GetOrdersWithEFCore();
            stopwatch.Stop();
            result = string.Format("Elapsed time with EFCore: {0}", stopwatch.Elapsed);
            return result;
        }


        public List<Orders> GetOrdersWithDapper()
        {
            List<Orders> orders = new List<Orders>();
            
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                
                orders = dbConnection.Query<Orders>(@"select * From Orders(nolock)").AsList();

            }

            return orders ?? new List<Orders>();
       

        }

        public string GetOrdersWithDapperElapsed()
        {

            var result = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            GetOrdersWithDapper();
            stopwatch.Stop();
            result = string.Format("Elapsed time with Dapper: {0}", stopwatch.Elapsed);
            return result;
        }
    }

  

}
