using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Sumitemoutbyallstoreview
    {
        public decimal? Squantity { get; set; }
        public decimal? Sprice { get; set; }
        public decimal? ItemId { get; set; }
        public decimal StoreAllcodesId { get; set; }
        public DateTime? TrnsDate { get; set; }
    }
}
