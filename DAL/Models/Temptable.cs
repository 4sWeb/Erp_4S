using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Temptable
    {
        public decimal? AccountId { get; set; }
        public decimal? Periodid { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? CurrencyId { get; set; }
        public decimal? CurremcyRate { get; set; }
        public string Currencyaname { get; set; }
        public string Currencyename { get; set; }
        public decimal? Netvalue { get; set; }
        public string Id { get; set; }
    }
}
