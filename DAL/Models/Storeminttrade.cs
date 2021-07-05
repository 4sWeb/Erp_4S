using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storeminttrade
    {
        public decimal Id { get; set; }
        public decimal? Intradeid { get; set; }
        public decimal? Storemid { get; set; }

        public virtual Inttradespec Intrade { get; set; }
        public virtual StoreTrnsM Storem { get; set; }
    }
}
