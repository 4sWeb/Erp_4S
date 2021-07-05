using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tempindividualtable
    {
        public decimal? StoreId { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Currencyaname { get; set; }
        public string Currencyename { get; set; }
        public decimal? Checkdebit { get; set; }
        public decimal? Checkcredit { get; set; }
    }
}
