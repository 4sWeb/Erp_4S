using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class GetCostbyitempreviousview
    {
        public decimal? Quantity { get; set; }
        public decimal? ItemId { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public DateTime? TrnsDate { get; set; }
    }
}
