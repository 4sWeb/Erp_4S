using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AcceptInFinancetrn
    {
        public decimal Id { get; set; }
        public decimal? TrnsId { get; set; }
        public decimal? AcceptId { get; set; }
        public decimal? IsAccepted { get; set; }
        public decimal? UserId { get; set; }
        public string Reason { get; set; }
        public DateTime? Acceptdate { get; set; }

        public virtual FinanceTrnsAccept Accept { get; set; }
        public virtual Financem Trns { get; set; }
        public virtual User User { get; set; }
    }
}
