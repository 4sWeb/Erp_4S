using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Multydistview
    {
        public decimal? Id { get; set; }
        public decimal? StoreAllcodesId { get; set; }
        public decimal? FinanceAnlsCodesId { get; set; }
        public decimal? Financemid { get; set; }
        public string AssetscodeId { get; set; }
        public string AssetscodeName { get; set; }
        public string CostId { get; set; }
        public string CostName { get; set; }
        public string FtName { get; set; }
        public string Notes { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string ExpName { get; set; }
        public decimal? Hasaccount { get; set; }
        public decimal? Hasdimention { get; set; }
        public decimal? Hasdists { get; set; }
        public decimal? Hasexpensses { get; set; }
    }
}
