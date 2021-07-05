using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Storetrnsmpayspec
    {
        public decimal Id { get; set; }
        public decimal? Transid { get; set; }
        public string Batchno { get; set; }
        public string Batchname { get; set; }
        public DateTime? Batchdate { get; set; }
        public decimal? Batchpercentage { get; set; }
        public decimal? Value { get; set; }

        public virtual StoreTrnsM Trans { get; set; }
    }
}
