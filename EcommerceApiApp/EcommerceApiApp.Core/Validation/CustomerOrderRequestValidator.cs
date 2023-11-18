using EcommerceApiApp.Core.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.Validation
{
    public class CustomerOrderRequestValidator : AbstractValidator<CustomerOrderRequest>
    {
        public CustomerOrderRequestValidator() 
        {
            RuleFor(x => x.User).NotEmpty();
            RuleFor(x => x.CustomerId).NotEmpty();

            //we can write the code here for complete validation for checking valid email, custome validation...
        }
    }
}
