using EcommerceApiApp.Core.Domain.Enitities;
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
        private readonly ICustomerService _customerService;
        public OrderHistoryService(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<OrderDetailsResponse> GetCutomerOrderHistory(CustomerOrderRequest customerOrderRequest)
        {
            OrderDetailsResponse orderDetailsResponse = new OrderDetailsResponse();

            Customer customer = await _customerService.GetCustomerByEmail(customerOrderRequest.User??"");

            CustomerResponse customerRes = new CustomerResponse() { firstName = customer.FirstName, lastName = customer.LastName };

            return orderDetailsResponse;
        }
    }
}
