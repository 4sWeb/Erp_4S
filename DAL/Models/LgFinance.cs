using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class LgFinance
    {
        public decimal Id { get; set; }
        public decimal? LgTransactionId { get; set; }
        public decimal? FinancemId { get; set; }
        public decimal? LgStatusId { get; set; }

        public virtual Financem Financem { get; set; }
        public virtual LgTransaction LgTransaction { get; set; }
    }
}
