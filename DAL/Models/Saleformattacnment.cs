using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Saleformattacnment
    {
        public decimal? Saleformid { get; set; }
        public string Name { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public decimal? Feautersvalue { get; set; }
        public decimal? Totalvalue2 { get; set; }
        public string Sperateinstalments { get; set; }
        public string Pricelistsubject { get; set; }
        public string InstprogramsId { get; set; }
        public string Ownercompany { get; set; }
        public decimal Attachid { get; set; }
        public decimal? Servicesvalue { get; set; }
        public decimal? Quantity1 { get; set; }
        public decimal? Unitval1 { get; set; }
    }
}
