using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemPrice
    {
        public decimal Id { get; set; }
        public decimal? Itemid { get; set; }
        public decimal? Ipurchprice { get; set; }
        public decimal? Period { get; set; }

        public virtual StoreItem Item { get; set; }
        public virtual Period PeriodNavigation { get; set; }
    }
}
