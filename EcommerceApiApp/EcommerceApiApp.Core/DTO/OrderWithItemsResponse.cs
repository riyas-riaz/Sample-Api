using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.DTO
{
    public class OrderWithItemsResponse
    {
        public string orderNumber { get; set; } = string.Empty;
        public string orderDate { get; set; } = string.Empty;
        public string deliveryAddress { get; set; } = string.Empty;
        public IEnumerable<OrderItemsResponse>? orderItems { get; set; }
        public string deliveryExpected { get; set; } = string.Empty;
    }
}
