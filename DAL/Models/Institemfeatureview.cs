using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemfeatureview
    {
        public decimal InstitemId { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public string Sperateinstalments { get; set; }
        public string Pricelistsubject { get; set; }
        public string Instprogname { get; set; }
        public string Ownercompany { get; set; }
        public string Eownercompany { get; set; }
        public decimal Featureid { get; set; }
        public decimal? Featurequantity1 { get; set; }
        public decimal? Featureunitval1 { get; set; }
        public string Featurename { get; set; }
        public string Featureename { get; set; }
    }
}
