using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CustomerDimensionsdetail
    {
        public decimal Id { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public decimal? DimensionsdetailsId { get; set; }
        public decimal? DimensionsdetailsParentid { get; set; }

        public virtual Dimensionsdetail Dimensionsdetails { get; set; }
        public virtual StoreAllcode StoreAllcodes { get; set; }
    }
}
