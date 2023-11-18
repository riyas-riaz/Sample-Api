using EcommerceApiApp.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.Domain.RepoContracts
{
    public interface IOrderRepository
    {
        Task<IEnumerable<OrderItemsResponse>> GetAllOrderedItemsForUser(string userEmail);
        Task<IEnumerable<OrderResponse>> GetAllOrdersForUser(string userEmail);
    }
}
