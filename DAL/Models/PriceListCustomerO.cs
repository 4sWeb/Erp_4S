using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class PriceListCustomerO
    {
        public decimal Id { get; set; }
        public decimal? PriceListCustomerId { get; set; }
        public decimal? DimensionsdetailsId { get; set; }
        public decimal? Percent { get; set; }

        public virtual Dimensionsdetail Dimensionsdetails { get; set; }
        public virtual PriceListCustomer PriceListCustomer { get; set; }
    }
}
