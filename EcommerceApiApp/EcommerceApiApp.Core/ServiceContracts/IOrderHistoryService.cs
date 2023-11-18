using EcommerceApiApp.Core.DTO;

namespace EcommerceApiApp.Core.ServiceContracts
{
    public interface IOrderHistoryService
    {
        Task<OrderDetailsResponse> GetCutomerOrderHistory(CustomerOrderRequest customerOrderRequest);
    }
}
