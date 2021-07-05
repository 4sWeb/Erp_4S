using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class MultydistDimension
    {
        public decimal Id { get; set; }
        public decimal? DimensionsdetailsId { get; set; }
        public decimal? MultydistId { get; set; }

        public virtual Dimensionsdetail Dimensionsdetails { get; set; }
        public virtual Multydist Multydist { get; set; }
    }
}
