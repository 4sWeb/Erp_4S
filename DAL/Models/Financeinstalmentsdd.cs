using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Financeinstalmentsdd
    {
        public decimal Id { get; set; }
        public decimal? Trnsid { get; set; }
        public decimal? Checkid { get; set; }
        public string Paytype { get; set; }
        public decimal? Instalmentid { get; set; }
        public decimal? Fval { get; set; }
        public decimal? Rentinstalmentid { get; set; }
        public decimal? Penaltyval { get; set; }
        public decimal? Fixedcostval { get; set; }
        public decimal? Earlydiscount { get; set; }
        public DateTime Dd { get; set; }
    }
}
