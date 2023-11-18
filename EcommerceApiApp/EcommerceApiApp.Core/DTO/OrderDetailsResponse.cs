using EcommerceApiApp.Core.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.DTO
{
    public class OrderDetailsResponse
    {
        public CustomerResponse customer { get; set; }
        public OrderWithItemsResponse order { get; set; }
    }
}
