using EcommerceApiApp.Core.DTO;
using EcommerceApiApp.Core.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.Services
{
    public class OrderHistoryService : IOrderHistoryService
    {
        public async Task<OrderDetailsResponse> GetCutomerOrderHistory(CustomerOrderRequest customerOrderRequest)
        {
            throw new NotImplementedException();
        }
    }
}
