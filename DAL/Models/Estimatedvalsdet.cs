using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Estimatedvalsdet
    {
        public decimal Id { get; set; }
        public decimal? Estimatedvalsid { get; set; }
        public decimal? Dimensiondetailsid { get; set; }
        public decimal? Debitval { get; set; }
        public decimal? Creditval { get; set; }

        public virtual Dimensionsdetail Dimensiondetails { get; set; }
        public virtual Estimatedval Estimatedvals { get; set; }
    }
}
