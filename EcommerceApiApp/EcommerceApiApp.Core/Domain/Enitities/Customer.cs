using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApiApp.Core.Domain.Enitities
{
    public class Customer
    {
        public int CUSTOMERID { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMAIL { get; set; } = string.Empty;
        public string HOUSENO { get; set; } = string.Empty;
        public string STREET { get; set; } = string.Empty;
        public string TOWN { get; set; } = string.Empty;
        public string POSTCODE { get; set; } = string.Empty;
    }
}
