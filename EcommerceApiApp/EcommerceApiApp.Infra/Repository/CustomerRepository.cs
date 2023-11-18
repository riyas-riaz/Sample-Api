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


        public async Task<int> CheckCustomerByEmnail(string email)
        {
            int count = 0;
            string procedureName = "_checkCustomerByEmail";

            var parameters = new DynamicParameters();
            parameters.Add("userEmail", email, DbType.String);

            using (var connection = _dapperContext.CreateConnection())
            {
                count = Convert.ToInt32(await connection.ExecuteScalarAsync(procedureName, parameters, commandType: CommandType.StoredProcedure));
            }

            return count;
        }

        public async Task<Customer> GetCustomerByEmnail(string email)
        {
            Customer? customer = null;
            string procedureName = "_getCustomerByEmail";

            var parameters = new DynamicParameters();
            parameters.Add("userEmail", email, DbType.String);

            using (var connection = _dapperContext.CreateConnection())
            {
                customer = await connection.QueryFirstAsync<Customer>(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }

            return customer;
        }
    }
}
