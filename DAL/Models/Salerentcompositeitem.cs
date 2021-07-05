using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Salerentcompositeitem
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Rentformid { get; set; }
        public decimal? Composititemid { get; set; }

        public virtual Rentform Rentform { get; set; }
        public virtual Saleform Saleform { get; set; }
    }
}
