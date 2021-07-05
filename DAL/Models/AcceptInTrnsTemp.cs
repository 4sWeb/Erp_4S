using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class AcceptInTrnsTemp
    {
        public decimal Id { get; set; }
        public decimal? TrnsId { get; set; }
        public decimal? AcceptId { get; set; }
        public decimal? IsAccepted { get; set; }
        public decimal? UserId { get; set; }
        public string Reason { get; set; }
        public DateTime? Acceptdate { get; set; }
        public decimal? Commited { get; set; }
        public string Rowstate { get; set; }

        public virtual StoreTrnsAccept Accept { get; set; }
        public virtual StoreTrnsMTemp Trns { get; set; }
        public virtual User User { get; set; }
    }
}
