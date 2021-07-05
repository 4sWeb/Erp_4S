using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storetrnsmcommittee
    {
        public decimal Id { get; set; }
        public decimal? Committeeid { get; set; }
        public decimal? Transid { get; set; }
        public decimal? Employeeid { get; set; }
        public string Employeename { get; set; }

        public virtual Committee Committee { get; set; }
        public virtual StoreTrnsM Trans { get; set; }
    }
}
