using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsoDimensionsdetail
    {
        public decimal Id { get; set; }
        public decimal? DimensionsdetailsId { get; set; }
        public decimal? StoreTrnsOId { get; set; }

        public virtual Dimensionsdetail Dimensionsdetails { get; set; }
        public virtual StoreTrnsO StoreTrnsO { get; set; }
    }
}
