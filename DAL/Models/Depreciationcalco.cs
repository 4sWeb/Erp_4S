using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Depreciationcalco
    {
        public decimal Id { get; set; }
        public decimal? Deprtype { get; set; }
        public decimal? Deprpercent { get; set; }
        public decimal? Deprvalue { get; set; }
        public DateTime? Olddeprdate { get; set; }
        public DateTime? Newdeprdate { get; set; }
        public decimal? Assetid { get; set; }
        public decimal? Deprectionmid { get; set; }

        public virtual Asset Asset { get; set; }
        public virtual Depreciationcalcm Deprectionm { get; set; }
    }
}
