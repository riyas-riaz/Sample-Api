using EcommerceApiApp.Core.Domain.Enitities;
using EcommerceApiApp.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.ServiceContracts
{
    public interface ICustomerService
    {
        Task<bool> CheckValidCustomer(CustomerOrderRequest customerOrderRequest);
        Task<Customer> GetCustomerByEmail(string email);
    }
}
