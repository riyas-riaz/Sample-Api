using EcommerceApiApp.Core.Domain.RepoContracts;
using EcommerceApiApp.Core.ServiceContracts;
using EcommerceApiApp.Core.Services;
using EcommerceApiApp.Infra.DB_Context;
using EcommerceApiApp.Infra.Repository;

namespace EcommerceApiApp.Extension_Methods
{
    public static class DIExtension
    {
        public static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<DapperContext>();
            builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IOrderHistoryService, OrderHistoryService>();
        }
    }
}
