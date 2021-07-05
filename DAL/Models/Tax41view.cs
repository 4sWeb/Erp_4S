using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Tax41view
    {
        public decimal? Id { get; set; }
        public DateTime? Trnsdate { get; set; }
        public decimal? Grossvallocal { get; set; }
        public decimal? Commtax { get; set; }
        public decimal? Commtaxrate { get; set; }
        public decimal? Tdistid { get; set; }
        public string Taxnumber { get; set; }
        public string Fileno { get; set; }
        public string Financiername { get; set; }
        public string Financieraddress { get; set; }
        public string Mission { get; set; }
        public string Flagtype { get; set; }
        public string Invoicenum { get; set; }
        public string Shortname { get; set; }
    }
}
