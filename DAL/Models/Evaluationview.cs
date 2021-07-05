using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Evaluationview
    {
        public decimal TrnsNo { get; set; }
        public DateTime Masterdate { get; set; }
        public DateTime? Evaldate { get; set; }
        public decimal? Itemid { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public string Note { get; set; }
        public decimal? StoreTrnsOId { get; set; }
        public decimal? Isselected { get; set; }
        public decimal? FromStoreAllcodesId { get; set; }
        public string Itemaname { get; set; }
        public string Itemename { get; set; }
        public string Groupaname { get; set; }
        public string Groupename { get; set; }
        public string Vendoraname { get; set; }
        public string Vendorename { get; set; }
        public decimal Detailtrnsno { get; set; }
        public decimal? Disc { get; set; }
        public decimal? Stax { get; set; }
        public decimal? Lastprice { get; set; }
        public decimal Id { get; set; }
    }
}
