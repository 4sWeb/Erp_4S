using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreItemsBalExp
    {
        public decimal BalExpId { get; set; }
        public decimal? StoreItemsBalId { get; set; }
        public DateTime? ExpDate { get; set; }
        public DateTime? ProdDate { get; set; }
        public string ProdNo { get; set; }
        public string BatchNo { get; set; }
        public string ControlNo { get; set; }
        public string LotNo { get; set; }
        public string Location { get; set; }
        public decimal? Iqty { get; set; }
        public decimal? Unitid { get; set; }
        public decimal? Poolid { get; set; }

        public virtual StoreItemsBal StoreItemsBal { get; set; }
    }
}
