using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EFCore
{
    public abstract class BaseRepository
    {
        private string connectionString;

        public BaseRepository(IConfiguration configuration)
        {
            connectionString = configuration["DatabaseSettings:ConnectionString"];
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(connectionString);
            }
        }
    }
}
