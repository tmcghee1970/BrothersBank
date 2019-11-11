using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrothersBank.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        public int BranchId { get; set; }
        
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }
        
        public string LastName { get; set; }
        
        public string SSN { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }
        
        public string City { get; set; }
        
        public string State { get; set; }
        
        public string PostalCode { get; set; }

        public string EmailAddress { get; set; }
        
        public string HomePhone { get; set; }
        
        public string CellPhone { get; set; }
        
        public string WorkPhone { get; set; }
    }
}