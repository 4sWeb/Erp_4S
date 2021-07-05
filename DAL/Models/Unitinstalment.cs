using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Unitinstalment
    {
        public decimal Id { get; set; }
        public decimal? Saleformid { get; set; }
        public decimal? Val { get; set; }
        public DateTime? Indate { get; set; }
        public string Serialname { get; set; }
        public string Serialename { get; set; }
        public string Tableflag { get; set; }
        public string Instalmentname { get; set; }
        public decimal? Sumcontractrecived { get; set; }
        public decimal? Suminstalments { get; set; }
        public decimal? Sumremaining { get; set; }
        public decimal? Totalvalue { get; set; }
    }
}
