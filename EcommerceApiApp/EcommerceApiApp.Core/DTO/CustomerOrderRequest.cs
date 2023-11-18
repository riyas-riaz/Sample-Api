using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.DTO
{
    public class CustomerOrderRequest
    {
        public string? User { get; set; }
        public string? CustomerId { get; set;}
    }
}
