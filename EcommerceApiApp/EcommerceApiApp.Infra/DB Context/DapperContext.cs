using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EcommerceApiApp.Infra.DB_Context
{
    public class DapperContext
    {
        private readonly string _connectionString;
        public DapperContext(IConfiguration iconfiguration)
        {
            _connectionString = iconfiguration?.GetConnectionString("SqlConnction") ?? "";
        }

        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
