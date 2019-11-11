using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrothersBank.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public int AccountNumber { get; set; }
        
        public string TransactionTypeId { get; set; }

        public string TransactionDescription { get; set; }
        
        public DateTime TransactionDateTime { get; set; }
                
        public decimal TransactionAmount { get; set; }
    }
}