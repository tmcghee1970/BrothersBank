﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrothersBank.Models
{
    public class Branch
    {
        public int BranchId { get; set; }

        public string BranchName { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }
    }
}