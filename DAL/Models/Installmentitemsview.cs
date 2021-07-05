using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Installmentitemsview
    {
        public decimal? Id { get; set; }
        public decimal? Tableid { get; set; }
        public string Institemcode { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
        public decimal? Quantity2 { get; set; }
        public decimal? Unitval2 { get; set; }
        public decimal? Institemvalue1 { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Totalvalue2 { get; set; }
        public string Instalmentrulesaname { get; set; }
        public decimal? ProfitRatio { get; set; }
        public string AffectReserve { get; set; }
        public string AffectContract { get; set; }
        public string AffectOthers { get; set; }
        public string AffectEnd { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? Attachvalue { get; set; }
        public decimal? Featurevalue { get; set; }
        public decimal? Servicevalue { get; set; }
        public DateTime? Dd { get; set; }
        public decimal? Status { get; set; }
    }
}
