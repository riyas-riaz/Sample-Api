using EcommerceApiApp.Core.DTO;
using EcommerceApiApp.Core.ServiceContracts;
using EcommerceApiApp.Core.Validation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderHistoryController : ControllerBase
    {
        private readonly IOrderHistoryService _orderHistoryService;
        private readonly ICustomerService _customerService;
        public OrderHistoryController(IOrderHistoryService orderHistoryService, ICustomerService customerService) 
        {
            _orderHistoryService = orderHistoryService;
            _customerService = customerService;
        }

        [HttpPost]
        [Route("get_order_details")]
        public async Task<IActionResult> GetOrderDetails(CustomerOrderRequest customerOrderRequest)
        {
            try
            {
                CustomerOrderRequestValidator validationRules = new CustomerOrderRequestValidator();
                ValidationResult validationResult = validationRules.Validate(customerOrderRequest);
                if (!validationResult.IsValid)
                {
                    return BadRequest(validationResult.Errors[0].ErrorMessage);
                }

                bool isValidUser = await _customerService.CheckValidCustomer(customerOrderRequest);
                if (!isValidUser)
                {
                    return BadRequest("Invalid User.");
                }

                return Ok(await _orderHistoryService.GetCutomerOrderHistory(customerOrderRequest));
            }
            catch (Exception ex)
            {
                //write the exception details using log
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
