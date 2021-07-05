using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Iteminbyallstoreview
    {
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? ItemId { get; set; }
        public decimal StoreAllcodesId { get; set; }
        public DateTime TrnsDate { get; set; }
    }
}
