using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storemextra
    {
        public decimal Id { get; set; }
        public decimal? Storemid { get; set; }
        public decimal? Extrasid { get; set; }
        public string Value { get; set; }
        public string Valuear { get; set; }

        public virtual Storetrnsextra Extras { get; set; }
        public virtual StoreTrnsM Storem { get; set; }
    }
}
