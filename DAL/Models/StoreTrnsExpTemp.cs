using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class StoreTrnsExpTemp
    {
        public decimal StoreTrnsExpId { get; set; }
        public decimal? StoreTrnsOId { get; set; }
        public decimal? StoreId { get; set; }
        public DateTime? ExpDate { get; set; }
        public DateTime? ProdDate { get; set; }
        public string ProdNo { get; set; }
        public string BatchNo { get; set; }
        public string ControlNo { get; set; }
        public string LotNo { get; set; }
        public string Location { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Unitid { get; set; }
        public decimal? Itembalexpid { get; set; }
        public decimal? Commited { get; set; }
        public string Rowstate { get; set; }

        public virtual StoreAllcode Store { get; set; }
        public virtual StoreTrnsOTemp StoreTrnsO { get; set; }
    }
}
