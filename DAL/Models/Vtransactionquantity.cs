using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Vtransactionquantity
    {
        public decimal TrnsCode { get; set; }
        public decimal TrnsNo { get; set; }
        public decimal? Branch { get; set; }
        public decimal? Qty { get; set; }
    }
}
