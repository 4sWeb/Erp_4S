using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreCustDeposit
    {
        public decimal StoreCustDepositId { get; set; }
        public decimal? StoreId { get; set; }
        public decimal? CustId { get; set; }

        public virtual StoreAllcode Cust { get; set; }
        public virtual StoreAllcode Store { get; set; }
    }
}
