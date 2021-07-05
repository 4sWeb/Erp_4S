using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financeinvdist
    {
        public decimal? Financeid { get; set; }
        public decimal? Invid { get; set; }
        public decimal? Finorderid { get; set; }
        public decimal? Checkid { get; set; }
        public decimal? Findiscountid { get; set; }
        public decimal? Grossval { get; set; }
        public decimal? Discountval { get; set; }
        public decimal Id { get; set; }

        public virtual Financem Finance { get; set; }
        public virtual StoreTrnsM Inv { get; set; }
    }
}
