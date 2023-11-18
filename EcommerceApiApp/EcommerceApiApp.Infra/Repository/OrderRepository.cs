using Dapper;
using EcommerceApiApp.Core.Domain.Enitities;
using EcommerceApiApp.Core.Domain.RepoContracts;
using EcommerceApiApp.Core.DTO;
using EcommerceApiApp.Infra.DB_Context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Infra.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly DapperContext _dapperContext;
        public OrderRepository(DapperContext dapperContext)
        {
            _dapperContext = dapperContext;
        }
        public async Task<IEnumerable<OrderItemsResponse>> GetAllOrderedItemsForUser(string userEmail)
        {
            IEnumerable<OrderItemsResponse> orderItemsResponses = null;
            string procedureName = "_getOrderItems";

            var parameters = new DynamicParameters();
            parameters.Add("userEmail", userEmail, DbType.String);

            using (var connection = _dapperContext.CreateConnection())
            {
                orderItemsResponses = await connection.QueryAsync<OrderItemsResponse>(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }

            return orderItemsResponses;
        }

        public async Task<IEnumerable<OrderResponse>> GetAllOrdersForUser(string userEmail)
        {
            IEnumerable<OrderResponse> orderResponses = null;
            string procedureName = "_getAllOrderForUser";

            var parameters = new DynamicParameters();
            parameters.Add("userEmail", userEmail, DbType.String);

            using (var connection = _dapperContext.CreateConnection())
            {
                orderResponses = await connection.QueryAsync<OrderResponse>(procedureName, parameters, commandType: CommandType.StoredProcedure);
            }

            return orderResponses;
        }
    }
}
