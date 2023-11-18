using EcommerceApiApp.Core.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.Domain.RepoContracts
{
    public interface ICustomerRepository
    {
        Task<int> CheckCustomerByEmnail(string email);
        Task<Customer> GetCustomerByEmnail(string email);
    }
}
