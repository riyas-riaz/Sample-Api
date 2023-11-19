using EcommerceApiApp.Core.Domain.Enitities;
using EcommerceApiApp.Core.Domain.RepoContracts;
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
        private readonly IOrderRepository _orderRepository;
        public OrderHistoryService(ICustomerService customerService, IOrderRepository orderRepository)
        {
            _customerService = customerService;
            _orderRepository = orderRepository;
        }

        public async Task<OrderDetailsResponse> GetCutomerOrderHistory(CustomerOrderRequest customerOrderRequest)
        {
            Customer customer = await _customerService.GetCustomerByEmail(customerOrderRequest.User??"");
            CustomerResponse customerRes = new CustomerResponse() { firstName = customer.FirstName, lastName = customer.LastName };

            OrderResponse orderResponse = await _orderRepository.GetMostRecentOrderForUser(customerOrderRequest.User ?? "");
            IEnumerable<OrderItemsResponse> orderItemsResponse = await _orderRepository.GetAllOrderedItemsForUser(customerOrderRequest.User ?? "");

            OrderWithItemsResponse orderWithItemsResponse = new OrderWithItemsResponse() 
            { 
                orderNumber = orderResponse.orderNumber,
                orderDate = orderResponse.orderDate,
                deliveryAddress = orderResponse.deliveryAddress,
                orderItems = orderItemsResponse,
                deliveryExpected = orderResponse.deliveryExpected
            };


            OrderDetailsResponse orderDetailsResponse = new OrderDetailsResponse()
            {
                customer = customerRes,
                order = orderWithItemsResponse
            };

            return orderDetailsResponse;
        }
    }
}
