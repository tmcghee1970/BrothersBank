using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrothersBank.Models
{
    public class Account
    {
        
        [Key]
        public int AccountNumber { get; set; }

        public string AccountStatusCode { get; set; }
        
        public string AccountTypeCode { get; set; }
        
        public int CustomerId { get; set; }
        
        public decimal CurrentBalance { get; set; }

        public DateTime BalanceAsOfDateTime { get; set; }
        
        public DateTime AccountOpenDate { get; set; }
        
        public DateTime AccountCloseDate { get; set; }
        
        public DateTime LastUpdateDate { get; set; }
    }
}