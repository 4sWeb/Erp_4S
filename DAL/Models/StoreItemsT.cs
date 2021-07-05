using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemsT
    {
        public decimal? StoreItemfromsSpecsId { get; set; }
        public string ItemCode { get; set; }
        public string Aname { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public decimal? UnitId { get; set; }
        public decimal IQty { get; set; }
        public decimal? StoreItemsId { get; set; }
    }
}
