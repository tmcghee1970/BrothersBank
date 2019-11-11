using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrothersBank.Models
{
    public class AccountType
    {
        [Key]
        public string AccountTypeCode { get; set; }

        public int AccountTypeFamilyId { get; set; }

        public string AccountTypeName { get; set; }
        
        public string AccountTypeDescription { get; set; }

        public decimal MonthlyFee { get; set; }

        public decimal AnnualPercentageYield { get; set; }

        public decimal MinimumOpeningDeposity { get; set; }
    }
}