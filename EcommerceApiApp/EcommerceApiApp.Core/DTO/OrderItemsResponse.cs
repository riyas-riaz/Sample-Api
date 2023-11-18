using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.DTO
{
    public class OrderItemsResponse
    {
        public string product { get; set; } = string.Empty;
        public int quantity { get; set; } = 0;
        public double priceEach { get; set; } = 0.0;
    }
}
