using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrothersBank.Models
{
    public class TransactionType
    {
        public int TransactionTypeId { get; set; }

        public string TransactionTypeDescription { get; set; } //Deposit, Withdrawal, Transfer
    }
}