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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        public CustomerService(ICustomerRepository repository) => _repository = repository;
        public async Task<bool> CheckValidCustomer(CustomerOrderRequest customerOrderRequest)
        {
            int count = await _repository.CheckCustomerByEmnail(customerOrderRequest.User??"");

            return count>0;
        }

        public async Task<Customer> GetCustomerByEmail(string email)
        {
            return await _repository.GetCustomerByEmnail(email ?? "");
        }
    }
}
