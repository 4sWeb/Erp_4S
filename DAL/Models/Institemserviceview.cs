using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Institemserviceview
    {
        public decimal Institemid { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public decimal? Totalvalue1 { get; set; }
        public string Sperateinstalments { get; set; }
        public string Pricelistsubject { get; set; }
        public string Instprogname { get; set; }
        public string Ownercompany { get; set; }
        public string Eownercompany { get; set; }
        public decimal Serviceid { get; set; }
    }
}
