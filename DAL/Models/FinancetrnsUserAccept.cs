using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FinancetrnsUserAccept
    {
        public decimal Id { get; set; }
        public decimal AcceptId { get; set; }
        public decimal Userid { get; set; }

        public virtual FinanceTrnsAccept Accept { get; set; }
        public virtual User User { get; set; }
    }
}
