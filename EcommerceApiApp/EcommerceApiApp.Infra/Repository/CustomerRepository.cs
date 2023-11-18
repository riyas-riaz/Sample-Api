using EcommerceApiApp.Core.Domain.Enitities;
using EcommerceApiApp.Core.Domain.RepoContracts;
using System.Data;
using Dapper;
using EcommerceApiApp.Infra.DB_Context;

namespace EcommerceApiApp.Infra.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DapperContext _dapperContext;
        public CustomerRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }

        public async Task<Customer> GetCustomerByEmnail(string email)
        {
            Customer customer = null;
            string procedureName = "_getProducts";

            var parameters = new DynamicParameters();
            parameters.Add("user", id, DbType.Int16);
            parameters.Add("token", refreshToken.Token, DbType.String);
            parameters.Add("expire", refreshToken.Expires, DbType.DateTime);
            parameters.Add("created", refreshToken.Created, DbType.DateTime);

            using (var connection = _dapperContext.CreateConnection())
            {
                customer = await connection.QueryFirstOrDefaultAsync<Customer>(procedureName, commandType: CommandType.StoredProcedure);
            }

            return customer;
        }
    }
}
