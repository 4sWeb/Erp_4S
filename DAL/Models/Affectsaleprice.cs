using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Affectsaleprice
    {
        public decimal? Saleformid { get; set; }
        public decimal? Affect { get; set; }
        public decimal? Notaffect { get; set; }
    }
}
